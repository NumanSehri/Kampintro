using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine("Müşteri : " + customer.CustomerName + " Eklendi");
        }

        public void List(Customer customer)
        {
                                     Console.WriteLine(customer.CustomerName + "Müşteriler Listelendi");
        }

        public void Delete(Customer customer)
        {
            Console.WriteLine(customer.CustomerName + "Müşteri Silindi");
        }



    }
}
