using System;
using System.Collections.Generic;
using System.Text;

namespace Game_Project
{
    class UserValidationManager : IUserValidation
    {
        public bool Validate(Gamer gamer)
        {
            if(gamer.BirthYear == 2000 && gamer.FirstName == "Mehmet" && gamer.LastName == "Basrioğlu" && gamer.IdentityNumber == 123456)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
