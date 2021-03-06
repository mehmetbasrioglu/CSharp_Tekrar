using System;
using System.Collections.Generic;
using System.Text;

namespace ATM
{
    interface ILoginService
    {
        string Login(List<Customer> customerList, int customerId);
        string KartiCikar(List<Customer> customerList, int customerId);

        int ParaCek(List<Customer> customerList, int customerId,int miktar);
    }
}
