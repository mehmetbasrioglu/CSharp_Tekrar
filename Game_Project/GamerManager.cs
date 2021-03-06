using System;
using System.Collections.Generic;
using System.Text;

namespace Game_Project
{
    class GamerManager : IGamerService
    {
        IUserValidation _userValidationService;

        public GamerManager(IUserValidation userValidationService)
        {
            _userValidationService = userValidationService;
        }

        public void signIn(Gamer gamer)
        {
            if (_userValidationService.Validate(gamer))
            {
                Console.WriteLine("Başarılı");
            }
            else
            {
                Console.WriteLine("Başarısız");
            }
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Silindi");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Güncellendi");
        }
    }
}
