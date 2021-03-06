using System;
using System.Collections.Generic;
using System.Text;

namespace Game_Project
{
    interface IGameService
    {
        void Buy(Game game,Campaign campaign);
        void Add(Game game);
        void Delete(Game game);
        void Update(Game game);
    }
}
