using System;

class Program
{
    static void Main(string[] args)
    {
        string playAgain;

        do
        {
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1,101);
            int guess = -1;

            while(guess != magicNumber)
            {
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());
                
                if (guess < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                else if (guess > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                }
            }
            Console.Write("Do you want to play again? (yes/no): ");
            playAgain = Console.ReadLine();
        } while (playAgain == "yes");
    }
}