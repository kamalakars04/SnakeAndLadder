using System;

namespace SnakeAndLadder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome to snake and ladder");
            int NUMBER_OF_PLAYERS = 1;
            int START_POSITION = 0;
            int presentPosition = 0;
            const int NO_PLAY = 0;
            const int LADDER = 1;
            const int SNAKE = 2;
            int totalNumberOfChances = 0;
            int presentChanceNumber = 0;
            Random random = new Random();
            while (presentPosition < 100)
            {
                presentChanceNumber++;
                int numberOnDie = random.Next(1, 7);
                int optionNumber = random.Next(0, 3);
                switch (optionNumber)
                {
                    case NO_PLAY:
                        break;
                    case LADDER:
                        if(presentPosition + numberOnDie <=100)
                        presentPosition += numberOnDie;
                        break;
                    case SNAKE:
                        presentPosition -= numberOnDie;
                        if (presentPosition < 0)
                            presentPosition = 0;
                        break;

                }
                Console.WriteLine("The position after die roll number {0} is {1}", presentChanceNumber, presentPosition);
                totalNumberOfChances += 1;
            }
            Console.WriteLine("Total number of chances taken to reach 100 is {0}", totalNumberOfChances);

        }
    }
}
