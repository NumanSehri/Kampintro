using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            ICreditManager needCrediManager = new NeedCrediManager();
            ICreditManager vecihleCrediManager = new VecihleCrediManager();
            ICreditManager houseCrediManager = new HouseCrediManager();

            ILoggerService dataloggerService = new DatabseLoggerService();
            ILoggerService fileLogerService = new FileLoggerService();


            List<ILoggerService> loggerServices=new List<ILoggerService>() { new DatabseLoggerService(), new SmsLoggerService()};

            ApplicationManager applicationManager = new ApplicationManager();
            applicationManager.ApplicationMake(new EsnafKredisi(), loggerServices);


            List<ICreditManager> credits = new List<ICreditManager>() {needCrediManager,vecihleCrediManager };

            //applicationManager.Crediİnfo(credits);

        }
    }
}
