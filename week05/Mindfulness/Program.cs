// for extra I added functionality so the activity wouldn't duplicate
// any of the list items unitl it had gone through the entire list

using System;

class Program
{
    static void Main(string[] args)
    {
        string choice = "";

        //while loop to exit when user inputs "4" to quit
        while (choice != "4")
        {
            // setting up the menu choices so the user can see what the choices are
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflecting activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. Quit");
            Console.Write("Select a choice from the menu: ");
            // getting the user choice
            choice = Console.ReadLine();
            Console.Clear();

            // choice 1 breathing activity
            if(choice == "1")
            { 
                BreathingActivity ba1 = new BreathingActivity("Breathing Activity", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing."); 
                ba1.Run();
            }
            // choice 2 reflecting activity
            else if (choice == "2")
            {
                ReflectingActivity ra1 = new ReflectingActivity("Reflecting Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life."); 
                ra1.Run();
            }
            // choice 3 listing activity
            else if (choice == "3")
            {
                ListingActivity la1 = new ListingActivity("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area."); 
                la1.Run();
            }
            // choice 4 is to end the program
            else
            {
                break;
            }         
        }
    }
}