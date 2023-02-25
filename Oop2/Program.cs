using System;

namespace Oop2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Numan ŞeHRİ
            Customer customer1 = new Customer();
            customer1.FirstName = "Numan";
            customer1.LastName = "ŞEHRİ";
            customer1.Id = 1;
            customer1.NationalIdentyNumber = "23567895423";
            customer1.CustomerNumber = "2181010";

            //Gerçek Müşteri - Tüzel Müşteri
            //SOLİD(L)
            Console.WriteLine(customer1.FirstName);
        }
    }
}
