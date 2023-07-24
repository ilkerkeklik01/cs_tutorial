using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal class BasvuruManager
    {

        //Method injection
        public void BasvuruYap(IKrediManager krediManager,params ILoggerService[] loggerServices)
        {
            //Basvuran bilgilerini değerlendirme
            //
            /*
            KonutKrediManager konutKrediManager = new KonutKrediManager();
            konutKrediManager.Hesapla();
        
            */

            krediManager.Hesapla();
            foreach (var service in loggerServices)
            {
                service.Log();
            }


            }

        public void KrediOnBilgilendirmesiYap(List<IKrediManager> list)
        {
            foreach(IKrediManager each in list)
            {
                each.Hesapla();
            }


        }
        

        }

}
