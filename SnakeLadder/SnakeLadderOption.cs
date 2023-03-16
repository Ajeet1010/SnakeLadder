using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeLadder
{
    // UC3- Checking for option to play either SNAKELADDER OR LUDO.
    internal class SnakeLadderOption
    {
        int INITIAL_POSITION = 0;
        public void Game()
        {
            Console.Write("\n1. Snake & Ladder.\n2. Ludo.\n3. Play after sometime.\nChoose a game to play:  ");
            int choice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You had chosen {0} so let's do it.", choice);

            Random random = new Random();
            int position = random.Next(1, 7);
            Console.WriteLine("Player initial position is:  " + INITIAL_POSITION);

            switch (choice)
            {
                case 1:
                    Console.WriteLine("\nPlayer position after rolling dice is:  "+ position);
                    break;
                case 2:
                    Console.WriteLine("\nPlayer position after rolling dice is:  " + position);
                    break;
                case 3:
                    Console.WriteLine("\nTaking you out");
                    break;
                default:
                    Console.WriteLine("\nOOPS! you had pressed wrong key.");
                    break;
            }
        }
    }
}
