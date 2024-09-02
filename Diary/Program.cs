using System; 

class Program {

    // Main Method
    public static void Main(String[] args)
    {
        
        DiaryEntry? nextEntry = null;
        int entryCounter = 0;
        bool inOptionsMenu = true;
        while (inOptionsMenu == true)
        {
            Console.WriteLine("What would you like to do?\nYour options are:\n1. Create a new diary entry by typing \"New entry\"");
            var answer = Console.ReadLine();
        
            if (answer == "New entry")
            {
                string entryName = "Diary" + entryCounter;
                nextEntry = CreateNewEntry();
                entryCounter += 1;
            }

        }

        nextEntry?.Test();
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

