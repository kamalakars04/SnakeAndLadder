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
            const int IS_PLAYER_ONE = 1;
            const int IS_PLAYER_TWO = 2;
            int positionOfPlayer1 = 0;
            int positionOfPlayer2 = 0;
            int playerNmuber = 1;
            int numberOnDie = 0;
            int optionNumber = 0;
            const int NO_PLAY = 0;
            const int LADDER = 1;
            const int SNAKE = 2;
            int presentChanceNumber = 0;

            Random random = new Random();
           
            while (positionOfPlayer1 < 100 && positionOfPlayer2 < 100)
            {
                presentChanceNumber++;
                switch (playerNmuber)
                {
                    case IS_PLAYER_ONE:
                    numberOnDie = random.Next(1, 7);
                    optionNumber = random.Next(0, 3);

                    switch (optionNumber)
                    {
                        case NO_PLAY:
                            break;
                        case LADDER:
                            if (positionOfPlayer1 + numberOnDie <= 100)
                                positionOfPlayer1 += numberOnDie;
                            break;
                        case SNAKE:
                            positionOfPlayer1 -= numberOnDie;
                            if (positionOfPlayer1 < START_POSITION)
                                positionOfPlayer1 = 0;
                            break;

                    }
                        if (positionOfPlayer1 != 100)
                            playerNmuber = 2;
                        Console.WriteLine("The position of player 1 after die roll number {0} is {1}", presentChanceNumber, positionOfPlayer1);
                        break;
                   
                    case IS_PLAYER_TWO:

                        numberOnDie = random.Next(1, 7);
                        optionNumber = random.Next(0, 3);

                        switch (optionNumber)
                        {
                            case NO_PLAY:
                                break;
                            case LADDER:
                                if (positionOfPlayer2 + numberOnDie <= 100)
                                    positionOfPlayer2 += numberOnDie;
                                break;
                            case SNAKE:
                                positionOfPlayer2 -= numberOnDie;
                                if (positionOfPlayer2 < START_POSITION)
                                    positionOfPlayer2 = 0;
                                break;

                        }
                        if (positionOfPlayer2 != 100)
                            playerNmuber = 1;
                        Console.WriteLine("The position of player 2 after die roll number {0} is {1}", presentChanceNumber, positionOfPlayer2);
                        break;
                }
               
            }
            Console.WriteLine("The Winner is player number {0} and total no of turns is {1}", playerNmuber, presentChanceNumber);

        }
    }
}
