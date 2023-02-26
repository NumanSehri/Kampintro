using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceDeneme
{
    class OracleDatabaseDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Oracle Veritabanına Kayıt Edildi");
        }

        public void Delete()
        {
            Console.WriteLine("Oracle Veritabanında Silindi");
        }

        public void Update()
        {
            Console.WriteLine("Oracle Veritabanından Güncellendi");
        }
    }
}
