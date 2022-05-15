using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manav
{
    class musteri
    {
        manav manav = new manav();
        public List<string> sepet = new List<string>
        {

        };
        public void musteriUrunListeMeyve(List<string> liste)
        {
            Console.WriteLine("*****MEYVE*****");
            for (int i = 0; i < liste.Count; i++)
            {
                Console.WriteLine("{0} ", (i + 1) + " " + liste[i]);
            }
        }
        public void musteriUrunListeSebze(List<string> liste)
        {
            Console.WriteLine("*****SEBZE*****");
            for (int i = 0; i < liste.Count; i++)
            {
                Console.WriteLine("{0} ", (i + 1) + " " + liste[i]);
            }
        }
        public int musteriTercih()
        {
            Console.WriteLine("Alışveriş Yap :1\nSepetim       :2\nAnamenü       :3");
            int musteriTercih1 = Convert.ToInt32(Console.ReadLine());
            return musteriTercih1;
        }
        public void sepetListele(List<string> x)
        {
            Console.WriteLine("*****SEPETİNİZ*****");
            for (int i = 0; i < x.Count; i++)
            {
                Console.WriteLine("{0} ", (i + 1) + " " + x[i]);
            }
        }
        public void urunAl(List<string> x,List<double> y, List<string> a, List<double> b)
        {
            Console.WriteLine("Meyve :1\nSebze :2\nGeri  :3");
            int musterisecim = Convert.ToInt32(Console.ReadLine());
            if (musterisecim==1)
            {
                bool devam = true;
                while (devam)
                {
                    Console.WriteLine("Lütfen Almak İstediğiniz Ürünün Numarasını Giriniz:");
                    int indexNo = Convert.ToInt32(Console.ReadLine());
                    if (sepet.Contains(x[indexNo - 1]))
                    {
                        //burası eğer sepete daha önce aynı ürünü eklemiş ise iki kere yazdırması önlenmiştir.
                        Console.WriteLine("Kaç Kilo Almak İstersiniz:");
                        double kgBilgisi = Convert.ToInt32(Console.ReadLine());
                        y[indexNo - 1] -= kgBilgisi;
                        if (y[indexNo - 1] <= 0)
                        {
                            Console.WriteLine("Ürün Tükenmiştir.");
                            x.RemoveAt(indexNo - 1); // Ürün bitmişse listeden kaldırılacaktır.
                        }
                    }
                    else
                    {
                        sepet.Add(x[indexNo - 1]);
                        Console.WriteLine("Kaç Kilo Eklemek İstersiniz:");
                        int kgBilgisi = Convert.ToInt32(Console.ReadLine());
                        y[indexNo - 1] -= kgBilgisi;
                        if (y[indexNo - 1] <= 0)
                        {
                            Console.WriteLine("Ürün Tükenmiştir.");
                            x.RemoveAt(indexNo - 1); // Ürün bitmişse listeden kaldırılacaktır.
                            
                        }
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
            else if (musterisecim==2)
            {
                bool devam = true;
                while (devam)
                {
                    Console.WriteLine("Lütfen Almak İstediğiniz Ürünün Numarasını Giriniz:");
                    int indexNo = Convert.ToInt32(Console.ReadLine());
                    if (sepet.Contains(a[indexNo - 1]))
                    {
                        //burası eğer sepete daha önce aynı ürünü eklemiş ise iki kere yazdırması önlenmiştir.
                        Console.WriteLine("Kaç Kilo Almak İstersiniz:");
                        double kgBilgisi = Convert.ToInt32(Console.ReadLine());
                        b[indexNo - 1] -= kgBilgisi;
                        if (b[indexNo - 1] <= 0)
                        {
                            Console.WriteLine("Ürün Tükenmiştir.");
                            a.RemoveAt(indexNo - 1); // Ürün bitmişse listeden kaldırılacaktır.
                            
                        }
                    }
                    else
                    {
                        sepet.Add(a[indexNo - 1]);
                        Console.WriteLine("Kaç Kilo Eklemek İstersiniz:");
                        int kgBilgisi = Convert.ToInt32(Console.ReadLine());
                        b[indexNo - 1] -= kgBilgisi;
                        if (b[indexNo - 1] <= 0)
                        {
                            Console.WriteLine("Ürün Tükenmiştir.");
                            a.RemoveAt(indexNo - 1); // Ürün bitmişse listeden kaldırılacaktır.
                            
                        }
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
            
        }
    }
}
