using AetherCurrents.Database.Entities;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using SaintCoinach.Xiv;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;

namespace WolvesDen
{
    /// <summary>
    /// Class to handle a single game asset represented by a <see cref="SaintCoinach.Xiv.XivSheet{T}" />.
    /// </summary>
    public class GameSheet
    {
        private readonly AetherCurrentsContext _context;
        private readonly string _sheet;
        private string _tableName;
        private bool _tableIsEmpty;

        private Type _sourceType;
        private Type _entityType;

        /// <summary>
        /// Constructor. Sets up the context and game sheet to use.
        /// </summary>
        /// <param name="context">The entity framework context.</param>
        /// <param name="sheet">The name of the game sheet.</param>
        public GameSheet(AetherCurrentsContext context, string sheet)
        {
            _context = context;
            _sheet = sheet;
        }

        /// <summary>
        /// Sets the types to work with for the data transfer.
        /// </summary>
        /// <returns>Whether or not all of the types are available to proceed with the transfer.</returns>
        public bool SetTypes()
        {
            _sourceType = Type.GetType("SaintCoinach.Xiv." + _sheet + ", SaintCoinach") ?? typeof(XivRow);

            if (!_sheet.Contains("/", StringComparison.CurrentCulture))
            {
                _entityType = Type.GetType("AetherCurrents.Database.Entities." + _sheet + ", AetherCurrents.Database");
                _tableName = _sheet;
            }
            else if (_sheet.StartsWith("quest", StringComparison.CurrentCulture))
            {
                _sourceType = typeof(XivRow);
                _entityType = typeof(QuestDetail);
                _tableName = _entityType.Name;
            }
            else if (_sheet.StartsWith("custom", StringComparison.CurrentCulture))
            {
                // Not Implemented
                _entityType = null;
                _tableName = null;
            }
            else
            {
                _entityType = null;
                _tableName = null;
            }

            if (_sourceType == null)
            {
                Utility.Message(MessageType.Error, string.Format(CultureInfo.CurrentCulture, "Source for {0} not found.", _sheet));
            }

            return _sourceType != null && _entityType != null;
        }

        /// <summary>
        /// Check if destination db table is empty
        /// </summary>
        /// <returns>Whether or not the table is empty</returns>
        public bool DestinationIsEmpty()
        {
            PropertyInfo pi = _context.GetType().GetProperty(_entityType.Name);
            var table = (IEnumerable<object>)pi.GetValue(_context);
            _tableIsEmpty = table.Count() == 0;
            return _tableIsEmpty;
        }

        /// <summary>
        /// Transfer game sheet data.
        /// </summary>
        /// <param name="data">The data to transfer.</param>
        /// <param name="overwriteTable">Whether or not to overwrite existing data.</param>
        public void TransferData(List<XivRow> data, bool overwriteTable = false)
        {
            if (!_tableIsEmpty && overwriteTable)
            {
                // Delete from table
            }

            int count = 0;
            int total = data.Count;
            Utility.Message(MessageType.Status, string.Format(CultureInfo.CurrentCulture, "{0} records for sheet " + _sheet, total));
            using (var transaction = _context.Database.BeginTransaction())
            {
                try
                {
                    foreach (var record in data.Select((d, i) => new { Item = d, Index = i }))
                    {
                        Type thisType = record.Item.GetType();
                        var sheetItem = Convert.ChangeType(record.Item, thisType, CultureInfo.CurrentCulture);

                        var dbItem = Mapper.Map(sheetItem, _sourceType, _entityType);

                        // Unnecessary Entity Framework Reflection Magic
                        var property = _context.GetType().GetProperty(_entityType.Name);
                        var method = property.GetValue(_context).GetType().GetMethod("Add");
                        method.Invoke(property.GetValue(_context), new object[] { dbItem });
                        _context.SaveChanges();
                        count++;
                        TrackProgress(count, total);
                    }

                    transaction.Commit();
                }
                catch (DbUpdateException e)
                {
                    Utility.Message(MessageType.Error, e.Message);
                    Utility.Message(MessageType.Error, e.InnerException?.Message);
                }
                catch (Exception e)
                {
                    Utility.Message(MessageType.Error, e.Message);
                    Utility.Message(MessageType.Error, e.StackTrace);
                    Utility.Message(MessageType.Error, e.InnerException?.Message);
                }
            }
        }

        private static void TrackProgress(int count, int total)
        {
            var percentage = Math.Truncate(((double)count / (double)total) * 100);
            Console.Write("\r{0}% - Record: {1}", percentage, count);
        }
    }
}