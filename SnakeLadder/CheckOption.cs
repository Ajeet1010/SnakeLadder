using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeLadder
{
    // UC3- Checking for option to play SNAKE or LADDER or NO PLAY.
    internal class SnakeLadderOption
    {
        int INITIAL_POSITION = 0;
        public void Game()
        {
            int player_position = 0;
            Console.Write("\n1. Snake\t2. Ladder\t3. No Play.\nChoose a game to play:  ");
            int choice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You had chosen {0} so let's do it.", choice);

            Random random = new Random();
            int position = random.Next(1, 7);
            Console.WriteLine("Player initial position is:  " + INITIAL_POSITION);

            switch (choice)
            {
                case 1:
                    player_position = player_position - position;
                    if (player_position > 0)
                        Console.WriteLine("\nPlayer position after rolling dice is:  " + player_position);
                    else
                        Console.WriteLine("Game restart");
                    break;
                case 2:
                    player_position = player_position + position;
                    Console.WriteLine("\nPlayer position after rolling dice is:  " + player_position);
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
