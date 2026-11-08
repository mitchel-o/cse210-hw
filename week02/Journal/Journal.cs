using System.IO;
using System.Collections.Generic;
namespace JournalProgram
{
    public class Journal
    {
        private List<Entry> _entries = new List<Entry>();
        public void AddEntry(Entry newEntry)
        {
            _entries.Add(newEntry);
        }
        public void DisplayAll()
        {
            foreach (Entry entry in _entries)
            {
                entry.Display();
            }
        }
        public void SaveToFile(string filename)
        {
            using (StreamWriter outputFile = new StreamWriter(filename))
            {
                foreach (Entry entry in _entries)
                {
                    outputFile.WriteLine($"{entry.GetDate()}~|~{entry.GetPrompt()}~|~{entry.GetEntryText()}");
                }
            }
        }
        public void LoadFromFile(string filename)
        {
            string[] lines = File.ReadAllLines(filename);
            _entries.Clear();
            foreach (string line in lines)
            {
                string[] parts = line.Split("~|~");
                if (parts.Length == 3)
                {
                    string date = parts[0];
                    string prompt = parts[1];
                    string entryText = parts[2];
                    Entry entry = new Entry(date, prompt, entryText);
                    _entries.Add(entry);
                }
            }
        }
    }
}
