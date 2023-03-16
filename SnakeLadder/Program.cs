namespace SnakeLadder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*****  Snake & Ladder Problems  *****");
            StartPosition startPosition = new StartPosition();
            startPosition.Game();
        }
    }
}