public class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;
    public Reference(string book, int chapter, int verse)
    {
        // get the info for the private classes when there is only one verse
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = verse;
    }
    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        // get the info for the private classes when there is more than one verse
        _book = book;
        _chapter = chapter;
        _verse = startVerse;
        _endVerse = endVerse;
    }
    public string GetDisplayText()
    {
        string displayText;
        // if else statement to determine if we are displaying multiple versus or a single verse
        if (_verse == _endVerse)
        {
            displayText = $"{_book} {_chapter}:{_verse}";
        }
        else
        {
            displayText = $"{_book} {_chapter}:{_verse}-{_endVerse}";
        }
        return displayText;
    }
}