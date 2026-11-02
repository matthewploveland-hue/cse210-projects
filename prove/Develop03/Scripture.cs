using System;
using System.Collections.Generic;
using System.Runtime;
public class Scripture
{
    private Reference _scriptureReference;
    private List<Word> _scripture = [];
    public Scripture(string randomVerse)
    {
        string[] verseParts = randomVerse.Split("|");
        int intChapter = Convert.ToInt32(verseParts[2]);
        int intStartVerse = Convert.ToInt32(verseParts[3]);
        int intEndVerse = Convert.ToInt32(verseParts[4]);
        _scriptureReference = new Reference(verseParts[1],intChapter,intStartVerse,intEndVerse);
        string verse = verseParts[5];
        string[] words = verse.Split(" ");
        foreach (string word in words)
        {
            Word w = new Word(word);
            _scripture.Add(w);
        }
    }

    private void DisplayText()
    {

        foreach (Word currentWord in _scripture)
        {
            Console.Write($" {currentWord.GetDisplayText()} ");
        }
    }
    public void DisplayScripture()
    {
        _scriptureReference.DisplayReference();
        DisplayText();
    }
    public void HideRandomWords()
    {
        int wordAmount = _scripture.Count;
        int done = 0;
        int visibleCount = 0;

        foreach (Word word in _scripture)
        {
            if (word.IsHidden() == false)
            {
                visibleCount++;
            }
        }
        int finalTarget = Math.Min(7, visibleCount);
        while (done < finalTarget)
        {
            int randomWordPlacement = Random.Shared.Next(0, wordAmount);
            if (_scripture[randomWordPlacement].IsHidden() == false)
            {
                _scripture[randomWordPlacement].HideWord();
                done++;
            }
        }
    }
    public bool EndProgram()
    {
        bool endProgram = true;

        foreach (Word word in _scripture)
        {
            if (word.IsHidden() == false)
            {
                endProgram = false;
                break;
            }
        }
        return endProgram;
    }
}