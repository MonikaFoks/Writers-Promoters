using System;
public class BookWriter : Writer
{
    public BookWriter(string firstName, string lastName, string title, string genre) : base(firstName,lastName,title,genre)
    {
    }

    public override void Vlog()
    {
        Console.WriteLine("I'm also vlogging about my writing.");
    }

    protected override void WritingAbout()
    {
        Console.WriteLine("The title of my book is " + this.Title + "," +
                          " and genre is " + this.Genre + ".");
    }
}