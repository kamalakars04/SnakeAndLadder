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
            Random random = new Random();
            int numberOnDie = random.Next(1,7);

        }
    }
}
