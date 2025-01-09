using System;

class Program
{
    static void Main(string[] args)
    {
        // Call the functions
        DisplayWelcome();
        string userName = PromptUserName();
        int favoriteNumber = PromptUserNumber();
        int squaredNumber = SquareNumber(favoriteNumber);
        DisplayResult(userName, squaredNumber);

        //Create a function to display welcome message
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program!");
        }
        //Create a function to get name and return it
        static string PromptUserName()
        {
            Console.Write("Enter your name: ");
            string userName = Console.ReadLine();
            return userName;
        }
        //Create a function to get users favorite number and return it
        static int PromptUserNumber()
        {
            Console.Write("Enter your favorite number: ");
            string number = Console.ReadLine();
            int userNumber = int.Parse(number);
            return userNumber;
        }
        //Create a function to get the square of a number and return it
        static int SquareNumber(int number)
        {
            int squaredNumber = number * number;
            return squaredNumber;
        }
        //Create a function that is passed in the name and squred number and displays them
        static void DisplayResult(string userName, int squaredNumber)
        {
            Console.WriteLine($"{userName}, the square of your number is {squaredNumber}");
        }

    }
}