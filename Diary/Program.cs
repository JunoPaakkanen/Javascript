using System;
using System.Security.Cryptography;

class Program {

    // Main Method
    public static void Main(String[] args)
    {
        
        DiaryEntry? nextEntry = null;
        bool inOptionsMenu = true;

        Dictionary<string, DiaryEntry> Entries = new Dictionary<string, DiaryEntry>();
        int entryCount = 0;

        while (inOptionsMenu == true)
        {
            Console.WriteLine("What would you like to do?\nYour options are:\n1. Create a new diary entry by typing \"New entry\"\n2. Find a specific entry by typing \"Find entry\"\n3. Exit by typing \"Exit\"");
            var answer = Console.ReadLine();
            var goBack = "";
            bool continuing = false;
            if (answer == "New entry")
            {
                entryCount++;
                string entryName = "Entry" + entryCount;
                nextEntry = CreateNewEntry();
                Entries.Add(entryName, nextEntry);
                Console.WriteLine("Created new entry with name: " + entryName);
            }
            if (answer == "Find entry")
            {
                while (continuing == true)
                {
                    Console.WriteLine("Write the name of the entry you would like to read. (In the format: \"Entry1\")");
                    var entrySearch = Console.ReadLine();
                    if (entrySearch != null)
                    {
                        Entries[entrySearch]?.Test();
                        Console.WriteLine("Would you like to continue searching or go back? Type either \"Continue\" or \"Back\"");
                        goBack = Console.ReadLine();
                        if (goBack == "Continue")
                        {
                            continuing = true;
                        }
                        else if (goBack == "Back")
                        {
                            continuing = false;
                        }
                    }
                }
            }
            
            if (answer == "Exit")
            {
                inOptionsMenu = false;
            }

        }
    }

    public static DiaryEntry CreateNewEntry()
    {
        Console.WriteLine("What is the title of your new diary entry?");
        var newTitle = Console.ReadLine() ?? "";
        newTitle = newTitle.ToString();

        Console.WriteLine("Write down the content of your new diary entry:");
        var newContent = Console.ReadLine() ?? "";
        newContent = newContent.ToString();

        return new DiaryEntry(newTitle, newContent);

    }


}

public class DiaryEntry
{
    
    public string Date { get; set;}

    public string Title { get; set;}

    public string Content { get; set;}


    public DiaryEntry(string title, string content)
    {
        DateTime currentDateTime = DateTime.Now;
        string dateWithFormat = currentDateTime.ToLongDateString();
        Date = dateWithFormat;

        Title = title;
        Content = content;
    }

    public void Test()
    {
        Console.WriteLine(Date + Title + Content);
    }
}

