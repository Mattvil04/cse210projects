using System;

public class Journal{
    private  List<string> _prompts = new List<string>() {
    "Who was the most interesting person I interacted with today?",
    "What was the best part of my day?",
    "How did I see the hand of the Lord in my life today?",
    "What was the strongest emotion I felt today?",
    "If I had one thing I could do over today, what would it be?"
    };
    private List<Entry> _journal = new List<Entry>();
    public void WriteNewEntry()
    {
        Random random = new Random();
        int promptIndex = random.Next(_prompts.Count);
        string prompt = _prompts[promptIndex];
        Console.WriteLine(prompt);
        string response = Console.ReadLine();
        DateTime date = DateTime.Now;
        Entry newEntry = new Entry(prompt, response, date);
        _journal.Add(newEntry);
    }
    public void DisplayJournal()
    {
        foreach (Entry entry in _journal)
        {
            Console.WriteLine("Prompt: " + entry.Prompt);
            Console.WriteLine("Response: " + entry.Response);
            Console.WriteLine("Date: " + entry.Date);
            Console.WriteLine();
        }
    }
    public void SaveJournal(string filename)
    {
        using (StreamWriter sw = new StreamWriter(filename))
        {
            foreach (Entry entry in _journal)
            {
                sw.WriteLine(entry.Prompt);
                sw.WriteLine(entry.Response);
                sw.WriteLine(entry.Date);
            }
        }
    }
    public void LoadJournal(string filename)
    {
        _journal.Clear();
        string[] lines = File.ReadAllLines(filename);

        for (int i = 0; i < lines.Length; i += 3)
    {
        string prompt = lines[i];
        string response = lines[i + 1];
        DateTime date = Convert.ToDateTime(lines[i + 2]);
        Entry newEntry = new Entry(prompt, response, date);
        _journal.Add(newEntry);
    }
    }
}
  
    