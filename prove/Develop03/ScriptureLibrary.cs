using System;
using System.Collections.Generic;
public class ScriptureLibrary
{
    public int VolumeMenu()
    {
        Console.WriteLine("Would you like a scripture from:");
        Console.WriteLine("1: The Book of Mormon");
        Console.WriteLine("2: The Doctrine and Covenants");
        Console.WriteLine("3: The New Testament");
        Console.WriteLine("4: The Old Testament");
        Console.Write("Type a number: ");
        string volumeResponse = Console.ReadLine();
        int intResponse = Convert.ToInt32(volumeResponse);

        return intResponse; 
    }

    public string LoadVerse(int intResponse)
        {   
            List<string> matchingLines = [];
            string volumeName = "";
            if (intResponse == 1)
            {
                volumeName = "Book of Mormon";
            }
            if (intResponse == 2)
            {
                volumeName = "Doctrine and Covenants";
            }
            if (intResponse == 3)
            {
                volumeName = "New Testament";
            }
            if (intResponse == 4)
            {
                volumeName = "Old Testament";
            }
            // find the right verses and madd them to a list    
            string fileName = "scripture_library.txt";
            string[] lines = System.IO.File.ReadAllLines(fileName);
            foreach (string line in lines)
            {
                string[] parts = line.Split("|");
                if (parts[0] == volumeName)
                    {
                        matchingLines.Add(line);
                    }
            }
            // randomize it, make a variable
            int lineCount = matchingLines.Count;
            int randomLine = Random.Shared.Next(0, lineCount); 
            string randomVerse = matchingLines[randomLine];
            return randomVerse;
        }
}