using System;

namespace SnakeAndLadder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome to snake and ladder");
            //Constants
            const int NO_PLAY = 0;
            const int LADDER = 1;
            const int SNAKE = 2;
            const int NUMBER_OF_PLAYERS = 2;
            const int START_POSITION = 0;
            //Variables
            int numberOnDie = 0;
            int optionNumber = 0;
            int presentPlayer = 1;
            int[] presentChanceNumber = new int[NUMBER_OF_PLAYERS];
            int[] playerPosition = new int[NUMBER_OF_PLAYERS];
            int[] playerNumber = new int[NUMBER_OF_PLAYERS];
            //Assigning the initial Positions of players
            for (int assign = 0; assign < NUMBER_OF_PLAYERS; assign++)
            {
                playerNumber[assign] = assign + 1;
                playerPosition[assign] = START_POSITION;
                presentChanceNumber[assign] = 0;
            }

            Random random = new Random();
            //Starting a game and continue it till one reaches final position
            while (playerPosition[presentPlayer-1] < 100)
            {
                //Rolling a die
                numberOnDie = random.Next(1, 7);
                //Choosing for ladder or snake or no move
                optionNumber = random.Next(0, 3);
                //Switching with respect to option
                switch (optionNumber)
                {
                    //If optin is no move
                    case NO_PLAY:
                        presentChanceNumber[presentPlayer - 1]++;
                        break;
                    //If option is ladder then he gets extra chance and his position increments
                    case LADDER:
                        presentChanceNumber[presentPlayer - 1]++;
                        if (playerPosition[presentPlayer-1] + numberOnDie <= 100)
                            playerPosition[presentPlayer-1] += numberOnDie;
                        break;
                    //if option is snke his position decrements but does not go less than 0
                    case SNAKE:
                        presentChanceNumber[presentPlayer - 1]++;
                        playerPosition[presentPlayer-1] -= numberOnDie;
                        if (playerPosition[presentPlayer-1] < START_POSITION)
                            playerPosition[presentPlayer-1] = START_POSITION;
                        break;
                }
                // if no player reaches 100 and present player doesnt get ladder option
                if (playerPosition[presentPlayer - 1] != 100 && optionNumber != LADDER)
                    presentPlayer++;
                //If turn of all the players is done then it goes to first player
                if (presentPlayer > NUMBER_OF_PLAYERS)
                    presentPlayer = 1;

                Console.WriteLine("The position of player {0} after die roll number {1} is {2}",presentPlayer, presentChanceNumber[presentPlayer-1], playerPosition[presentPlayer-1]);

            }
            Console.WriteLine("The Winner is player number {0} and total no of turns is {1}", presentPlayer, presentChanceNumber[presentPlayer-1]);

        }
    }
}
