using System;
using System.Collections.Generic;
using System.Text;

namespace Game_Project
{
    class GameManager : IGameService
    {
        public void Add(Game game)
        {
            Console.WriteLine(game.gameName + " New Game Added");
        }

        public void Buy(Game game,Campaign campaign)
        {
            game.UnitPrice = (game.UnitPrice * campaign.Percantage) / 100;
            Console.WriteLine(game.gameName + " New Game Buyed. With Campaign Price:"+game.UnitPrice);
        }

        public void Delete(Game game)
        {
            Console.WriteLine(game.gameName + " New Game Deleted");
        }

        public void Update(Game game)
        {
            Console.WriteLine(game.gameName + " New Game Updated");
        }
    }
}
