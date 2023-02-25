using System;

namespace ConstructorOdev
{
    class Program
    {
        static void Main(string[] args)
        {//Consructor - yapıcı Blok

            Customer customer = new Customer { Id = 1, FirstName="Numan",LastName="ŞEHRİ",City="Amasya" };
            Customer customer1 = new Customer(2,"Damla","ŞEHRİ","Amasya");
            Console.WriteLine(customer1.FirstName);


        }
    }
    class Customer
    {
        public Customer()
        {

        }
        public Customer(int id,string firstName,string lastName,string city)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            City = city;


            Console.WriteLine("Yapıcı Blok Çalıştı");
        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
    }


}
