// I added a couple of things to the base program for extra credit
// Added a class to get the scriptures from a file and added a method 
// in the scripture class to create a word list
// also added a way for the user to tell the program how many words to hide
// while looking at the scripture.

using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Path to the text file containing scriptures
        string filePath = "scriptureMastery.txt";

        // Create a ScriptureLibrary instance and load scriptures
        ScriptureLibrary library = new ScriptureLibrary(filePath);

        // Get a random scripture
        Scripture scripture = library.GetRandomScripture();

        // this commented out section was the code to get the course working for just the basic program
        //string scriptureText = "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.";
        // list of words
        //List<Word> wordList = Scripture.CreateWordList(scriptureText);
        
        // Reference to the scripture
        //Reference reference = new Reference("Proverbs", 3, 5, 6);
        
        // Scripture instance
        //Scripture scripture = new Scripture(reference, wordList);
        
        //clear the console
        Console.Clear();
        // display the scripture
        Console.WriteLine(scripture.GetDisplayText());
        // ask user how many worda to hide
        Console.Write("How many words do you want to hide at a time? ");
        string count = Console.ReadLine();
        // convert string to int
        int countToHide = int.Parse(count);
        // while statement to detirmine if all words are hidden
        while (true)
        {  
            // tell user instructions and ge their choice
            Console.WriteLine("\nPress Enter to hide more words, or type 'quit' to exit.");
            string input = Console.ReadLine();  
            // test if all words are completly hidden or user typed quit        
            if (input == "quit" || scripture.IsCompletelyHidden())
            {
                break;
            }
            // clear console
            Console.Clear();
            // if not hidden then display the text hiding the number of words the user wanted to hide
            if (!scripture.IsCompletelyHidden())
            {
                scripture.HideRandomWords(countToHide);
            }
            else
            {
                break;
            }
            // display the text of the scripture with the hidden words
            Console.WriteLine(scripture.GetDisplayText());
        }

    }    
}