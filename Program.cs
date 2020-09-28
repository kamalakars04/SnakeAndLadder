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
            Random random = new Random();
            int numberOnDie = random.Next(1,7);
            int optionNumber = random.Next(0, 3);
            switch(optionNumber)
            {
                case NO_PLAY:
                    break;
                case LADDER:
                    presentPosition += numberOnDie;
                    break;
                case SNAKE:
                    presentPosition -= numberOnDie;
                    break;

            }
            Console.WriteLine(presentPosition);

        }
    }
}
