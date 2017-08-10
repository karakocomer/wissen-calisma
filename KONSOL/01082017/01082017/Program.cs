using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01082017
{
    class Program
    {
        private static int sayitahmin;

        static void Main(string[] args)
        {
            //int toplam = 0;
            //for (int i = 0; i < 100; i++)
            //{
            //    toplam += i
            //}
            //Console.WriteLine(toplam);
            //**************************************************************
            //int toplam = 0;
            //int i = 0;
            //while (i<=100)
            //{
            //    toplam += i;
            //    i++;
            //}
            //Console.WriteLine("0 ile 100 arasındaki sayıların toplamı (100 dahil) = " +toplam);
            //*****************************************************************
            // do-while da her türlü döngüye 1 kere giriyor while dan farı budur.
            // do varsa while kısmında olumsuz ifade verilr(genellikle)
            // /*/do {
            //* yapılacak işlemler
            //* yapılacak işlemler
            //* }whie(koşul)
            // do döngü, while bitiren, while dakoşul vardır.
            //************************************************************************
            //int sayi = 1;
            //do
            //{
            //    Console.WriteLine(sayi);
            //    sayi++;
            //} while (sayi<=10);
            //****************************************************************************

            //string sifre;
            //do
            //{
            //    Console.WriteLine("şifreyi giriniz");
            //    sifre = Console.ReadLine();
            //}
            //while (sifre != "user");
            //Console.WriteLine("Giriş başarılı HOŞGELDİNİZ.");
            //*********************************************************************************
            ////random rastgele sayı üretme
            //Random rnd = new Random();
            //int sayi = rnd.Next(0, 50); // son sayıyı dahil etmiyor 
            //Console.WriteLine(sayi);
            //*******************************************************************
            //Random rnd = new Random();
            //int sayac = 0;
            //int sayitahmin;
            //int sayibilgisayar = rnd.Next(0, 11);
            //Console.WriteLine("sayı giriniz");
            //do
            //{
            //    sayitahmin = Convert.ToInt32(Console.ReadLine());
            //    if (sayitahmin > sayibilgisayar)
            //    {
            //        Console.WriteLine("Tekrar deneyiniz,sayı büyük");
            //    }
            //    else if (sayitahmin < sayibilgisayar)
            //    {
            //        Console.WriteLine("Tekrar deneyiniz,sayı küçük");
            //    }
            //    sayac++;
            //} while (sayitahmin != sayibilgisayar);
            //Console.WriteLine("doğru tahmin ettiniz " + sayac + ".tahminde bildiniz.");

            //Random rnd = new Random();
            //int sayac = 0;
            //int sayitahmin=0;
            //int hak = 5;
            //int sayibilgisayar = rnd.Next(0, 11); 
            //while (sayitahmin != sayibilgisayar && hak != 0)         
            //    {sayac++; 
            //    Console.WriteLine("sayı giriniz");
            //    sayitahmin = Convert.ToInt32(Console.ReadLine());
            //    if (sayitahmin > sayibilgisayar)
            //        {
            //            Console.WriteLine("Tekrar deneyiniz,sayı büyük");
            //        hak--;
            //        Console.WriteLine("kalan hak sayınız" +hak);       
            //    }
            //        else if (sayitahmin < sayibilgisayar)
            //        {
            //            Console.WriteLine("Tekrar deneyiniz,sayı küçük");
            //        hak--;
            //        Console.WriteLine("kalan hak sayınız" + hak);
            //    }    
            //    }  
            //if (hak==0)
            //{
            //    Console.WriteLine( "hakkınız tükendi");
            //}
            //else if (sayibilgisayar==sayitahmin)
            //{
            //    Console.WriteLine("doğru tahmin ettiniz " + sayac + ".tahminde bildiniz.");
            //}
            //// sonda ki sıkıntıyı nasıl aşabiliriz aybars ????

            //while kullanarak faktöriyel hesaplama
            // kullanıcı bir sayı giriyor ve faktöriyel hesaplatıp ekrana yazdırıyoruz
            //Console.WriteLine("Bir sayı giriniz.");
            //int sayi = Convert.ToInt32(Console.ReadLine());
            //int sonuc = 1;
            //while (sayi>1)
            //{
            //    sonuc = sonuc * sayi;
            //    sayi--;

            //}
            //Console.WriteLine("Sonuç: " +sonuc);
            // enesin kodu***********************************************
            int hak = 5, girilen, rsayi;
            Random r = new Random();
            rsayi = r.Next(1, 10);
            while (hak > 0)
            {
                Console.Write("Sayı giriniz (1-10)");
                girilen = Convert.ToInt32(Console.ReadLine());
                hak--;
                if (hak == 0)
                {
                    Console.WriteLine("Hakkınız tamamlandı.Sayı bilemediniz. Rastgele üretilen sayı=" + rsayi);
                    break;
                }
                if (girilen > rsayi)
                {
                    Console.WriteLine("Aşağı Kalan tahmin hakkınız>> " + hak);
                }
                else if (girilen < rsayi)
                {
                    Console.WriteLine("Yukarı Kalan tahmin hakkınız>> " + hak);
                }

                else
                {
                    Console.WriteLine("Tebrikler , bildiniz...");
                    break;
                }
            }
            Console.ReadKey(); 
            }
        }
    }

