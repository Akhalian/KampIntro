using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            ICreditManager pFCManager = new PersonalFinanceCreditManager();
            ICreditManager vehicleManager = new VehicleCreditManager();
            ICreditManager mortgageManager = new MortgageCreditManager();

            //ILoggerService databaseLoggerService = new DatabaseLoggerService();
            //ILoggerService fileLoggerService = new FileLoggerService();

            ApplicationManager applicationManager = new ApplicationManager();
            applicationManager.MakeApplication(pFCManager, new List<ILoggerService> { new DatabaseLoggerService(), new FileLoggerService() }); //parantez içinde de newleyebilirsin önceden yazmana alternatif olarak.

            List<ICreditManager> credits = new List<ICreditManager>() {pFCManager, vehicleManager };

            //applicationManager.MakeCreditPreInfo(credits);


        }
    }
}
