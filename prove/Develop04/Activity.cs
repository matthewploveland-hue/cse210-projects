public class Activity
{
    protected int _duration = 0;
    protected string _name = "";
    protected string _description = "";
    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }
    public void DisplayStartMessage()
    {
        Console.WriteLine($"Welcome to the {_name}");
        Console.WriteLine($"{_description}");
        Console.WriteLine("How long, in seconds, would you like your session to last?");
        _duration = int.Parse(Console.ReadLine());
        Console.WriteLine("Get ready...");
        ShowSpinner(4);
    }
    public void ShowCountdown(double seconds)
    {
        for (double i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        
    }
    public void ShowSpinner(int seconds)
    {
    
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);
        List<string> animationStrings = new List<string>();
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");
        int i = 0; 
        while (DateTime.Now < endTime)
        {
            string s = animationStrings[i];
            Console.Write(s);
            Thread.Sleep(500);
            Console.Write("\b \b");
            i++;

            if (i >= animationStrings.Count)
            {
                i = 0;
            }
        }
    }
    public void DisplayEndMessage()
    {
        Console.WriteLine("Well done!!!");
        ShowSpinner(3);
        Console.WriteLine($"You have completed {_duration} seconds of the {_name}");
        Thread.Sleep(4000);
    }
    
    public string GetRandomPrompt(List<string> _prompts)
    {
        int promptCount = _prompts.Count;
        int randomPromptInt = Random.Shared.Next(0, promptCount); 
        string randomPrompt = _prompts[randomPromptInt];
        return randomPrompt;
    }
}    