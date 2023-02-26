using System;

namespace InterfaceDeneme
{
    class Program
    {
        static void Main(string[] args)
        {
            ManagerDal managerDal = new ManagerDal();

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
            managerDal.Add(new OracleDatabaseDal(), new SqlDatabaseDal());
            
        }
    }
}
