using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            IKrediManager ihtiyaçKrediManager = new İhtiyaçKrediManager();
          
           IKrediManager taksitKrediManager = new TaksitKrediManager();
           
            IKrediManager konutKrediManager = new KonutKrediManager();

            ILoggerService databaseLoggerService = new DataBaseLoggerService();

            ILoggerService fileLoggerService = new FileLoggerService();

            BasvuruManager basvurumanager = new BasvuruManager();
           basvurumanager.BasvuruYap(ihtiyaçKrediManager,databaseLoggerService);

            List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyaçKrediManager };

          //  basvurumanager.KrediOnBilgilendirmeYap(krediler);
                 



        }
    }
}
