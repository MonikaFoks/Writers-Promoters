using System;
using System.Collections.Generic;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            XSClubPromoter markTheXSPromoter = new XSClubPromoter("Mark", "Rogers", 692837261);
            OmniaClubPromoter annaTheOmniaPromoter = new OmniaClubPromoter("Anna","Swift", 362783729);

            List<Promoter> promoters = new List<Promoter>() {new XSClubPromoter("Mark", "Rogers", 692837261),
                                                             new XSClubPromoter("Sue", "Mann", 456135784), 
                                                             new OmniaClubPromoter("Anna","Swift", 362783729)};
            
            List<Writer> writers = new List<Writer>() {new BlogWriter("Daniel", "Fox", "Living With Idiots", "basically my life"),
                                                       new BookWriter("Stephen", "King", "The Shining", "horror"),
                                                       new BlogWriter("Agatha", "Nell", "Cooking for lazy people", "how to make a dish while sleeping")};

            foreach(var item in promoters)
            {
                item.Promote();
            }

            foreach(var item in writers)
            {
                item.Write();
            }
        }
    }
}
