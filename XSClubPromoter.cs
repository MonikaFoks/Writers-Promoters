using System;

public class XSClubPromoter : Promoter
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
}