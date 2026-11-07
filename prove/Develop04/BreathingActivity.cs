public class BreathingActivity : Activity
{
    // behavior
    public BreathingActivity() : base("Breathing Activity", 
        "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
        // constructor of BreathingActivity so it can give this information to Activity
    }
    public void BreatheIn(int breatheInCount)
    {
        // The breathe in function of the breathing activity
        // breatheInCount is set as a function variable so when it is called in Main, 
        // it can count down to different numbers depending on what a programer wants for the breathing activity
        Console.Write("Breathe in... ");
        for (int i = breatheInCount; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
    public void BreatheOut(int breatheOutCount)
    {
        // The breathe out function of the breathing activity
        Console.Write("\nNow breathe out... ");
        for (int i = breatheOutCount; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        Console.Write("\n");
    }
}