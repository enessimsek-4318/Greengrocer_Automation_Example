using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Manav
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**************ENES ŞİMŞEK**************\n***********MANAV UYGULAMASI************");
            manav mnv = new manav();
            toptanci toptan = new toptanci();
            musteri mstr = new musteri();
            bool ciksinMi = true;
            while (ciksinMi)
            {
                Console.WriteLine("Manav Girişi   :1\nMüşteri Girişi :2\nÇıkış          :3\nLütfen Seçimizi Yapınız.");
                int secim1 = Convert.ToInt32(Console.ReadLine());
                if (secim1 == 1)
                {
                    bool kontrol = false;
                    if (mnv.sifreKontrol(mnv.userName, mnv.password))
                    {
                        kontrol = true;
                    }
                    else
                    {
                        hataliGiriş();
                    }
                    while (kontrol)
                    {
                        mnv.tercihListele();
                        int manavSecim = Convert.ToInt32(Console.ReadLine());
                        if (manavSecim == 1)
                        {
                            bool kontrol2 = true;
                            while (kontrol2)
                            {
                                int secim2 = mnv.tercih();
                                if (secim2==1)
                                {
                                    toptan.listeleToptanciMeyve(toptan.urunlerMeyve);
                                    mnv.urunEklemeMeyve();
                                }
                                else if (secim2==2)
                                {
                                    toptan.listeleToptanciSebze(toptan.urunlerSebze);
                                    mnv.urunEklemeSebze();
                                }
                                else if (secim2==3)
                                {
                                    kontrol2 = false;
                                }
                                else
                                {
                                    hataliGiriş();
                                }
                            }
   
                        }
                        else if (manavSecim == 2)
                        {
                            mnv.manavListeleMeyve();
                            Console.WriteLine("**********************");
                            mnv.manavListeleSebze();
                        }
                        else if (manavSecim == 3)
                        {
                            kontrol = false;
                        }
                        else
                        {
                            hataliGiriş();
                        }
                    }
                }
                else if (secim1 == 2)
                {
                    mstr.musteriUrunListeMeyve(mnv.manavUrunMeyve);
                    mstr.musteriUrunListeSebze(mnv.manavUrunSebze);
                    bool döngü = true;
                    while (döngü)
                    {
                        int musteriSecim = mstr.musteriTercih();
                        if (musteriSecim == 1)
                        {
                            mstr.urunAl(mnv.manavUrunMeyve,mnv.mavavUrunMeyveKg,mnv.manavUrunSebze,mnv.mavavUrunSebzeKg);
                        }
                        else if (musteriSecim == 2)
                        {
                            mstr.sepetListele(mstr.sepet);
                        }
                        else if (musteriSecim == 3)
                        {
                            döngü = false;
                        }
                    }
                    
                   
                }
                else if (secim1 == 3)
                {
                    Thread.Sleep(2000);
                    ciksinMi = false;
                }
                else
                {
                    hataliGiriş();
                }
            }

        }

        static void hataliGiriş()
        {
            Console.WriteLine("Eksik veya Hatalı Giriş:");
        }
    }
}
