using System;

namespace Oop3
{
    class Program
    {
        static void Main(string[] args)
        {
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            IKrediManager tasitKrediManager = new TasitKrediManager();
            IKrediManager konutKrediManager = new KonutKrediManager();
    

            ILoggerService databaseLoggerService = new DatabaseLoggerService();   
            ILoggerService fileLoggerService = new FileLoggerService(); 
           
            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(new EsnafKredisiManager(), new SmsLogger());
          
            List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyacKrediManager, tasitKrediManager, konutKrediManager, };   
 


        }
    }
}

