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
            Console.WriteLine("What would you like to do?\nYour options are:\n1. Create a new diary entry by typing \"New entry\"\n2. Find a specific entry by typing \"Find entry\"");
            Console.WriteLine("3. Exit by typing \"Exit\"");
            var answer = Console.ReadLine();
            var answerInEntryViewer = "";
            bool continuing = false;
            if (answer == "New entry")
            {
                entryCount++;
                string entryName = "Entry" + entryCount;
                nextEntry = CreateNewEntry();
                Entries.Add(entryName, nextEntry);
                Console.WriteLine("Created new entry with the name: " + entryName);
            }
            if (answer == "Find entry")
            {
                continuing = true;
                while (continuing == true)
                {
                    Console.WriteLine("Write the name of the entry you would like to read. (In the format: \"Entry1\")");
                    var entrySearch = Console.ReadLine();
                    if (entrySearch != null)
                    {
                        Entries[entrySearch]?.ShowEntry();
                        Console.WriteLine("Would you like to continue searching or go back? Type either \"Continue\" or \"Back\"");
                        if (Entries[entrySearch].Deleted == false)
                        {
                            Console.WriteLine("You can also edit this entry by typing \"Edit\"");
                            Console.WriteLine("Or even delete it by typing \"Delete\"");
                        }
                        answerInEntryViewer = Console.ReadLine();
                        if (answerInEntryViewer == "Continue")
                        {
                            continuing = true;
                        }
                        else if (answerInEntryViewer == "Delete" & Entries[entrySearch].Deleted == false)
                            {
                                Entries[entrySearch].DeleteEntry();
                                Console.WriteLine("Entry has been deleted!");
                                continuing = false;
                            }
                        else if (answerInEntryViewer == "Back")
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

    public bool Deleted { get; set;}


    public DiaryEntry(string title, string content)
    {
        DateTime currentDateTime = DateTime.Now;
        string dateWithFormat = currentDateTime.ToLongDateString();
        Date = dateWithFormat;

        bool deleted = false;
        Deleted = deleted;

        Title = title;
        Content = content;
    }

    public void ShowEntry()
    {
        Console.WriteLine(Date);
        Console.WriteLine(Title);
        Console.WriteLine(Content);
    }

    public void DeleteEntry()
    {
        Date = "Deleted";
        Title = "Deleted";
        Content = "Deleted";
    }
}

