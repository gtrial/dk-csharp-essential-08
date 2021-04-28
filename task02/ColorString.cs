using System;
namespace task02
{
    public static class ColorString
    {
        private enum Colors
        {
            Red,
            Green,
            Blue
        }

        public static void Print(string inputString, int color)
        {
            switch (color)
            {
                case (int)Colors.Red: { Console.ForegroundColor = ConsoleColor.Red; break; }
                case (int)Colors.Green: { Console.ForegroundColor = ConsoleColor.Green; break; }
                case (int)Colors.Blue: { Console.ForegroundColor = ConsoleColor.Blue; break; }
                default:
                    break;
            }
            Console.WriteLine(inputString);
            Console.ResetColor();
        }
    }
}
