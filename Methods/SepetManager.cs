using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class SepetManager
    {
        //naming convention
        //syntax
        public void Ekle(Product product)
        {
            Console.WriteLine("Sepete eklendi:" + product.Name);

        }
        public void Ekle2(string Name,string Explain,double Price,int Stock)
        {
            Console.WriteLine("Sepete eklendi:" + Name);
        }


    }
}

