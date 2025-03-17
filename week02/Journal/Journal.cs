using System;
using System.Collections.Generic;


public class Journal
{
     private List<Entry> entries = new List<Entry>(); 
    List<string> prompts = new List<string>
    {
       "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?"
    };
    
    public void AddEntry()
    {
        // Add the entry to the journal
        Random random = new Random();
        string prompt = prompts[random.Next(prompts.Count)];
        Console.WriteLine($"\nPrompt: {prompt}");
       
        Console.Write("Your response: ");
        string response = Console.ReadLine();
       
        Entry newEntry = new Entry
        {
            Date = DateTime.Now.ToString("yyyy-MM-dd"),
            Prompt = prompt,
            Response = response
        };
        
        entries.Add(newEntry);  // Add entry to the journal
        Console.WriteLine("Entry added successfully!");
    }

    

    public void DisplayJournal(){
      
        foreach (Entry entry in entries)
        {
            Console.WriteLine($"\nDate: {entry.Date}");
            Console.WriteLine($"Prompt: {entry.Prompt}");
            Console.WriteLine($"Response: {entry.Response}");
        }
    }

    public void SaveJournal(){
        Console.WriteLine("Enter filename to save (e.g., journal.txt): ");
        string filename = Console.ReadLine();

        using (StreamWriter sw = new StreamWriter(filename)) {
            foreach (Entry entry in entries)
                {
                   
                    sw.WriteLine($"{entry.Date}~|~{entry.Prompt}~|~{entry.Response}");
                }
                Console.WriteLine("Journal saved successfully!");
        }
    }

    public void LoadJournal(){
        Console.WriteLine("Enter filename to load (e.g., journal.txt): ");
        string filename = Console.ReadLine();
        entries.Clear(); 

        if (File.Exists(filename)) {
         using (StreamReader sr = new StreamReader(filename)) {
            while (!sr.EndOfStream) {
                string line = sr.ReadLine();
                string[] parts = line.Split("~|~");
                if (parts.Length == 3) {
                    Entry entry = new Entry {
                        Date = parts[0],
                        Prompt = parts[1],
                        Response = parts[2]
                    };
                    entries.Add(entry);
                }
            }
         }
    }
    }

  public void DeleteEntry(int index){
    entries.RemoveAt(index);
  }
}