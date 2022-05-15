using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Manav
{


    class manav
    {
        toptanci toptanci_1 = new toptanci();
        public List<string> manavUrunMeyve = new List<string>()
        {

        };
        public List<double> mavavUrunMeyveKg = new List<double>()
        {
            
        };
        public List<string> manavUrunSebze = new List<string>()
        {

        };
        public List<double> mavavUrunSebzeKg = new List<double>()
        {

        };
        public string userName = "enes4318";
        public string password = "enes";
        public bool sifreKontrol(string x, string y)
        {
            Console.WriteLine("Kullanıcı Adınızı Giriniz:");
            string userNameGelen = Console.ReadLine();
            Console.WriteLine("Şifrenizi Giriniz:");
            string passwordGelen = Console.ReadLine();

            if (userNameGelen == x && passwordGelen == y)
            {
                Console.WriteLine("Giriş Başarılı");
                return true;
            }
            else
            {
                return false;
            }
        }
        public void tercihListele()
        {
            Console.WriteLine("Toptancıdan Ürün Al :1\nÜrün Listele        :2\nAnamenüye Dön       :3\nLütfen Seçimizi Yapınız...");
        }

        public int tercih()
        {
            Console.WriteLine("Meyve  :1\nSebze  :2\nGeri   :3\nLütfen Seçiminizi Yapınız.");
            int secim2 = Convert.ToInt32(Console.ReadLine());
            return secim2;
        }
        public void urunEklemeMeyve()
        {
            bool devam = true;
            while (devam)
            {
                Console.WriteLine("Lütfen Eklemek İstediğiniz Ürünün Numarasını Giriniz:");
                int indexNo = Convert.ToInt32(Console.ReadLine());
                if (manavUrunMeyve.Contains(toptanci_1.urunlerMeyve[indexNo-1]))
                {
                    //olan bir Ürünü ikinci defa eklemez sadece kg Değeri Yükselir.
                    Console.WriteLine("Kaç Kilo Eklemek İstersiniz:");
                    double kgBilgisi = Convert.ToInt32(Console.ReadLine());
                    mavavUrunMeyveKg[indexNo - 1] += kgBilgisi;
                }
                else
                {
                    manavUrunMeyve.Add(toptanci_1.urunlerMeyve[indexNo - 1]);
                    Console.WriteLine("Kaç Kilo Eklemek İstersiniz:");
                    double kgBilgisi = Convert.ToInt32(Console.ReadLine());
                    mavavUrunMeyveKg.Add(kgBilgisi);
                }
                Console.WriteLine("Satın Alma İşlemine Devam Etmek İçin (1) Satın Alma İşleminden Çıkmak İçin (2) Tuşlayınız.");
                int cikis1 = Convert.ToInt32(Console.ReadLine());
                if (cikis1==1)
                {
                    devam = true;
                }
                else if (cikis1==2)
                {
                    devam = false;
                }
                else
                {
                    devam = false;
                }
            }
            
        }
        public void urunEklemeSebze()
        {
            bool devam = true;
            while (devam)
            {
                Console.WriteLine("Lütfen Eklemek İstediğiniz Ürünün Numarasını Giriniz:");
                int indexNo = Convert.ToInt32(Console.ReadLine());
                if (manavUrunSebze.Contains(toptanci_1.urunlerSebze[indexNo - 1]))
                {
                    Console.WriteLine("Kaç Kilo Eklemek İstersiniz:");
                    double kgBilgisi = Convert.ToInt32(Console.ReadLine());
                    mavavUrunSebzeKg[indexNo - 1] += kgBilgisi;
                }
                else
                {
                    manavUrunSebze.Add(toptanci_1.urunlerSebze[indexNo - 1]);
                    Console.WriteLine("Kaç Kilo Eklemek İstersiniz:");
                    double kgBilgisi = Convert.ToInt32(Console.ReadLine());
                    mavavUrunSebzeKg.Add(kgBilgisi);
                }
                Console.WriteLine("Satın Alma İşlemine Devam Etmek İçin (1) Satın Alma İşleminden Çıkmak İçin (2) Tuşlayınız.");
                int cikis1 = Convert.ToInt32(Console.ReadLine());
                if (cikis1 == 1)
                {
                    devam = true;
                }
                else if (cikis1 == 2)
                {
                    devam = false;
                }
                else
                {
                    devam = false;
                }
            }

        }
        public void manavListeleMeyve()
        {
            for (int i = 0; i < manavUrunMeyve.Count; i++)
            {
                Console.WriteLine("{0} ", (i + 1) + " " + manavUrunMeyve[i]);
            }
        }
        public void manavListeleSebze()
        {
            for (int i = 0; i < manavUrunSebze.Count; i++)
            {
                Console.WriteLine("{0} ", (i + 1) + " " + manavUrunSebze[i]);
            }
        }

    }
}
