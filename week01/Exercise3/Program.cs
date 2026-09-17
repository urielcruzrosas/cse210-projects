string playAgain;

do
{
    Random userNumber = new Random();
    int magicNumber = userNumber.Next(1, 101);

    int guess;
    int attempts = 0;

    do
    {
        Console.Write("What is your guess? ");
        string userGuess = Console.ReadLine();
        guess = int.Parse(userGuess);

        ++attempts;

        if (guess == magicNumber)
        {
            Console.WriteLine("You guess it!");
        }

        else if (guess < magicNumber)
        {
            Console.WriteLine("Higher");
        }
        else
        {
            Console.WriteLine("Lower");
        }
    } while (guess != magicNumber);

    Console.WriteLine($"It took you {attempts} attempts");

    Console.Write("Do you want to play again yes/no: ");
    playAgain = Console.ReadLine();
} while (playAgain == "yes");


Console.WriteLine("Thanks for playing!");



