using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class ApplicationManager
    {   //Method Injection - İnterface aracılığı ile seçilen veriden gelene göre işlem yapılacak
        public void ApplicationMake(ICreditManager creditManager, ILoggerService loggerService)
        {
            //Başvuru Bilgileri Değerlendirme
            //ortak class kullanılır toplu hükmetmek için
            ICreditManager houseCrediManager = new HouseCrediManager();
            creditManager.Calculater();
            loggerService.Log();
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
