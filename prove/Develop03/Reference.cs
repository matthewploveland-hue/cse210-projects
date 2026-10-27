public class Reference
{
    public string _volume = "";
    public string _book = "";
    public int _chapter = 0;
    public int _startVerse = 0;
    public int _endVerse = 0;

    public Reference()
    {
        
    }
    public Reference(string book, int chapter, int startVerse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
    }
    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = endVerse;
    }

    
}