public class ReflectingActivity : Activity
{
    // declare variables
    private List<string> _prompts;
    private List<string> _questions;
    private int _promptIndex;
    private int _questionIndex;
    // cunstructor method to set up the reflecting activity
    public ReflectingActivity(string name, string description) : base(name, description)
    {
        _prompts = new List<string>
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };
        _questions = new List<string>
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };
        // added to make sure I get a new random prompt and question
        ShuffleList(_prompts);
        ShuffleList(_questions);
        _promptIndex = 0;
        _questionIndex = 0;
    }
    // method for shuffling the a list to help get a new random one
    private void ShuffleList(List<string> getList)
    {
        Random range = new Random();
        int n = getList.Count;
        while (n > 1)
        {
            n--;
            int k = range.Next(n + 1);
            string value = getList[k];
            getList[k] = getList[n];
            getList[n] = value;
        }
    }
    // method to get a new random item from a list
    private string GetNextItem(List<string> getList, ref int index)
    {
        if (index >= getList.Count)
        {
            ShuffleList(getList);
            index = 0;
        }
        return getList[index++];
    }
    // method to run the reflecting activity
    public void Run()
    {
        DisplayStartingMessage();
        SetDuration();
        GetReady();
        DisplayPrompt();

        Console.WriteLine("Now ponder on each of the following questions as they relate to this experience.");
        Console.Write("You may begin in: ");
        ShowCountDown(5);
        Console.Clear();

        int totalDuration = GetDuration();
        int elapsedTime = 0;

        while (elapsedTime < totalDuration)
        {
            DisplayQuestion();
            elapsedTime += 15;

            if(elapsedTime >= totalDuration)
            {
                break;
            }
        }

        DisplayEndingMessage();
    }
    // used to get random prompt, but was removed for methods to make sure there where no duplicates
    // public string GetRandomPrompt()
    // {
    //     Random randomPrompt = new Random();
    //     int index = randomPrompt.Next(_prompts.Count);
    //     return _prompts[index];
    // }
    // used to get random Question, but was removed for methods to make sure there where no duplicates
    // public string GetRandomQuestion()
    // {
    //     Random randomQuestion = new Random();
    //     int index = randomQuestion.Next(_questions.Count);
    //     return _questions[index];
    // }
    // method to display the prompt
    public void DisplayPrompt()
    {
        Console.WriteLine("Consider the following prompt:\n");
        Console.WriteLine($" --- {GetNextItem(_prompts, ref _promptIndex)} ---");
        Console.WriteLine("\nWhen you have something in mind, press enter to continue.");
        Console.ReadLine();
        Console.Clear();
    }
    // method to display the question.
    public void DisplayQuestion()
    {
        Console.Write($"\n> {GetNextItem(_questions, ref _questionIndex)} ");
        ShowSpinner(15);
    }
}