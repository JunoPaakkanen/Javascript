using System;

class Program {

    // Main Method
    public static void Main(String[] args)
    {

        Console.WriteLine("Main Method");
        DiaryEntry diaryEntry = new DiaryEntry("Title 1");
    }
}

public class DiaryEntry
{
    public string Date { get; set;}

    public string Title { get; set;}


    public DiaryEntry(string dateWithFormat, string title)
    {
        DateTime currentDateTime = DateTime.Now;
        string dateWithFormat = currentDateTime.ToLongDateString();
        Date = dateWithFormat;

        Title = title;
    }


}