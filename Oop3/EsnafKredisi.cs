using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop3
{
    internal class EsnafKredisi : IKrediManager
    {
        public void BiseyYap()
        {
            throw new NotImplementedException();
        }

        public void Hesapla()
        {
            Console.WriteLine("esnaf kredisi hesaplandi");
        }

        public void Log()
        {
            throw new NotImplementedException();
        }
    }
}
