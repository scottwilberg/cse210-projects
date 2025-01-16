using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
class Program
{
    static void Main(string[] args)
    {
        // create a list to store entries
        Journal theJournal = new Journal();
    
        Console.WriteLine("Welcome to the Journal Program!");

        string choice = "";

        //while loop to exit when user inputs "5" to quit
        while (choice != "5")
        {
            // seting up the menu choices so the user can see what the choices are
            Console.WriteLine("Please select 1 of the following choices.");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            // getting the user choice
            choice = Console.ReadLine();

            // choice 1 is for getting a new journal entry
            if(choice == "1")
            { 
                // set up a new entry
                Entry anEntry = new Entry();
                //set up a random prompt
                PromptGenerator prompt = new PromptGenerator();
                //get todays date and convert it to a sting
                DateTime date = DateTime.Now;
                anEntry._date = date.ToString("MM/dd/yyyy");
                // get the question and display it for the user with a prompt
                anEntry._promptText = prompt.GetRandomPrompt();
                Console.WriteLine(anEntry._promptText);
                Console.Write("> ");
                // get the user answer to the question
                anEntry._entryText = Console.ReadLine();
                anEntry.Display();
                // add the entry to the journal
                theJournal.AddEntry(anEntry);                          
            }
            // choice 2 is to display the entries made so far
            else if (choice == "2")
            {
                theJournal.DisplayAll();
            }
            // choice 3 is to load the entries from a saved file
            else if (choice == "3")
            {
                // get the file name from a user input
                Console.Write("Type the filename to load: ");
                string filename = Console.ReadLine();

                theJournal.LoadFromFile(filename);
            }
            // choice 4 is to save the entries to a file
            else if (choice == "4")
            {
                // get the file name from a user input
                Console.Write("Type the filename to save: ");
                string filename = Console.ReadLine();

                theJournal.SaveToFile(filename);
            }
            // choice 5 is to end the program
            else
            {
                break;
            } 
                       
        }
    }
    
}

