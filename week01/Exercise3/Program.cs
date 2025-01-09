using System;

class Program
{
    static void Main(string[] args)
    {

        // For Parts 1 and 2, where the user specified the number...
        // Console.Write("What is the number? ");
        // int number = int.Parse(Console.ReadLine());

         // For Part 3, where we use a random number
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 101);

        int guess = -1;

        while (guess != number)
        {
            Console.Write("Enter a guess: ");
            string letterGuess = Console.ReadLine();
            guess = int.Parse(letterGuess);


            if (number > guess)
            {
                Console.WriteLine("Higher");
            }
            else if (number < guess)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        }

    }
}