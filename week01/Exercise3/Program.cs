using System;

class Program
{
    static void Main(string[] args)
    {
        string keepPlaying = "yes";

        // As long as they say "yes" we will keep playing
        while (keepPlaying.ToLower() == "yes")
        {
            Random random = new Random();
            int magicNumber = random.Next(1, 101);

            // This variable will keep track of how many guesses it took
            int guessCount = 0;

            int guess = -1;

            // Keep going as long as the guess doesn't match the magic number
            while (guess != magicNumber)
            {
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());
                guessCount++;

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

            // At this point, they have guessed it correctly
            Console.WriteLine($"It took you {guessCount} guesses");

            Console.Write("Would you like to play again (yes/no)? ");
            keepPlaying = Console.ReadLine();
        }

        Console.WriteLine("Thank you for playing. Goodbye.");
    }
}