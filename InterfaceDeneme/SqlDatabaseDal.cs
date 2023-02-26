using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceDeneme
{
    class SqlDatabaseDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Sql Veritabanına Kayıt Edildi");
        }

        public void Delete()
        {
            Console.WriteLine("Sql Veritabanından Silindi");
        }

        public void Update()
        {
            Console.WriteLine("Sql Veritabanından Güncellendi");
        }
    }
}
