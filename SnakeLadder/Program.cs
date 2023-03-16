namespace SnakeLadder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*****  Snake & Ladder Problems  *****\n");
            RollDice rollDice = new RollDice();
            rollDice.Game();
        }
    }
}