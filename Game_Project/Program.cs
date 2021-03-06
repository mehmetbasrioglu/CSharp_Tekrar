using System;

namespace Game_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            gamerManager.signIn(new Gamer { Id=1, FirstName="Mehmet", LastName="Basrioğlu", BirthYear=2000, IdentityNumber= 123456 });

            Campaign kampanya = new Campaign();
            kampanya.Id = 1;
            kampanya.CampaignDesc = "GTA 5 INDIRIMI";
            kampanya.Percantage = 50;

            Game gta = new Game();
            gta.Id = 1;
            gta.gameName = "GTA 5";
            gta.UnitPrice = 185.0;


            CampaignManager kampanyaManager = new CampaignManager();
            kampanyaManager.Add(kampanya);

            GameManager gameManager = new GameManager();
            gameManager.Buy(gta,kampanya);

            
            



            
        }
    }
}
