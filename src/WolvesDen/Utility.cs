using System;
using System.IO;
using System.Drawing;

namespace WolvesDen
{
    public enum MESSAGE_TYPE
    {
        STATUS,
        SUCCESS,
        INFO,
        WARNING,
        ERROR
    }

    public static class Utility
    {
        public static void Wait (double seconds)
        {
            System.Threading.Thread.Sleep((int)(1000 * seconds));
        }

        public static void Message (MESSAGE_TYPE type, string message)
        {
            switch(type)
            {
                case MESSAGE_TYPE.ERROR:
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                case MESSAGE_TYPE.WARNING:
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    break;
                case MESSAGE_TYPE.SUCCESS:
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
                case MESSAGE_TYPE.INFO:
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    break;
                case MESSAGE_TYPE.STATUS:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Black;
                    break;
            }

            Console.Write("\r{0}", type.ToString().ToLower().PadRight(10));
            //Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" {0}", message);
        }
    }
}
