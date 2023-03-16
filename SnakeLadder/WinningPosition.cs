using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeLadder
{
    // UC5- Repeat until player reaches WINNINGPOSITION 100.
    internal class WinningPosition
    {
        int INITIAL_POSITION = 0, WINNING_POSITION =100;
        public void Game()
        {
            int player_position = 0;
            Console.WriteLine("Player starting position is:  " + INITIAL_POSITION);
            while (player_position < WINNING_POSITION)
            {
                Random random = new Random();
                Console.Write("\n1. Snake\t 2. Ladder\t3. Chanced missed\nEnter choice:  ");
                int choice = Convert.ToInt32(Console.ReadLine());
                
                Console.Write("Chosed option is:  " + choice);

                
                int roll = random.Next(1, 7);
                player_position = INITIAL_POSITION + player_position;
                Console.WriteLine("\nPlayer current position is:  " + player_position);

                if (player_position >= 0)
                {
                    switch (choice)
                    {
                        case 1:
                            player_position = player_position - roll;
                            Console.WriteLine("\nRoll outcome is {0} and your position is {1}", roll, player_position);
                            if (player_position >= 0)
                                break;
                            else
                            {
                                Console.WriteLine("Your game is restarted as your position is deceased");
                                player_position = INITIAL_POSITION;
                            }

                            break;
                        case 2:
                            player_position = player_position + roll;
                            Console.WriteLine("\nRoll outcome is {0} and your position is {1}", roll, player_position);
                            break;
                        case 3:
                            Console.WriteLine("\nAs you missed chance hence your position remain unchanged " + player_position);
                            break;
                        default:
                            Console.WriteLine("\nOOPS! you had pressed wrong key.");
                            break;
                    }
                }
                    
            }
        }
    }
}
