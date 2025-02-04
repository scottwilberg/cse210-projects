public class ListingActivity : Activity
{
    // set up the variables
    private int _count;
    private List<string> _prompts;
    private int _promptIndex;
    // set up the constructor method
    public ListingActivity(string name, string description) : base(name, description)
    {
        _prompts = new List<string>
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };
        ShuffleList(_prompts);
        _promptIndex = 0;
    }
    // set up a method to shuffle the list to help with getting a random string that hasn't been chosen yet
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
    // to get the next random item off the list.
    private string GetNextItem(List<string> getList, ref int index)
    {
        if (index >= getList.Count)
        {
            ShuffleList(getList);
            index = 0;
        }
        return getList[index++];
    }
    // method to set the count
    public void SetCount(int count)
    {
        _count = count;
    }
    // method to get the count
    public int GetCount()
    {
        return _count;
    }
    // method to run the listing activity
    public void Run()
    {
        DisplayStartingMessage();
        SetDuration();
        GetReady();
        // get the random prompt
        GetRandomPrompt();

        List<string> userList = GetListFromUser();
        SetCount(userList.Count);

        Console.WriteLine($"\nYou listed {GetCount()} items.");
        
        DisplayEndingMessage();
    }
    //Method to display a random prompt
    public void GetRandomPrompt()
    {
        // these 2 lines are not needed since I added the getNextItem method
        // Random randomPrompt = new Random();
        // int index = randomPrompt.Next(_prompts.Count);
        Console.WriteLine("List as many responses you can to the following prompt:\n");
        Console.WriteLine($" --- {GetNextItem(_prompts, ref _promptIndex)} ---");
        Console.Write("You may begin in: ");
        ShowCountDown(5);
        Console.WriteLine("\n");
    }
    // method to get a list from the user input
    public List<string> GetListFromUser()
    {
        List<string> userList = new List<string>();
        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());
        // while loop for the user to input things until time expires
        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string input = Console.ReadLine();
            userList.Add(input);
        }
        return userList;
    }
}