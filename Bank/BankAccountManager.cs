namespace Bank
{
    interface IBankAccountManager
    {
        int Id { get; set; }
        string AccountNumber { get; set; }

        void ParaCek(int miktar,int kalanbakiye);
        void ParaYatir(int miktar);
    }





}
