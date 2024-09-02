using System; 

class Program {

    // Main Method
    public static void Main(String[] args)
    {
        Console.WriteLine("What would you like to do?\nYour options are:\n1. Create a new diary entry by typing \"New entry\"");
        var answer = Console.ReadLine();
        if (answer == "New entry")
        {
            
        }
        Console.WriteLine("What is the title of your new diary entry?");
        var newTitle = Console.ReadLine() ?? "";
        newTitle = newTitle.ToString();

        Console.WriteLine("Write down the content of your new diary entry:");
        var newContent = Console.ReadLine() ?? "";
        newContent = newContent.ToString();

        DiaryEntry diaryEntry1 = new DiaryEntry(newTitle, newContent);
        DiaryEntry diaryEntry2 = new DiaryEntry("Title 2", "Sussy baka");

        diaryEntry1.Test();
        diaryEntry2.Test();
        
        
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

