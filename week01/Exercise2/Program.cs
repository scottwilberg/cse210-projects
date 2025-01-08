using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the score: ");
        string score = Console.ReadLine();
        int grade = int.Parse(score);

        string letterGrade = "";

        if (grade >= 90)
        {
            letterGrade = "A";
        }
        else if (grade >= 80)
        {
            letterGrade = "B";
        }
        else if (grade >= 70)
        {
            letterGrade = "C";
        }
        else if (grade >= 60)
        {
            letterGrade = "D";
        }
        else 
        {
            letterGrade = "F";
        }

        Console.WriteLine($"Your Grade is a {letterGrade}");
        if (grade >= 70)
        {
            Console.WriteLine("Congratulations you Passed!");
        }
        else
        {
            Console.WriteLine("You did not pass. ");
        }

    }
}