using System;

class Program
{
    static void Main(string[] args)
    {
        //pre sentence to describe what is happening
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        List<int> numbers = new List<int>();

        int number = -1;

        //while loop to get the user numbers
        while (number != 0)
        {
            Console.Write("Enter number: ");
            string stringNumber = Console.ReadLine();
            number = int.Parse(stringNumber);

            // if statment to test to see if the program should end or add to the list
            if (number != 0)
            {
                numbers.Add(number);
            }
        }

        int sum = 0;
        // foreach statement to get the sum of all the numbers in the list
        foreach (int item in numbers)
        {
            sum += item;
        }
        Console.WriteLine($"The sum is: {sum}");

        // set up a float value for getting decimal points
        // and calculating the average of the numbers in the list
        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        int max = numbers[0];

        // foreach statement to find the max number in the list
        foreach (int item in numbers)
        {
            if (item > max)
            {
                // if this number is greater than the max, we have found the new max!
                max = item;
            }
        }
        Console.WriteLine($"The max is: {max}");

        int min = numbers[0];
        // for each to find the minimum number in the list
        foreach (int item in numbers)
        {
            if (item < min && item > 0)
            {
                // if this number is greater than the max, we have found the new max!
                min = item;
            }
        }
        Console.WriteLine($"The smallest positive number is: {min}");

        // sort the numbers in the list from smallest to largest
        numbers.Sort();
        Console.WriteLine(string.Join(", ", numbers));
    }
}