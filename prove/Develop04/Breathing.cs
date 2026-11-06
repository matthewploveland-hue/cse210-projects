public class Breathing : Activity
{
    public Breathing() : base("Breathing Activity", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.")
    { 
    }
    
    public void BreathingActivity()
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            Console.Write("Breathe in...");
            ShowCountdown(4);
            Console.WriteLine();
            Console.Write("Now breathe out...");
            ShowCountdown(5);
            Console.WriteLine();
        }
    }

}