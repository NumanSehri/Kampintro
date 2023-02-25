using System;

namespace Deneme
{

  
    

                



    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();
            Customer customer1 = new Customer();
            person1.Id = 1;
            person1.FirtName = "Numan";
            customer1.CreditCardNumber = 12345;
          

            customer1.FirtName = "Damla";




            Console.WriteLine("Class OOP Örnekleri");

            Console.WriteLine(customer1.FirtName);
        }
    }

    class Person
    {
        public int Id { get; set; }
        public string FirtName { get; set; }
        public string  LastName { get; set; }
    }

    class Customer:Person
    {
        public int CreditCardNumber { get; set; }
    }





}
