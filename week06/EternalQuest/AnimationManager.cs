public class AnimationManager
{
    // simple animation for when a event is recorded
    public void ShowRecordingAnimation()
    {
        Console.Write("Recording event");
        for (int i = 0; i < 3; i++)
        {
            Console.Write(".");
            System.Threading.Thread.Sleep(500); // Delay for 500 milliseconds
        }
        Console.WriteLine("\nEvent recorded successfully!\n");
    }
    
    public void ShowAchievementAnimation(string achievement)
    {
        Console.Clear();
        string message = $"ACHIEVEMENT UNLOCKED: {achievement}";
        int width = Console.WindowWidth;
        int padding = (width - message.Length) / 2;

        for (int i = 0; i < 3; i++)
        {
            Console.Clear();
            Console.SetCursorPosition(padding, Console.WindowHeight / 2);
            Console.WriteLine(message);
            System.Threading.Thread.Sleep(500);
            Console.Clear();
            System.Threading.Thread.Sleep(500);
        }

        Console.SetCursorPosition(padding, Console.WindowHeight / 2);
        Console.WriteLine(message);
        System.Threading.Thread.Sleep(2000);
        Console.Clear();
    }
    // big animation for when a bonus is achieved
    public void ShowBonusAnimation()
    {
        Console.Clear();
        string message = "BONUS ACHIEVED!";
        int width = Console.WindowWidth;
        int padding = (width - message.Length) / 2;

        for (int i = 0; i < 3; i++)
        {
            Console.Clear();
            Console.SetCursorPosition(padding, Console.WindowHeight / 2);
            Console.WriteLine(message);
            System.Threading.Thread.Sleep(500); // Delay for 500 milliseconds
            Console.Clear();
            System.Threading.Thread.Sleep(500); // Delay for 500 milliseconds
        }

        Console.SetCursorPosition(padding, Console.WindowHeight / 2);
        Console.WriteLine(message);
        System.Threading.Thread.Sleep(2000); // Display the message for 2 seconds
        Console.Clear();
    }
}