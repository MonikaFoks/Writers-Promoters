using System;
public abstract class Promoter 
{
    private string firstName, lastName;
    private int cellphone;

    public string fullName
    {
        get
        {
            return string.Format("{0} {1}", this.firstName, this.lastName);
        }
    }

    public Promoter(string firstName, string lastName, int cellphone)
    {
        this.firstName = firstName;
        this.lastName = lastName;
        this.cellphone = cellphone;
    }

    public void Promote() 
    {
        this.Introduce();
        this.Share();
        this.paidAds();
        this.End();
    }

    protected virtual void Introduce()
    {
        Console.WriteLine("Hello, my name is " + this.fullName + ".");
    }
    protected abstract void Share();
    protected abstract void paidAds();
    protected virtual void End()
    {
        Console.WriteLine("If you want to contact me, my cellphone number is " + this.cellphone + ".");
    }
}