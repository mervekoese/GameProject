using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            /*GamerManager gamerManager = new GamerManager(new ValidationManager());
        gamerManager.Add(new Gamer
        {
            FirstName = "merve" ,
            LastName = "köse",
            IdentityNumber = "12345", 
            Adress = "mimaroba"
        });*/

            GameSale gameSale = new GameSale(new ValidationManager(), new GameCampaign() );
            gameSale.Sale(new Gamer
            {
                FirstName = "Merve",
                LastName = "Köse",
                IdentityNumber = "12345",
                Adress = "Istanbul"
            },new Game
            {
               
            }
            ); 



            Console.WriteLine("Hello World!");
        }
    }
}

