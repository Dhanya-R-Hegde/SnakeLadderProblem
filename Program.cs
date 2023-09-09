using System.Diagnostics.Metrics;

namespace SnakeLadderProblem
{
    internal class SnakeLadder
    {
        
        public const int start = 0;
        public const int end = 100;
        public static int Resultp1 = start;
        public static int Resultp2 = start;
        public static int result = 0;
        public static int Countp1 = 1;
        public static int Countp2 = 1;

        
        public static int Dice()
        {
            Random random = new Random();
            int randomVal = random.Next(1, 7);
            return randomVal;
        }

        public static int SnakeOrLadder()
        {
            Random random = new Random();
            int SorL = random.Next(1, 3);
            return SorL;
        }

        
        public static int resultCheck(int snakeOrLadd, int diceVal)
        {
            if (snakeOrLadd == 1) //snake
            {
                if(result-diceVal < 0)
                {
                    result = start;
                }
                else
                {
                    result -= diceVal;
                }
            }
            else if (snakeOrLadd == 2) //ladder
            {
                
                if(result+diceVal!=100 && result + diceVal < 100)
                {
                    result += diceVal;
                }
                else if (result + diceVal == 100)
                {
                    return result;
                }
                else if(result + diceVal > 100)
                {
                    return result;
                }
            }

            return result;
        }

        public static void Game()
        {
            int player = 1;

            
            while(Resultp1!=100 && Resultp2 != 100)
            {
                if (player == 1) 
                {
                    int diceCheckp1 = Dice();
                    int sOrLp1 = SnakeOrLadder();

                    Countp1++;
                    Resultp1 = resultCheck(sOrLp1, diceCheckp1);

                    Console.WriteLine("Position after "+Countp1+"th roll is : " + Resultp1);

                    if (sOrLp1 == 2) player = 1;
                    else player = 2;
                }
                else
                {
                    int diceCheckp2 = Dice();
                    int sOrLp2 = SnakeOrLadder();

                    Countp2++;
                    Resultp2 = resultCheck(sOrLp2, diceCheckp2);

                    Console.WriteLine("Position after " + Countp2 + "th roll is : " + Resultp2);

                    if (sOrLp2 == 2) player = 2;
                    else player = 1;

                }

            }

            //UserCase6
            Console.WriteLine("Number of times the dice is rolled by player1 to reach 100 is : " + Countp1);
            Console.WriteLine("Number of times the dice is rolled by player2 to reach 100 is : " + Countp2);
            
        }

        static void Main(string[] args)
        {
            Game();
        }

    }
}
