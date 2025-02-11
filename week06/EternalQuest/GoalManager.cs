using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.XPath;
public class GoalManager
{
    private List<Goal> _goals;
    private int _score;
    // declared variables for gamification
    private const int _xpPerLevel = 500;
    private List<string> _achievements;
    private int _goalsCompleted;
    private AnimationManager _animationManager;
    // constructor method for the goal manager to initialize the goals and score
    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
        _achievements = new List<string>();
        _goalsCompleted = 0;
        _animationManager = new AnimationManager();
    }
    // method to run the program
    public void Start()
    {
        string choice = "";

        //while loop to exit when user inputs "6" to quit
        while (choice != "6")
        {
            // display the score
            DisplayPlayerInfo();
            // setting up the menu choices so the user can see what the choices are
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Save Goals");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Record Event");
            Console.WriteLine("  6. Quit");
            Console.Write("Select a choice from the menu: ");
            // getting the user choice
            choice = Console.ReadLine();

            // choice 1 create new goal
            if(choice == "1")
            { 
                CreateGoal();
            }
            // choice 2 list goals
            else if (choice == "2")
            {
                Console.WriteLine("The goals are:");
                ListGoalDetails();
            }
            // choice 3 save goals
            else if (choice == "3")
            {
                SaveGoal();
            }
            // choice 4 load goals
            else if (choice == "4")
            {
                LoadGoal();
            }
            // choice 5 record event
            else if (choice == "5")
            {
                RecordEvent();
            }
            // choice 6 is to end the program
            else
            {
                break;
            }   
                
        }
    }
    // method to display the current score and level and xp
    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"You have {_score} points.\n");
        Console.WriteLine($"Achievements: ");
        foreach (var achievement in _achievements)
        {
            Console.WriteLine($"- {achievement}");
        }
        Console.WriteLine();
    }
    
    // method to list the names of each of the goals
    public void ListGoalNames()
    {
        for (int i = 0; i < _goals.Count; i++)
        {            
            Console.WriteLine($"{i + 1}. {_goals[i].GetShortName()}");
        }
    }
    // method to lists the details of each goal (including the checkbox of whether it is complete)
    public void ListGoalDetails()
    {
        for (int i = 0; i < _goals.Count; i++)
        {
            string status = _goals[i].IsComplete() ? "[X]" : "[ ]";
            string details = _goals[i].GetDetailsString();
            Console.WriteLine($"{i + 1}. {status} {details}");
        }
    }
    // Asks the user for the information about a new goal. Then, creates the goal and adds it to the list.
    public void CreateGoal()
    {
        Console.WriteLine("The types of Goals are:");
        Console.WriteLine("  1. Simple Goal");
        Console.WriteLine("  2. Eternal Goal");
        Console.WriteLine("  3. Checklist Goal");
        Console.Write("What type of Goal would you like to create? ");
        string type = Console.ReadLine();

        Console.Write("What is the name of your goal? ");
        string goalName = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        string goalDescription = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        int points = int.Parse(Console.ReadLine());

        if (type == "1")
        {
            _goals.Add(new SimpleGoal(goalName, goalDescription, points));
            CheckForSpecialAchievements("Simple");
        }
        else if (type == "2")
        {
            _goals.Add(new EternalGoal(goalName, goalDescription, points));
            CheckForSpecialAchievements("Eternal");
        }
        else if (type == "3")
        {
            Console.Write("How many times does this goal to be accomplished for a bonus? ");
            int times = int.Parse(Console.ReadLine());
            Console.Write("What is the bonus for accomplishing it that many times? ");
            int bonusPoints = int.Parse(Console.ReadLine());
            _goals.Add(new ChecklistGoal(goalName, goalDescription, points, times, bonusPoints));
            CheckForSpecialAchievements("Checklist");
        }
    }
    // Asks the user which goal they have done and then records the event by calling the RecordEvent method on that goal
    public void RecordEvent()
    {
        Console.WriteLine("The goals are:");
        ListGoalNames();
        Console.Write("Which goal did you accomplish? ");
        int goalIndex = int.Parse(Console.ReadLine()) - 1;

        if (goalIndex >= 0 && goalIndex < _goals.Count)
        {
            _goals[goalIndex].RecordEvent();
            _score += _goals[goalIndex].GetPoints();

            if (_goals[goalIndex] is ChecklistGoal checklistGoal)
            {
                if (checklistGoal.IsComplete())
                {
                    _score += checklistGoal.GetBonus();
                    // Call the bonus animation method
                    _animationManager.ShowBonusAnimation();
                }
            }
            // Call the animation method
            _animationManager.ShowRecordingAnimation();
            CheckForGoalCompletionAchievements();
        }
        else
        {
            Console.WriteLine("Invalid goal selection.");
        }
    }
    // Saves the list of goals to a file.
    public void SaveGoal()
    {
        Console.Write("What is the filename for the goal? ");
        string filename = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine(_score);
            outputFile.WriteLine(_goalsCompleted);
            foreach (var achievement in _achievements)
            {
                outputFile.WriteLine($"Achievement:{achievement}");
            }
            foreach (var goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }
    }
    // Loads the list of goals from a file.
    public void LoadGoal()
    {
        Console.Write("What is the name of the goal file? ");
        string filename = Console.ReadLine();
        string[] lines = File.ReadAllLines(filename);

        _score = int.Parse(lines[0]);
        _goalsCompleted = int.Parse(lines[1]);
        _goals.Clear();
        _achievements.Clear();

        for (int i = 2; i < lines.Length; i++)
        {
            if (lines[i].StartsWith("Achievement:"))
            {
                _achievements.Add(lines[i].Substring(12));
            }
            else
            {
                string[] typeAndData = lines[i].Split(':');
                string type = typeAndData[0];
                string[] parts = typeAndData[1].Split(",");

                string name = parts[0];
                string description = parts[1];
                int points = int.Parse(parts[2]);

                if (type == "Simple Goal")
                {
                    string complete = parts[3];
                    SimpleGoal simpleGoal = new SimpleGoal(name, description, points);
                    if (complete == "true")
                    {
                        simpleGoal.RecordEvent();
                    }
                    _goals.Add(simpleGoal);
                }
                else if (type == "Eternal Goal")
                {
                    _goals.Add(new EternalGoal(name, description, points));
                }
                else if (type == "Checklist Goal")
                {
                    string complete = parts[3];
                    int bonus = int.Parse(parts[4]);
                    int target = int.Parse(parts[5]);
                    ChecklistGoal checklistGoal = new ChecklistGoal(name, description, points, target, bonus);
                    if (complete == "true")
                    {
                        checklistGoal.RecordEvent();
                    }
                    _goals.Add(checklistGoal);
                }
            }
        }
    }
    
    private void CheckForGoalCompletionAchievements()
    {
        if (_goalsCompleted == 1) UnlockAchievement("First Step");
        if (_goalsCompleted == 5) UnlockAchievement("Goal Getter");
        if (_goalsCompleted == 10) UnlockAchievement("Goal Crusher");
        if (_goalsCompleted == 20) UnlockAchievement("Goal Master");
        if (_goalsCompleted == 50) UnlockAchievement("Goal Legend");
        if (_goalsCompleted == 100) UnlockAchievement("Goal Conqueror");
    }
    private void CheckForSpecialAchievements(string goalType)
    {
        if (goalType == "Simple") UnlockAchievement("Simple Success");
        if (goalType == "Eternal") UnlockAchievement("Eternal Visionary");
        if (goalType == "Checklist") UnlockAchievement("Checklist Champion");
    }
    private void UnlockAchievement(string achievement)
    {
        if (!_achievements.Contains(achievement))
        {
            _achievements.Add(achievement);
            Console.WriteLine($"Achievement unlocked: {achievement}");
            _animationManager.ShowAchievementAnimation(achievement);
        }
    }
}