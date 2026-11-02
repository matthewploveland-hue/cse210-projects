public class Reference
{
    private string _volume = "";
    private string _book = "";
    private int _chapter = 0;
    private int _startVerse = 0;
    private int _endVerse = 0;

    // public Reference(string book, int chapter, int startVerse)
    // {
    //     _book = book;
    //     _chapter = chapter;
    //     _startVerse = startVerse;
    // }
    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = endVerse;
    }

    public void DisplayReference()
    {
        if (_endVerse != _startVerse)
        {
            Console.WriteLine($"{_book} {_chapter}:{_startVerse}-{_endVerse}");
        }
        else
        {
            Console.WriteLine($"{_book} {_chapter}:{_startVerse}");
        }
    }

}