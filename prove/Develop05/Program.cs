using System;

// first idea for stretch is to have the points be totaled up
// as per the parameters, but have a certain amount of points in
// order to level up.
class Program
{
    static void Main(string[] args)
    {
        GoalManager goalManager = new GoalManager();

        while (true)
        {
            DisplayMainMenu();
            string initialResponse = Console.ReadLine();
            int intResponse = Convert.ToInt32(initialResponse);

            if (intResponse == 1)
            {
                goalManager.CreateGoal();
            }
            else if (intResponse == 2)
            {
                goalManager.DisplayGoals();
            }
            else if (intResponse == 3)
            {
                goalManager.SaveGoal();
            }
            else if (intResponse == 4)
            {
                goalManager.LoadGoal();
            }
            else if (intResponse == 5)
            {
                goalManager.RecordEvent();
            }
            else if (intResponse == 6)
            {
                break;
            }
        }
    }
    public static void DisplayMainMenu()
    {
        Console.WriteLine("Menu Options: ");
        Console.WriteLine("1. Create New Goal");
        Console.WriteLine("2. List Goals");
        Console.WriteLine("3. Save Goals");
        Console.WriteLine("4. Load Goals");
        Console.WriteLine("5. Record Event");
        Console.WriteLine("6. Quit");
        Console.Write("Select a choice from the menu: ");
    }
}