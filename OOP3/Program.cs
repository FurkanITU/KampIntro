using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            ICreditManager ıhtitacCreditManager = new IhtitacCreditManager();
           
            ICreditManager tasitCreditManager = new TasitCreditManager();
            
            ICreditManager konutKreditManager = new KonutKreditManager();


            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(tasitCreditManager,databaseLoggerService);

            List<ICreditManager> krediler = new List<ICreditManager>() {ıhtitacCreditManager,tasitCreditManager };

            basvuruManager.CrediOnbilgilendirmesiYap(krediler);


        }
    }
}
