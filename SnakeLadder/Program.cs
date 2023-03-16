namespace SnakeLadder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*****  Snake & Ladder Problems  *****\n");
            WinningPosition snakeLadderOption = new WinningPosition();
            snakeLadderOption.Game();
        }
    }
}