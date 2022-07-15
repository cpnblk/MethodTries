using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop1
{
    //prop tabtab yaparsan öz olşr buna snippet diyoruz
    internal class Product //entity
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public double UnitPrice { get; set; }
        public int UnitInStock { get; set; }

        //crud opları veritabanı programlama ile olur 
        //e ticaret siteleri
        //create read update delete 

    }
}
