// Added achievements for completing a certain number of goals
// and achievements for making goals for gamification
// For extra I added an animation after each event
// and I added a big animation for when the user gets the bonus
// and animation for getting achievements

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        GoalManager goalManager = new GoalManager();
        goalManager.Start();
    }
}