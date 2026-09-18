using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage? ");
        string grade = Console.ReadLine();
        int intgrade = Convert.ToInt32(grade);
        string letter;

        if (intgrade >= 90)
        {
            letter = "A";
        }
        else if (intgrade >= 80)
        {
            letter = "B";
        }
        else if (intgrade >= 70)
        {
            letter = "C";
        }
        else if (intgrade >= 60)
        {
            letter = "D";
        }
        else if (intgrade < 60)
        {
            letter = "F";
        }
        else
        {
            letter = "NaN";
        }
        

        Console.WriteLine($"You received a {letter}.");

        if (letter == "F")
        {
            Console.WriteLine("You failed this class, try harder next time! ");
        }
        else
        {
            Console.WriteLine($"Well done!!! You passed the class!");
        }
            

    }
}