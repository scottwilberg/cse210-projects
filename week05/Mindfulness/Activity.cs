public class Activity
{
    // declare private variables
    private string _name;
    private string _description;
    private int _duration;
    // constructor method to set the variables
    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
        _duration = 0;
    }
    // set method to set the duration with a prompt to the user to get it from the user.
    public void SetDuration()
    {
        Console.Write("How long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());
    }

    // public void SetName(string name)
    // {
    //     _name = name;
    // }
    //  public void SetDescription(string description)
    // {
    //     _description = description;
    // }
    // method to get the name
    public string GetName()
    {
        return _name;
    }
    // method to get the description
    public string GetDescription()
    {
        return _description;
    }
    // method to get the duration
    public int GetDuration()
    {
        return _duration;
    }
    // method to display the starting message for each activity
    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {GetName()}.\n\n{GetDescription()}\n");
    }
    // method to display the ending method for each activity
    public void DisplayEndingMessage()
    {
        Console.WriteLine("\n\nWell done!!");
        ShowSpinner(3);
        Console.WriteLine($"\nYou have completed another {GetDuration()} seconds of the {GetName()}.");
        ShowSpinner(5);
    }
    // method for the get ready page for each activity
    public void GetReady()
    {
        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowSpinner(5);
        Console.WriteLine("\n");
    }
    // method to set up spinner animation
    public void ShowSpinner(int seconds)
    {
        List<string> animationStrings = new List<string>();
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");

        DateTime startTime = DateTime.Now;
        DateTime endTime =  startTime.AddSeconds(seconds);

        int i = 0;

        while (DateTime.Now < endTime)
        {
            string s = animationStrings[i];
            Console.Write(s);
            Thread.Sleep(1000);
            Console.Write("\b \b");

            i++;

            if (i >= animationStrings.Count)
            {
                i = 0;
            }
        }
    }
    // set up count down animation
    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");    
        }
    }
}