using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfCraps
{
    class Program
    {
        private static Random RandomNumbers = new Random();

        private enum Status { CONTINUE, WIN, LOST }
        
        private enum DiceNames
        {
            SNAKE_EYES = 2,
            TRAY = 3,
            SEVEN= 7,
            YO_LEVEL = 11,
            BOX_CARS = 12
        }
        
        public static void Main(string[] args)
        {
            Status gameStatus = Status.CONTINUE;
            int myPoint = 0;

            int sumofRolls = DiceRolls();

            switch ((DiceNames) sumofRolls)
            {
                case DiceNames.SNAKE_EYES:
                case DiceNames.TRAY:
                case DiceNames.BOX_CARS:
                    gameStatus = Status.LOST;
                    break;
                case DiceNames.SEVEN:
                case DiceNames.YO_LEVEL:
                    gameStatus = Status.WIN;
                    break;
                default:
                    gameStatus = Status.CONTINUE;
                    myPoint = sumofRolls;
                    Console.WriteLine("My Point is: {0}", myPoint);
                    break;
            }
            while (gameStatus == Status.CONTINUE)
            {
                sumofRolls = DiceRolls();

                if (sumofRolls == myPoint)
                {
                    gameStatus = Status.WIN;
                }
                else
                {
                    if (sumofRolls == (int) DiceNames.SEVEN)
                    {
                        gameStatus = Status.LOST;
                    }
                }
            }

            if (gameStatus == Status.WIN)
            {
                Console.WriteLine("Player Wins!");
            }
            else 
            {
                Console.WriteLine("Player Loses");
            }

        } 

        public static int DiceRolls()
        {
            int die1 = RandomNumbers.Next(1, 7);
            int die2 = RandomNumbers.Next(1, 7);

            int sum = die1 + die2;

            Console.WriteLine("sum of {0}+{1}={2}",
                die1, die2,sum);
            return sum;
        }
    }
}
