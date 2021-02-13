using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {

        public void BasvuruYap( IKrediManager kredimanager,ILoggerService loggerService)
        {
            // basvuran bilgileri degerlendırme
            //

            kredimanager.Hesapla();
           loggerService.Log();
                                                
        }
        public void KrediOnBilgilendirmeYap( List<IKrediManager> krediler)
        {

            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
                    
            }

        }

       
    }
}
