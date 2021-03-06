using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ATM
{
    public class LoginManager : ILoginService
    {
        public string KartiCikar(List<Customer> customerList, int customerId)
        {
            if (customerList.Where(l => l.Id == customerId).Any(x => x.GetType().FullName == typeof(Individual).FullName))
            {
                return "Bireysel";
            }
            else if (customerList.Where(l => l.Id == customerId).Any(x => x.GetType().FullName == typeof(Corporate).FullName))
            {
                return "Şirket";
            }
            else
            {
                return "";
            }
        }


        public string Login(List<Customer> customerList,int customerId)
        {
            var deneme = typeof(Individual).FullName;


            if (customerList.Where(l => l.Id == customerId).Any(x => x.GetType().FullName == typeof(Individual).FullName))
            {
                return "Bireysel";
            }
            else if (customerList.Where(l => l.Id == customerId).Any(x => x.GetType().FullName == typeof(Corporate).FullName))
            {
                return "Şirket";
            }
            else
            {
                return "";
            }
        }

        public int ParaCek(List<Customer> customerList, int customerId,int miktar)
        {
            if(customerList.Where(l => l.Id == customerId).Any(x => x.GetType().FullName == typeof(Individual).FullName) && miktar != 0)
            {
                return 30000 - miktar;
            }
            else if (customerList.Where(l => l.Id == customerId).Any(x => x.GetType().FullName == typeof(Corporate).FullName) && miktar != 0)
            {
                return 30000 - miktar;
            }
            else
            {
                return 0;
            }
        }
    }
}
