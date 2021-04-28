using System;

namespace task02
{
    internal class Program
    {
        private static void Main()
        {
            Console.WriteLine("Input string: ");
            string inputString = Console.ReadLine();
            Console.WriteLine("String color: ");
            int color = int.Parse(Console.ReadLine());
            ColorString.Print(inputString, color);
        }
    }
}
