using GameProject.Adapter;
using GameProject.Concrete;
using GameProject.Entities;
using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Gamer gamer1 = new Gamer()
            {
                Id = 1,
                FirstName = "Musa",
                LastName = "Erkek",
                BirthYear = new System.DateTime(1998,1,1),
                IdentityNumber = "12345678910"
            };

            GamerManager gamerManager = new GamerManager(new MernisServiceAdapter());
            gamerManager.Add(gamer1);

            Game game1 = new Game() { Id = 1, Name = "Witcher3", Price = 50 };

            GameManager gameManager = new GameManager();
            gameManager.Add(game1);
          
            Campaign campaign1 = new Campaign() { Id = 1, Name ="Black Friday", Discount = 30 };

            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(campaign1);
        }
    }
}
