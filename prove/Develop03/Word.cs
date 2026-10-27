public class Word
{
    public string _text = "";
    public bool _isHidden = false;
    public Word(string word)
    {
        _text = word;
    }
    public void HideWord()
    {
        _isHidden = true;  
    } 
    public bool IsHidden()
    {
        return _isHidden;
    }
    public string GetDisplayText()
    {
        int wordLength = _text.Length;
        string hiddenWord = new string('_', wordLength);
        if (_isHidden == false)
        {
            return _text;
        }
        else
        {
            return hiddenWord;
        }
    }
}