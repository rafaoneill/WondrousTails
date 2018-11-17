using AetherCurrents.Database.Entities;
using SaintCoinach;
using SaintCoinach.Xiv;
using System;
using System.Linq;

namespace WolvesDen
{
    /// <summary>
    /// Class to handle reading data from the game assets
    /// </summary>
    public class GameData
    {
        private readonly AetherCurrentsContext _context;
        private readonly ARealmReversed _realm;

        /// <summary>
        /// Constructor. Sets up the DbContext and game assets to use.
        /// </summary>
        /// <param name="context">The DbContext.</param>
        /// <param name="realm">Contains the game assets.</param>
        public GameData(AetherCurrentsContext context, ARealmReversed realm)
        {
            _context = context;
            _realm = realm;
        }

        /// <summary>
        /// Begins transfering data from the game into the database
        /// </summary>
        public void BeginTransfer()
        {
            bool questDetailsChecked = false;
            bool questDetailsIsEmpty = false;

            foreach(var sheet in _realm.GameData.AvailableSheets.ToList())
            {
                var gameSheet = new GameSheet(_context, sheet);

                var typesFound = gameSheet.SetTypes();
                if(!typesFound)
                {
                    Utility.Message(MESSAGE_TYPE.WARNING, "Sheet/Entity/Repository not found. Skipping the insert for " + sheet);
                    continue;
                }

                bool destinationIsEmpty = false;
                if(sheet.StartsWith("quest") && sheet.Contains("/"))
                {
                    if(!questDetailsChecked)
                    {
                        destinationIsEmpty = gameSheet.DestinationIsEmpty();
                        questDetailsChecked = true;
                        questDetailsIsEmpty = destinationIsEmpty;
                    }
                    else
                    {
                        destinationIsEmpty = questDetailsIsEmpty;
                    }
                }
                else
                {
                    destinationIsEmpty = gameSheet.DestinationIsEmpty();
                }

                if(!destinationIsEmpty)
                {
                    Utility.Message(MESSAGE_TYPE.WARNING, "Table is not empty. Skipping the insert for " + sheet);
                    continue;
                }
                var sheetData = _realm.GameData.GetSheet(sheet).ToList();
                gameSheet.TransferData(sheetData);
            }
            Console.Read();
        }
    }
}