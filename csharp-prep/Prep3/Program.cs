using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {

        Random randomGenerator = new Random();
        int magic_number = randomGenerator.Next(1, 99);
        Console.WriteLine("Guess the magic number! What is your guess? ");
        string guess = Console.ReadLine();
        int intguess = Convert.ToInt32(guess);
        
        while (magic_number != intguess)
        {
            while (magic_number > intguess)
            {
                Console.WriteLine("Higher");
                guess = Console.ReadLine();
                intguess = Convert.ToInt32(guess);
            }
            while (intguess > magic_number)
            {
                Console.WriteLine("Lower");
                guess = Console.ReadLine();
                intguess = Convert.ToInt32(guess);
            }
        }
        Console.WriteLine("You guessed it!");

        }   
        } 


