using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop3
{
    internal class BasvuruManager
    {
        //method injection
        public void BasvuruYap(IKrediManager krediManager, ILoggerService loggerService)
        {
            //basvru bilgileirni degerlendirme
            //
           
            krediManager.Hesapla();
            loggerService.Log();
        }
        //basvuru yapin icine istedigin türde krediMaanager gonderebilirsin
        public void KrediOnBilgilendirnmesiYap(List<IKrediManager>krediler)
        {
            foreach ( var kredi in krediler)
            {
                kredi.Hesapla();
            }
        }
    }
}

//tüm basvurular konut kredisi basvurusu gibi oldu aman dikkat

/*
 * coklu yollasaydık
 * public void BasvuruYap(IKrediManager krediManager, List<ILoggerService> loggerServices)
        {
           
            krediManager.Hesapla();
            foreach ( var logerService in loggerServices ) 
           {
                loggerService.Log();
           }
program.cs de desunu yapıyosun
---yerine---
List<ILoggerService> loggers = new List<ILoggerService> {new SmsLoggerServcie(), new FileLoggerService()}
BasvuruManager basvuruManager = new BasvuruManager();
basvuruManager.BasvuruYap(new EsnafKredisiManager(), loggers));
-----
 
 */