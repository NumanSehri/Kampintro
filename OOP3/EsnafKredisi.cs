using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class EsnafKredisi : ICreditManager
    {
        public void BiseyYap()
        {
            throw new NotImplementedException();
        }

        public void Calculater()
        {
            Console.WriteLine("Esnaf Kredisi Hesaplandı");
        }
    }
}
