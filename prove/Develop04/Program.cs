using System;
// EXCEEDING REQUIREMENTS:
// I made a simple adjustment displaying an activity whenever 
// the user quits the session.
class Program
{
    static void Main(string[] args)
    {
        int activityCount = 0;
        Breathing breathing = new Breathing();
        Listing listing = new Listing();
        Reflection reflection = new Reflection();

        while (true)
        {
            Program.DisplayMenu();
            string initialResponse = Console.ReadLine();
            int intResponse = Convert.ToInt32(initialResponse);

            if (intResponse == 1)
            {
                breathing.DisplayStartMessage();
                breathing.BreathingActivity();
                breathing.DisplayEndMessage();
            }
            else if (intResponse == 2)
            {
                reflection.DisplayStartMessage();
                reflection.ReflectionActivity();
                reflection.DisplayEndMessage();
            }
            else if (intResponse == 3)
            {
                listing.DisplayStartMessage();
                listing.ListingActivity();
                listing.DisplayEndMessage();
            }
            else if (intResponse == 4)
            {
                break;
            }
            activityCount++;
        }
        Console.WriteLine($"Thank you for participating! You completed {activityCount} activities total!!");
    }

    public static void DisplayMenu()
    {
        Console.WriteLine("Please select one of the following choices:");
        Console.WriteLine("1. Start breathing activity");
        Console.WriteLine("2. Start reflection activity");
        Console.WriteLine("3. Start listing activity");
        Console.WriteLine("4. Quit");
        Console.WriteLine("What would you like to do?");
    }
}