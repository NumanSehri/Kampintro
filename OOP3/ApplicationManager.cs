using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class ApplicationManager
    {   //Method Injection - İnterface aracılığı ile seçilen veriden gelene göre işlem yapılacak
        public void ApplicationMake(ICreditManager creditManager, List<ILoggerService> loggerServices)
        {
            //Başvuru Bilgileri Değerlendirme
            //ortak class kullanılır toplu hükmetmek için
            //çoklu loglama
            ICreditManager houseCrediManager = new HouseCrediManager();
            creditManager.Calculater();
            foreach (var logerService in loggerServices)
            {
                logerService.Log();
      
            }
        }
        //Kredileri List' tutacak- liste verileri IcrediManagerden gelecek
        public void Crediİnfo(List<ICreditManager>credits)
        {
            foreach (var credi in credits)
            {
                credi.Calculater();
                
            }
        }
    }
}
