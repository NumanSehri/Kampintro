using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();

            customer1.Id = 1;
            customer1.CustomerName = "Numan";
            customer1.CustomerSurname = "ŞEHRİ";
            customer1.NationalIdentty = "12346789111";
            customer1.Nation = "Türkiye";

            Customer customer2 = new Customer();

            customer2.Id = 2;
            customer2.NationalIdentty = "23456789562";
            customer2.CustomerName = "Damla";
            customer2.CustomerSurname = "ŞEHRİ";
            customer2.Nation = "Türkiye";

            CustomerManager customerManager = new CustomerManager();
            
                customerManager.Add(customer1);
                customerManager.List(customer2);
                customerManager.Delete(customer1);



            
        }
    }
}
