using System;

public abstract class Writer
{
    private string firstName, lastName, title, genre;

    public string fullName
    {
        get
        {
            return string.Format("{0} {1}", this.firstName, this.lastName);
        }
    }
    public string Title 
    {
        get
        {
            return this.title;
        }
    }

    public string Genre
    {
        get
        {
            return this.genre;
        }
    }

    public Writer(string firstName, string lastName, string title, string genre)
    {
        this.firstName = firstName;
        this.lastName = lastName;
        this.title = title;
        this.genre = genre;
    }

    public void Write() 
    {
        this.Introduce();
        this.WritingAbout();
    }

    protected virtual void Introduce()
    {
        Console.WriteLine("Hi, I'm " + this.fullName + ".");
    }
    protected abstract void WritingAbout();

}