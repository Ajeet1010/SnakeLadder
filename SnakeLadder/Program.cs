namespace SnakeLadder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*****  Snake & Ladder Problems  *****\n");
            WinningPosition countroll = new WinningPosition();
            countroll.Game();
        }
    }
}