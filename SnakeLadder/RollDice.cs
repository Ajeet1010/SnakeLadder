using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeLadder
{
    internal class RollDice
    {
        public void Game()
        {
            // UC1- Get player initial position in game.
            int INITIAL_POSITION = 0;
            Console.WriteLine("Start position of player is:  " + INITIAL_POSITION);

            // UC2- Player position after rolling dice.
            Random random = new Random();
            int position = random.Next(1, 7);
            Console.Write("\nAfter rolling dice player position is:  " + position);

        }
    }
}
