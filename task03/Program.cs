using System;

namespace task03
{
    internal class Program
    {
        private static void Main()
        {
            Accountant accountant = new Accountant();
            int workedHours = 100;
            Console.WriteLine(accountant.AskForBonus(Accountant.Position.Junior, workedHours));
            Console.WriteLine(accountant.AskForBonus(Accountant.Position.Middle, workedHours));
            Console.WriteLine(accountant.AskForBonus(Accountant.Position.Senior, workedHours));
        }
    }
}
