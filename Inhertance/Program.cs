using System;

namespace Inhertance
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] people = new Person[3]
            {
                new Customer{FirstName="Numan"},
                new Student{FirstName="Damla"},
                new Person{FirstName="Zeynep"}


            };
            foreach (var person in people)
            {
                Console.WriteLine("Kayıtlı Kişiler : " + person.FirstName);

            }
        }
    }
}
