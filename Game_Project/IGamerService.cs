using System;
using System.Collections.Generic;
using System.Text;

namespace Game_Project
{
    interface IGamerService
    {
        void signIn(Gamer gamer);
        void Update(Gamer gamer);
        void Delete(Gamer gamer);
    }
}
