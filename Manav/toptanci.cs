using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manav
{
    class toptanci
    {
        public List<string> urunlerMeyve = new List<string> { "Elma", "Armut", "Kiraz", "Muz", "Çilek", "Şeftali", "Vişne", "Mango", "Üzüm" };
        public List<string> urunlerSebze = new List<string> { "Soğan", "Sarımsak", "Biber", "Salatalık", "Domates", "Patlıcan", "Patates","Pırasa","Kabak" };

        public void listeleToptanciMeyve(List<string> x)
        {
            for (int i = 0; i < urunlerMeyve.Count; i++)
            {
                Console.WriteLine("{0} ", (i + 1) + " " + urunlerMeyve[i]);
            }
        }
         public void listeleToptanciSebze(List<string> x)
        {
            for (int i = 0; i < urunlerSebze.Count; i++)
            {
                Console.WriteLine("{0} ", (i + 1) + " " + urunlerSebze[i]);
            }
        }


    }
}
