using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new ValidationManager());
            gamerManager.Add(new Gamer 
            { Id = 1, 
                BirthYear = 2000, ,
                FirstName = "Furkan", 
                IdentityNum = 1234 });

            SaleManager saleManager = new SaleManager(new CampaignManager());
            saleManager.Sale(new Gamer { Id = 1,
                BirthYear = 2000,
                FirstName = "Furkan",
                IdentityNum = 1234 });
        }
    }
}
