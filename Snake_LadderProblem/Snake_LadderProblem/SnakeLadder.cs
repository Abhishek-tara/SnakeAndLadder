﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_LadderProblem
{
    public class SnakeLadder
    {
        public void GameMethod()
        {
            int position = 0;
            Random random = new Random();
            //Console.WriteLine("Welcome Player 1, Let's start the Game");
            //Console.WriteLine("Player 1 is at position : " + position);

            //UC-2
            //int dice = random.Next(1, 7);
            //Console.WriteLine($"The Player rolls a dice and gets: {dice}");

            //UC-3
            //int option = random.Next(0, 3);
            //if (option == 0)
            //{
            //    Console.WriteLine("Player stays at same Position");
            //}
            //else if (option == 1)
            //{
            //    Console.WriteLine("Player Moves Ahead by {0} from ladder", dice);
            //    position += dice;
            //}
            //else
            //{
            //    Console.WriteLine("Player Moves Behind by {0} from Snake", dice);
            //    position -= dice;
            //}
            //Console.WriteLine("Current Position is at : {0}", position);

            //UC-4
            while (position != 100)
            {
                int dice = random.Next(1, 7);
                Console.WriteLine($"The Player rolls a dice and gets: {dice}");

                int option = random.Next(0, 3);
                if (option == 0)
                {
                    Console.WriteLine("Player stays at same Position");
                }
                else if (option == 1)
                {
                    Console.WriteLine("Player Moves Ahead by {0} from ladder", dice);
                    position += dice;
                }
                else
                {
                    Console.WriteLine("Player Moves Behind by {0} from Snake", dice);
                    position -= dice;
                }
                if (position < 0)
                {
                    position = 0;
                }
                Console.WriteLine("Player Current Position is at : {0}", position);
            }
            Console.WriteLine("Player is at Position : {0}", position);
        }
    }
}
