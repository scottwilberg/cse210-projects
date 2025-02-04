public class BreathingActivity : Activity
{
    // set up cunstroctor method for breathing activity
    public BreathingActivity(string name, string description) : base(name, description)
    {

    }
    // set up run method for breathing activity
    public void Run()
    {
        DisplayStartingMessage();
        SetDuration();
        GetReady();
        // get the duration from the user
        int totalDuration = GetDuration();
        int elapsedTime = 0;
        // while loop for the duration
        while (elapsedTime < totalDuration)
        {
            Console.Write("Breathe in... ");
            ShowCountDown(4);
            elapsedTime += 4;
            
            Console.Write("\nNow breath out... ");
            ShowCountDown(5);
            Console.WriteLine("\n");
            elapsedTime += 5;
            // to know when to end the program after time has expired
            if (elapsedTime >= totalDuration)
            {
                break;
            }
        }
        DisplayEndingMessage();
    }
}