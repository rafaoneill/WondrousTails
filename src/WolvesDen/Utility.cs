using System;
using System.Drawing;
using System.Globalization;
using System.IO;

namespace WolvesDen
{
    /// <summary>
    /// Types of messasges
    /// </summary>
    public enum MessageType
    {
        /// <summary>
        /// Represents status
        /// </summary>
        Status,

        /// <summary>
        /// Represents success
        /// </summary>
        Success,

        /// <summary>
        /// Represents info
        /// </summary>
        Info,

        /// <summary>
        /// Represents warning
        /// </summary>
        Warning,

        /// <summary>
        /// Represents error
        /// </summary>
        Error
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="Utility"/> class.
    /// </summary>
    public static class Utility
    {
        /// <summary>
        /// Writes a message to the console.
        /// </summary>
        /// <param name="type">The message type.</param>
        /// <param name="message">The message to write.</param>
        public static void Message(MessageType type, string message)
        {
            switch (type)
            {
                case MessageType.Error:
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                case MessageType.Warning:
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    break;
                case MessageType.Success:
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
                case MessageType.Info:
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    break;
                case MessageType.Status:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Black;
                    break;
            }

            Console.Write("\r{0}", type.ToString().ToLower(CultureInfo.CurrentCulture).PadRight(10));
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" {0}", message);
        }
    }
}
