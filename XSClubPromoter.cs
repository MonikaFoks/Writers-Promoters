using System;

public class XSClubPromoter : Promoter, IBodyBuilder, IVlogger
{
    public XSClubPromoter(string firstName, string lastName, int cellphone) : base(firstName, lastName, cellphone)
    {
    }

    protected override void Share()
    {
        Console.WriteLine("I will promote you using Instagram.");
    }

    protected override void paidAds()
    {
        Console.WriteLine("I am using Google AdWord paid ads.");
    }

    public void Workout()
    {
        Console.WriteLine("Oh, I am also working out, and you can look at me for free!");
    }

    public void Vlog()
    {
        Console.WriteLine("If you want to know, my hobby is vlogging - I can show you if you want.");
    }
    
}