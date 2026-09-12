using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);

        Console.Write("What is your guess? ");
        int guess = int.Parse(Console.ReadLine());
        int guessCount = 1;

        while (guess != magicNumber)
        {
            if (guess < magicNumber)
            {
                Console.WriteLine("Higher");
            }
            else
            {
                Console.WriteLine("Lower");
            }

            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());
            guessCount++;
        }

        Console.WriteLine("You guessed it!");
        Console.WriteLine($"It took you {guessCount} guesses.");
    }
}


/*
Extra Challenges
1. Keep track of how many guesses the user has made and inform them of it at the end of the game.
2. After the game is over, ask the user if they want to play again. Then, loop back and play the whole game again and continue this loop as long as they keep saying "yes".
*/