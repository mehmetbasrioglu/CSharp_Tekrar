using System;

namespace Bank
{
    class ParaIslemleri : IBankAccountManager
    {
        public int Id { get; set; }
        public string AccountNumber { get; set; }

        public void ParaCek(int miktar, int bakiye)
        {
            int kalan = bakiye - miktar;
            Console.WriteLine(AccountNumber +" Hesabınızdan şu kadar para çekildi:"+miktar+" "+kalan+"");
        }

        public void ParaYatir(int miktar)
        {
            Console.WriteLine(AccountNumber + " Hesabınızdan şu kadar para yatırıldı:" + miktar);
        }
    }





}
