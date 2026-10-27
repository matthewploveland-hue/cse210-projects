using System;
using System.Collections.Generic;
using System.Runtime;
public class Scripture
{
    public List<Word> _scripture = [];
    public Reference _scriptureReference = new Reference();
    public Scripture(string randomVerse)
    {       
        string[] verseParts = randomVerse.Split("|");
        _scriptureReference._volume = verseParts[0];
        _scriptureReference._book = verseParts[1];
        int intChapter = Convert.ToInt32(verseParts[2]);
        _scriptureReference._chapter = intChapter;
        int intStartVerse = Convert.ToInt32(verseParts[3]);
        _scriptureReference._startVerse = intStartVerse;
        int intEndVerse = Convert.ToInt32(verseParts[4]);
        _scriptureReference._endVerse = intEndVerse;
        string verse = verseParts[5];
        string[] words = verse.Split(" ");
        foreach (string word in words)
        {
            Word w = new Word(word);
            _scripture.Add(w);
        }
    }
    public void DisplayReference()
    {   
        if (_scriptureReference._endVerse != _scriptureReference._startVerse)
        {
            Console.WriteLine($"{_scriptureReference._book} {_scriptureReference._chapter}:{_scriptureReference._startVerse}-{_scriptureReference._endVerse}");
        }
        else
        {
            Console.WriteLine($"{_scriptureReference._book} {_scriptureReference._chapter}:{_scriptureReference._startVerse}");
        }
    }
    public void DisplayText()
    {
        
        foreach (Word currentWord in _scripture)
        {
            Console.Write($" {currentWord.GetDisplayText()} ");
        }        
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
            if (_scripture[randomWordPlacement]._isHidden == false)
            {
                _scripture[randomWordPlacement].HideWord();
                done ++;   
            }
        }
    }
    public bool EndProgram()
    {
        bool endProgram = true;

        foreach (Word word in _scripture)
        {
            if (word._isHidden == false)
            {
                endProgram = false;
                break;
            }
        }
        return endProgram;
    } 
}