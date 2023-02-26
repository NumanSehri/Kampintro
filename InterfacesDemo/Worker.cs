using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacesDemo
{
    class Worker : IWorker, IEat, ISalary
    {
        public void Eat()
        {
            Console.WriteLine("Çalışanlar Yemek Yiyor");
        }

        public void GetSalary()
        {
            Console.WriteLine("Çalışanlar Maaş Alıyor");
        }

        public void Work()
        {
            Console.WriteLine("Çalışanlar İş Başında");
        }
    }
}
