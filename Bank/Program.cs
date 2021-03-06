namespace Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            IBankAccountManager bankManager = new ParaIslemleri();
            bankManager.Id = 1;
            bankManager.AccountNumber = "123456";
            bankManager.ParaYatir(10000);
            bankManager.ParaCek(50000,110000);

            IBankAccountManager bankManager2 = new ParaIslemleri();
            bankManager2.Id = 2;
            bankManager2.AccountNumber = "5815314851";
            bankManager2.ParaYatir(10000);
            bankManager2.ParaCek(7000, 10000);

        }
    }





}
