using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        Console.WriteLine("Enter a number: ");
        string entry = Console.ReadLine();
        int int_entry = Convert.ToInt32(entry);
        //create list
        List<int> numbers = new List<int>();
        numbers.Add(int_entry);
        //create while loop to continue adding numbers until "0" is entered
        while (int_entry != 0)
        {
            
            Console.WriteLine("Enter a number: ");
            entry = Console.ReadLine();
            int_entry = Convert.ToInt32(entry);
            numbers.Add(int_entry);

        }
        Console.WriteLine("done");

        int count = (numbers.Count);
        int max = (numbers.Max());

        int sum = 0;
        foreach (int number in numbers)
        {
            
            sum = sum + number;
        }

        int average = sum/count;

        Console.WriteLine($"The sum is: {sum}");

        Console.WriteLine($"The average is: {average}");

        Console.WriteLine($"The largest number is: {max}");

    }
}