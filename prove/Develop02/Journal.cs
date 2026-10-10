public class Journal
{
    public List<string> _prompts = new List<string>{

        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "How did you make someone smile today?",
    };
    public List<Entry> _entries = new List<Entry>();

    public static string GenerateDate()
    {
        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();
        return dateText;
    }
    public string RandomPrompt()
    {        
        Random randomGenerator = new Random();
        int randomIndex = randomGenerator.Next(_prompts.Count);
        string userPrompt = _prompts[randomIndex];
        return userPrompt;
    }    
    public void AddEntry(string userPrompt, string dateText)
    {
        Entry myEntry = new Entry();
        Console.WriteLine($"{userPrompt}");
        string userResponse = Console.ReadLine();
        Console.WriteLine("Using one word, how are you feeling right now?");
        string userFeeling = Console.ReadLine();

        myEntry._prompt = userPrompt;
        myEntry._date = dateText;
        myEntry._response = userResponse;
        myEntry._feeling = userFeeling;

        _entries.Add(myEntry);
    }
    public void DisplayEntries()
    {   
        foreach (Entry entry in _entries)
        {
            Console.WriteLine($"Date: {entry._date} - Prompt: {entry._prompt}");
            Console.WriteLine($"{entry._response}");
            Console.WriteLine($"On this day, you felt '{entry._feeling}'.");
        }
    }   
    public void SaveToFile()
    {
        Console.WriteLine("What is the filename?");
        string fileName = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._date}~|~{entry._prompt}~|~{entry._response}~|~{entry._feeling}");
            }
        }
    }

    public void LoadFromFile()
    {
        Console.WriteLine("What is the filename?");
        string fileName = Console.ReadLine();
        
        string[] lines = System.IO.File.ReadAllLines(fileName);
        _entries.Clear();
        foreach (string line in lines)
        {
            Entry myEntry = new Entry();
            string[] parts = line.Split("~|~");
            myEntry._date = parts[0];
            myEntry._prompt = parts[1];
            myEntry._response = parts[2];
            myEntry._feeling = parts[3];
            _entries.Add(myEntry);
        }
    }
}