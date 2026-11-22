public class GoalManager
{
    private List<Goal> _goals = new List<Goal>(); 
    private int _totalPoints = 0;
    public void CreateGoal()
    {
        Console.WriteLine("The types of goals are:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Which type of goal would you like to create?");
        string initialResponse = Console.ReadLine();
        int intResponse = Convert.ToInt32(initialResponse);
        
        if (intResponse == 1)
        {
            Console.Write("What is the name of your goal?");
            string name = Console.ReadLine();
            Console.Write("What is short description of it?");
            string description = Console.ReadLine();
            Console.Write("What is the amount of point associated with this goal?");
            string points = Console.ReadLine();
            int intPoints = Convert.ToInt32(points);
            SimpleGoal simpleGoal = new SimpleGoal(intPoints, name, description, false);
            _goals.Add(simpleGoal);
        }
        else if (intResponse == 2)
        {
            Console.Write("What is the name of your goal?" );
            string name = Console.ReadLine();
            Console.Write("What is short description of it?" );
            string description = Console.ReadLine();
            Console.Write("What is the amount of point associated with this goal?" );
            string points = Console.ReadLine();
            int intPoints = Convert.ToInt32(points);
            EternalGoal eternalGoal = new EternalGoal(intPoints, name, description);
            _goals.Add(eternalGoal);
        }
        else if (intResponse == 3)
        {
            Console.Write("What is the name of your goal?" );
            string name = Console.ReadLine();
            Console.Write("What is short description of it?" );
            string description = Console.ReadLine();
            Console.Write("What is the amount of point associated with this goal?" );
            string points = Console.ReadLine();
            int intPoints = Convert.ToInt32(points);
            Console.Write("How many times does this goal need to be accomplished for a bonus?" );
            string goalNumOfTimes = Console.ReadLine();
            int intGoalNumOfTimes = Convert.ToInt32(goalNumOfTimes);
            Console.Write("What is the bonus for completing the goal that amount of times?" );
            string bonusPoints = Console.ReadLine();
            int intBonusPoints = Convert.ToInt32(bonusPoints);
            ChecklistGoal checklistGoal = new ChecklistGoal(intPoints, name, description, intBonusPoints, intGoalNumOfTimes, 0);
            _goals.Add(checklistGoal);
        }
    }
    public void SaveGoal() 
    {
        Console.WriteLine("What is the filename?" );
        string filename = Console.ReadLine();
        
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine($"{_totalPoints}");
            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine($"{goal.SaveFile()}");
            }
        }
    }
    public void LoadGoal()
    {
        Console.WriteLine("What is the filename?");
        string filename = Console.ReadLine();

        string[] lines = System.IO.File.ReadAllLines(filename);
        _totalPoints = Convert.ToInt32(lines[0]);
        _goals.Clear();
        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split("~|~");

            if (parts[0] == "SimpleGoal")
            {
                int intPoints = Convert.ToInt32(parts[1]);
                bool isCompleted = Convert.ToBoolean(parts[4]);
                SimpleGoal simpleGoal = new SimpleGoal(intPoints, parts[2], parts[3], isCompleted);
                _goals.Add(simpleGoal);
            }
            else if (parts[0] == "EternalGoal")
            {
                int intPoints = Convert.ToInt32(parts[1]);
                EternalGoal eternalGoal = new EternalGoal(intPoints, parts[2], parts[3]);
                _goals.Add(eternalGoal);
            }
            else if (parts[0] == "ChecklistGoal")
            {
                int intPoints = Convert.ToInt32(parts[1]);
                int intBonusPoints = Convert.ToInt32(parts[4]);
                int intGoalNumOfTimes = Convert.ToInt32(parts[5]);
                int intCurrentNumOfTimes = Convert.ToInt32(parts[6]);
                ChecklistGoal checklistGoal = new ChecklistGoal(intPoints, parts[2], parts[3], intBonusPoints, intGoalNumOfTimes, intCurrentNumOfTimes);
                _goals.Add(checklistGoal);
            }
        }
    }
    public void DisplayGoals()
    {
        foreach (Goal goal in _goals)
        {
            Console.WriteLine($"{goal.GoalString()}");
        }
        Console.WriteLine();
        Console.WriteLine($"You have {_totalPoints} points.");
        Console.WriteLine($"{LevelUp()}");
    }
    public void RecordEvent()
    {
        int numbered = 1;
        foreach (Goal goal in _goals)
        {
            Console.WriteLine($"{numbered}. {goal.GetName()}");
            numbered ++;
        }
        Console.WriteLine("Which goal did you accomplish?: ");
        string goalChoice = Console.ReadLine();
        int goalChoiceInt = Convert.ToInt32(goalChoice)-1;
        int earnedPoints = _goals[goalChoiceInt].RecordEvent();
        _totalPoints += earnedPoints;
        Console.WriteLine($"Congratulations! You have earned {earnedPoints} points!");
        Console.WriteLine($"You have {_totalPoints} points.");
        Console.WriteLine($"{LevelUp()}");
    }
    public string LevelUp()
    {
        int levelOne = 100;
        int levelTwo = 400;
        int levelThree = 800;
        int levelFour = 1200;
        int levelFive = 1600;
        if (_totalPoints <= levelOne)
        {
            return "Congratulations, you made it to Level One!";
        }
        if (_totalPoints <= levelTwo)
        {
            return "Congratulations, you made it to Level Two!";
        }
        if (_totalPoints <= levelThree)
        {
            return "Congratulations, you made it to Level Three!";
        }
        if (_totalPoints <= levelFour)
        {
            return "Congratulations, you made it to Level Four!";
        }
        if (_totalPoints <= levelFive)
        {
            return "Congratulations, you made it to Level Five!";
        }
        else
        {
            return "";
        }
    }
}