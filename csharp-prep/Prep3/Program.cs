using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Prep3 World!");



        // Guess My Number Game



        string answer = "yes";

        while (answer == "yes")

        {
            // Generate a random number from 1 to 100
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 100);

            // 
            int attempts = 1;

            Console.WriteLine("What is your guess number? ");
            int guessNumber = int.Parse(Console.ReadLine());


            while (guessNumber != magicNumber)
            {
                if (guessNumber < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                else if (guessNumber > magicNumber)
                {
                    Console.WriteLine("Lower");
                }

                Console.WriteLine("What is your guess number? ");
                guessNumber = int.Parse(Console.ReadLine());

                attempts = attempts + 1;
            }

            Console.WriteLine("You guessed it!");

            Console.WriteLine($"Until you guessed the magic number you had {attempts} attempts");

            Console.WriteLine("Type 'yes' to play Again: ");
            answer = Console.ReadLine();

        }
        Console.WriteLine("The game is end, thanks to play it!");
    }
}