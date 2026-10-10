using System;

// My attempt to exceed requirements is to add one additional entry
// field, feeling. Now, after writing a response, the user will be 
// asked in one word how they're feeling at the moment. If saved, 
// this can help the user track their feelings over time. It saves
// loads properly like the other three fields.

class Program
{
    static void Main(string[] args)
    {
        Journal myJournal = new Journal();
        
        while (true)
        {
            Program.DisplayMenu();
            string initialResponse = Console.ReadLine();
            int intResponse = Convert.ToInt32(initialResponse);

            if (intResponse == 1)
            {
                myJournal.AddEntry(myJournal.RandomPrompt(), Journal.GenerateDate());
            }
            else if (intResponse == 2)
            {
                myJournal.DisplayEntries();
            }
            else if (intResponse == 3)
            {
                myJournal.LoadFromFile();
            }
            else if (intResponse == 4)
            {
                myJournal.SaveToFile();
            }
            else if (intResponse == 5)
            {
                break;
            }
        }
    }
    public static void DisplayMenu()
    {
        Console.WriteLine("Please select one of the following choices:");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");
        Console.WriteLine("What would you like to do?");
    }

}