using System.IO;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    /*
    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry)
    }
    */


    public void DisplayAll()
    {

    }

    public void SaveToFile()
    {
        string fileName = "journal.csv";

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            outputFile.WriteLine("This will be the first line in the file.");
        }
    }

}