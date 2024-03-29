using System;
public class BlogWriter : Writer
{
    public BlogWriter(string firstName, string lastName, string title, string genre) : base(firstName,lastName,title,genre)
    {
    }

    public override void Vlog()
    {
        Console.WriteLine("I have also a vlog connected with my blog.");
    }

    protected override void WritingAbout()
    {
        Console.WriteLine("The name of my blog is " + this.Title + ". " +
                          "I'm writing about " + this.Genre + ".");
    }
}