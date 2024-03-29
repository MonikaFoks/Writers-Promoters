using System;

public class OmniaClubPromoter : Promoter
{
    public OmniaClubPromoter(string firstName, string lastName, int cellphone) : base(firstName, lastName, cellphone)
    {
    }

    protected override void Share()
    {
        Console.WriteLine("I will promote you to my friends.");
    }

    protected override void paidAds()
    {
        Console.WriteLine("I am using Facebook paid ads.");
    }

    protected override void End()
    {
        Console.WriteLine("Feel free to contact me! My phone number is " + this.cellphone +".");
    }
}