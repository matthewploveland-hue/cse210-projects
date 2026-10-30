using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment1 = new Assignment("Matthew Loveland", "Religion");
        Console.WriteLine($"{assignment1.GetSummary()}");
        Math mathassignment1 = new Math("Matthew Loveland", "Religion", "Section 2.3", "Problems 1-7");
        Console.WriteLine($"{mathassignment1.GetHomeworkList()}");
        Writing writassignment1 = new Writing("Matthew Loveland", "Religion", "Love and War");
        Console.WriteLine($"{writassignment1.GetWritingInformation()}");
    }   
}