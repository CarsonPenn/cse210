using System;

public class Journal
{

    public List<Entry> _entries = new List<Entry>();
    
    
    
        public void NewEntry()
    {
        Entry userEntry = new Entry();

        // these three lines pill from Entry.cs to get date, prompt and the recorded response
        userEntry.GenerateDate();
        userEntry.GeneratePrompt();
        userEntry.GetResponse();

        // this addes them together as a single entry
        _entries.Add(userEntry);
    }

// similar to my get entries, it displays the results
    public void DisplayEntries()
    {
        foreach (Entry entry in _entries)
        {
            Console.WriteLine($"Date: {entry._date}");
            Console.WriteLine($"Prompt: {entry._prompt}");
            Console.WriteLine($"{entry._response}");
            Console.WriteLine();
        }
    }
// this one opens a file and spilts the information if its a csv into three parts and displays them
// the three parts are in the order that i saved them, I wonder if i were to load a file that someone else's
// project would load correctly
    public void LoadEntries(string filename)
    {
        if (filename.EndsWith(".csv"))
        {
            string[] lines = System.IO.File.ReadAllLines(filename);
            foreach (string line in lines)
            {
                string[] parts = line.Split(",");
                string date = parts[0];
                string prompt = parts[1];
                string response = parts[2];
                Console.WriteLine($"Date: {date}");
                Console.WriteLine($"Prompt: {prompt}");
                Console.WriteLine($"{response}");
                Console.WriteLine();
            }
        }
        else
        {
            using (StreamReader reader = new StreamReader(filename))
            {
                String journalEntries = reader.ReadToEnd();
                Console.Write(journalEntries);
            }
        }
    }
// StreamWriter is cool
    public void SaveEntries(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename, true))
        {
            if (filename.EndsWith(".csv"))
            {
                foreach (Entry entry in _entries)
                {
                    outputFile.WriteLine($"{entry._date},{entry._prompt},{entry._response}");
                }
            }
            else
            {
                foreach (Entry entry in _entries)
                {
                    outputFile.WriteLine($"Date:{entry._date},{entry._prompt},{entry._response}");
                    outputFile.WriteLine($"Prompt:{entry._prompt}");
                    outputFile.WriteLine($"{entry._response}");
                    outputFile.WriteLine();
                }
            }
        }
    }
}

// file save and load article https://www.c-sharpcorner.com/article/working-with-c-sharp-streamreader/