using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacesDemo
{
    class Manager : IWorker,IEat,ISalary
    {
        public void Eat()
        {
            Console.WriteLine("Yöneticiler Yemek Yiyor");
        }

        public void GetSalary()
        {
            Console.WriteLine("Yöneticiler Maaş Alıyor");
        }

        public void Work()
        {
            Console.WriteLine("Yöneticiler Çalışıyor");
        }
    }
}
