using System;
using System.Security.Cryptography;

class Program
{
    static void DisplayMessage()
    {
        Console.WriteLine("Welcome to the program!");
    }
    static string PromptUserName()
    {
        Console.WriteLine("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }
    static int PromptUserNumber()
    {
        Console.WriteLine("Please enter your favorite number: ");
        string fav_number = Console.ReadLine();
        int int_fav_number = Convert.ToInt32(fav_number);
        return int_fav_number;
    }
    static int PromptUserBirthYear() 
    {
        Console.WriteLine("Please enter the year you were born: ");
        string birth_year = Console.ReadLine();
        int int_birth_year = Convert.ToInt32(birth_year);
        return int_birth_year;
    }
    static int SquareNumber(string name, int int_fav_number) 
    {
        int squared_number = int_fav_number * int_fav_number;
        return squared_number;
    }
    static void DisplayResult(string name, int int_birth_year, int squared_number) 
    {
        int age = 2026 - int_birth_year;
        Console.WriteLine($"{name}, the square of your number is {squared_number}");
        Console.WriteLine($"{name}, you will turn {age} this year.");
    }
    static void Main(string[] args)
    {
        DisplayMessage();
        string name = PromptUserName();
        int int_fav_number = PromptUserNumber();
        int int_birth_year = PromptUserBirthYear();
        int squared_number = SquareNumber(name, int_fav_number);
        DisplayResult(name, int_birth_year, squared_number);
    }


    
}