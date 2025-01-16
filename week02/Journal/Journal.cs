public class Journal
{
    public List<Entry> _entries;

    public Journal()
    {
        // had to set up this so I didn't get a null error
        _entries = new List<Entry>();
    }
    public void AddEntry(Entry NewEntry)
    {
        // Console.WriteLine(NewEntry._date);
        // Console.WriteLine(NewEntry._promptText);
        // Console.WriteLine(NewEntry._entryText);
        // add entry to list
        _entries.Add(NewEntry);
    }
    public void DisplayAll()
    {
        foreach (Entry e in _entries)
        {
            Console.WriteLine($"Date: {e._date} - Prompt: {e._promptText}");
            Console.WriteLine(e._entryText);
        }
    }
    public void SaveToFile(string file)
    {
        using (StreamWriter outputFile = new StreamWriter(file))

        // save the list in a format so each part is seperated by a ~~
        foreach (Entry e in _entries)
        {
            outputFile.WriteLine($"{e._date}~~{e._promptText}~~{e._entryText}");
        }
    
    }
    public void LoadFromFile(string file)
    {
        string[] lines = System.IO.File.ReadAllLines(file);

        foreach (string line in lines)
        {
            //Console.WriteLine(line);
            // line will have something like this "01/15/2025~~Question string~~Journal entry string"

            // this splits the values in the file into different parts
            string[] parts = line.Split("~~");
            // parts[0] = _date
            // parts[1] = _promptText
            // parts[2] = _entryText

            // creating a new list from what is loading
            Entry newEntry = new Entry();
            newEntry._date = parts[0];
            newEntry._promptText = parts[1];
            newEntry._entryText = parts[2];

            // add entries from the load file to the list of entries
            _entries.Add(newEntry);
        }

    }
}