using System;
using System.Diagnostics;
class Program
{
    static void Main(string[] args)
    {
        ScriptureLibrary theScriptures = new ScriptureLibrary();
        int choice = theScriptures.VolumeMenu();
        string selectVerse = theScriptures.LoadVerse(choice);
        Scripture scripture = new Scripture(selectVerse);
        while (scripture.EndProgram() == false)
        {
            Console.Clear();
            scripture.DisplayReference();
            scripture.DisplayText();
            Console.WriteLine();
            Console.Write("Press enter to continue or type 'quit' to finish: ");
            string endResponse = Console.ReadLine().ToLower();
            if (endResponse == "quit")
            {
                break;
            }
            scripture.HideRandomWords();

        }
        Console.Clear();
        scripture.DisplayReference();
        scripture.DisplayText();
        
    }
}
// The way I stretched this assignment is by adding a small library
// with twelve scriptures, three from the Book of Mormon, the Doctrine
// and Covenants, and the New and Old Testaments. A menu is displayed
// prompting the user to choose which volume they would like a scripture
// from, and then the program randomizes a scripture from there.