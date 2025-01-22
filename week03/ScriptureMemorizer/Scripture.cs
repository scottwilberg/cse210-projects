using System; 
using System.Collections.Generic;
public class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    public Scripture(Reference reference, List<Word> words) 
    { 
        _reference = reference; 
        _words = words; 
    }
   public void HideRandomWords(int numberToHide)
    {
        // initialize a random function
        Random random = new Random();
        int wordsCount = _words.Count;
        // keeps track of instances of hidden words ensuring no duplicates
        HashSet<int> hiddenWords = new HashSet<int>();

        // Count how many words are already hidden
        int hiddenCount = _words.Count(word => word.IsHidden());
        // keep track of how many words are left in case it is less than the number to hide
        int remainingWordsToHide = Math.Min(numberToHide, wordsCount - hiddenCount);

        // while loop to hide words
        while (hiddenWords.Count < remainingWordsToHide)
        {
            // declare a count to show if all words are hidden
            int index = random.Next(wordsCount);
            // if statement for hiding the words
            if (!_words[index].IsHidden())
            {
                _words[index].Hide();
                hiddenWords.Add(index);
            }
        }
    }

    public string GetDisplayText()
    {
        //declare a list for words to display
        List<string> displayedWords = new List<string>(); 
        foreach (var word in _words) 
        { 
            displayedWords.Add(word.Display()); 
        } 
        // return the reference and scripture text in the format I want
        return _reference.GetDisplayText() + " \"" + string.Join(" ", displayedWords) + "\"";
    }
    public bool IsCompletelyHidden()
    {
        // method to determine if all words are completely hidden
        foreach (var word in _words) 
        { 
            if (!word.IsHidden()) 
            { 
                return false; 
            } 
        } 
        return true;
    }
    // method for my scripureLibrary to create a list of words 
    public static List<Word> CreateWordList(string sentence) 
    { 
        List<Word> wordList = new List<Word>(); 
        string[] wordArray = sentence.Split(' '); 
        foreach (string wordText in wordArray) 
        { 
            Word word = new Word(wordText); 
            wordList.Add(word); 
        } 
        return wordList;
    }

}