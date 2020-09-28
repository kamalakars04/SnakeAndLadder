using System;

namespace SnakeAndLadder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome to snake and ladder");
            int NUMBER_OF_PLAYERS = 2;
            int START_POSITION = 0;
            int presentPlayer = 1;
            int numberOnDie = 0;
            int optionNumber = 0;
            const int NO_PLAY = 0;
            const int LADDER = 1;
            const int SNAKE = 2;
            int presentChanceNumber = 0;
            int[] playerPosition = new int[NUMBER_OF_PLAYERS];
            int[] playerNumber = new int[NUMBER_OF_PLAYERS];
            for (int assign = 0; assign < NUMBER_OF_PLAYERS; assign++)
            {
                playerNumber[assign] = assign + 1;
                playerPosition[assign] = START_POSITION;
            }

            Random random = new Random();

            while (playerPosition[presentPlayer-1] < 100)
            {
                if (playerNumber[presentPlayer-1] == 1)
                    presentChanceNumber++;

                numberOnDie = random.Next(1, 7);
                optionNumber = random.Next(0, 3);

                switch (optionNumber)
                {
                    case NO_PLAY:
                        break;
                    case LADDER:
                        if (playerPosition[presentPlayer-1] + numberOnDie <= 100)
                            playerPosition[presentPlayer-1] += numberOnDie;
                        break;
                    case SNAKE:
                        playerPosition[presentPlayer-1] -= numberOnDie;
                        if (playerPosition[presentPlayer-1] < START_POSITION)
                            playerPosition[presentPlayer-1] = 0;
                        break;

                }
                if (playerPosition[presentPlayer - 1] != 100)
                    presentPlayer++;
                if (presentPlayer > NUMBER_OF_PLAYERS)
                    presentPlayer = 1;

                Console.WriteLine("The position of player {0} after die roll number {1} is {2}",presentPlayer, presentChanceNumber, playerPosition[presentPlayer-1]);

            }
            Console.WriteLine("The Winner is player number {0} and total no of turns is {1}", presentPlayer, presentChanceNumber);

        }
    }
}
