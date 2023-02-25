using System;

namespace Oop2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Numan ŞeHRİ
            RealyCustomer realyCustomer1 = new RealyCustomer();
            realyCustomer1.Id = 1;
            realyCustomer1.CustomerNumber = "12345";
            realyCustomer1.FirstName = "Numan";
            realyCustomer1.LastName = "ŞEHRİ";
            realyCustomer1.NationalIdentyNumber = "12345678942";


            //Kodlama.io

            CompanyCustomer companyCustomer1 = new CompanyCustomer();
            companyCustomer1.Id = 2;
            companyCustomer1.CustomerNumber = "54869";
            companyCustomer1.CompanyName = "Kodlama.io";
            companyCustomer1.TaxNumber = "1234567890";


            //Gerçek Müşteri - Tüzel Müşteri
            //SOLİD

            Customer customer3 = new RealyCustomer();
            Customer customer4 = new CompanyCustomer();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(realyCustomer1);



        }
    }
}
