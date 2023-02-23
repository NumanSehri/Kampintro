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

        public void List(params Customer[] customer)
        {
            foreach (var customers in  customer)
            {
                Console.WriteLine(customers);
            }
                                     
        }

        public void Delete(Customer customer)
        {
            Console.WriteLine(customer.CustomerName + "Müşteri Silindi");
        }



    }
}
