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


            ApplicationManager applicationManager = new ApplicationManager();
            applicationManager.ApplicationMake(needCrediManager, dataloggerService);


            List<ICreditManager> credits = new List<ICreditManager>() {needCrediManager,vecihleCrediManager };

            //applicationManager.Crediİnfo(credits);

        }
    }
}
