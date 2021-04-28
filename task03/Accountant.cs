namespace task03
{
    public class Accountant
    {
        public enum Position
        {
            Junior = 80,
            Middle = 120,
            Senior = 160
        }
        public bool AskForBonus(Position worker, int hours)
        {
            return hours >= (int)worker;
        }
    }
}
