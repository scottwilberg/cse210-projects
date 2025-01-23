using System;
using System.Collections.Generic;
using System.Dynamic;
using System.IO;

public class ScriptureLibrary
{
    private List<Scripture> _scriptures;

    public ScriptureLibrary(string filePath)
    {
        _scriptures = new List<Scripture>();
        LoadScripturesFromFile(filePath);
    }
    // method to load scriptures form a file
    private void LoadScripturesFromFile(string filePath)
    {   
        // put the file in a string
        string[] lines = File.ReadAllLines(filePath);
        
        foreach (var line in lines)
        {
            // asked AI for help with this code
            if (string.IsNullOrWhiteSpace(line)) continue; // Skip empty lines
            {
                // Split by ~
                // part[0] = book
                // part[1] = chapter and verse seperated by :
                // part[2] = scripture text encloseed in "'s
                string[] parts = line.Split('~');
                string book = parts[0];
                string[] chapterAndVerse = parts[1].Split(':');
                int chapter = int.Parse(chapterAndVerse[0]);
                // seperate the chapter from the verse
                string[] verseParts = chapterAndVerse[1].Split('-');

                int startVerse = int.Parse(verseParts[0]);
                // if single verse then start and end are the same
                int endVerse = startVerse;
                // if statement to get second verse
                if (verseParts.Length > 1)
                {
                    endVerse = int.Parse(verseParts[1]);
                }
                // get the scripture part of the file
                string text = parts[2].Trim('"');
                // create a list of words form the file
                List<Word> words = Scripture.CreateWordList(text);
                // set the reference and scripture information to add to the scriptures
                Reference reference = new Reference(book, chapter, startVerse, endVerse);
                Scripture scripture = new Scripture(reference, words);
                _scriptures.Add(scripture);
            }
        }

    }
    //method to get a random scripture from the list
    public Scripture GetRandomScripture()
    {
        Random random = new Random();
        int index = random.Next(_scriptures.Count);
        return _scriptures[index];
    }
}