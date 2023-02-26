using System;

namespace InterfaceDeneme
{
    class Program
    {
        static void Main(string[] args)
        {
            ManagerDal managerDal = new ManagerDal();
            //verileri dizi aktarıp sistemin 2 veritabanına kayıt yapabileceği işlem için dizi tanımlama interface ile
            ICustomerDal[] customerDals = new ICustomerDal[2]
            {
                new SqlDatabaseDal(),
                new OracleDatabaseDal()
            };
            SchoolService school = new SchoolService();
            Student student = new Student();
            Personal personal = new Personal();
            student.Id = 1;
            student.FirstName = "Numan";
            student.LastName = "ŞEHRİ";
            student.NationalIdenty = "12345678912";
            student.Fakulte = "Mühndislik";

            personal.Id = 2;
            personal.FirstName = "Damla";
            personal.LastName = "ŞEHRİ";



            Console.WriteLine(student.FirstName); 
            school.Add(student);
            school.Add(personal);
            managerDal.Add(new OracleDatabaseDal());
            //diziyi dönerek hangi veri taanlarına kayıt yapıldığını fırlatıyotuz
            foreach (var data in customerDals)
            {
                managerDal.Add(data);
            }
            
        }
    }
}
