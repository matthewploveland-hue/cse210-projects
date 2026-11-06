public class Listing : Activity
{
    private int _numOfItemsEntered = 0;

    protected List<string> _listingPrompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?",
    };
    public Listing() : base("Listing Activity","This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
        
    }
    public void ListingActivity()
    {
        _numOfItemsEntered = 0;
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        Console.WriteLine("List as many responses you  can to the following prompt: ");
        Console.WriteLine($"---{GetRandomPrompt(_listingPrompts)}---");
        Console.WriteLine("You may begin in: ");
        ShowCountdown(4);
        while (DateTime.Now < endTime)
        {
            Console.Write(">");
            Console.ReadLine();
            _numOfItemsEntered ++;
        }
        DisplayItemAmount();
    }
    public void DisplayItemAmount()
    {
        Console.WriteLine($"You listed {_numOfItemsEntered} items");
    }
}