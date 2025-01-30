using System.Text.Json;
using System.Text.Json.Serialization;

public class Journal
{
    // ATTRIBUTE DECLARATION
    public List<Entry> _entries = new List<Entry>();

    // MODULE DECLARATION
    public void SaveToFile(string filePath)
    {
        string json = JsonSerializer.Serialize(_entries, new JsonSerializerOptions { WriteIndented = true });
        File.WriteAllText(filePath, json);
    }

    public static Journal LoadFromFile(string filePath)
    {
        if (!File.Exists(filePath))
        {
            Console.WriteLine("File not found. Creating empty journal.");
            return new Journal();
        }

        string json = File.ReadAllText(filePath);
        List<Entry> entries = JsonSerializer.Deserialize<List<Entry>>(json) ?? new List<Entry>();

        return new Journal { _entries = entries };
    }
}