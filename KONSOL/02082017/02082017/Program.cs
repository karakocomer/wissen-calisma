using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02082017
{
    class Program
    {
        static void Main(string[] args)
        {
            //int sayi1;
            //int toplam=0;
            //int fak=1;
            //Console.WriteLine("sayı giriniz.");
            //sayi1 = Convert.ToInt32(Console.ReadLine());
            //for (int i = 1; i <=sayi1; i++)
            //{
            //    fak = fak * i;

            //}
            //for (int k = 0; k <= sayi1; k++)
            //{
            //    toplam = toplam + k;
            //}
            //Console.WriteLine(" Girdiğiniz sayının faktöriyeli = "+fak);
            //Console.Write(" Girdiğiniz sayıya kadar olan sayıların toplamları = " + toplam);
            /////////////////////////////////////
            //int sayi;
            //int yrakam;
            //Console.Write("Sayı giriniz: ");
            //sayi = Convert.ToInt32(Console.ReadLine());
            //Console.Write("sayını tersi: ");
            //while (sayi>10)
            //{
            //    yrakam = sayi % 10;
            //    Console.Write(yrakam);
            //    sayi /= 10;
            //}
            //Console.WriteLine(sayi);
            ///////////////////////////////////////////////////////
            //int sayi1 = 10;
            //do
            //{
            //    Console.WriteLine(sayi1++);
            //} while (sayi1<=20);
            /////////////////////////////////////////////////
            // Diziler 
            // aynı tipteki verileri tutmak istediğimizde ki bunlar çok ise diziye ihtiyaç duyarız.
            //string[] dizi = { "bir", "iki", "üç", "dört" };
            //int[] dizi2 = { 1, 2, 3, 4, 5 };
            //// dizilerde index sıfırdan başlar 1.eleman aslında 0. elemandır ve sonuncu eleman (sonuncu-1). elemandır.
            ////dizi[4];
            //int[] diziler = new int[10]; //10 dizinin eleman sayısını gösteriyor
            //diziler[0] = 1;
            ////.......
            //diziler[9] = 10;
            //for (int i = 1; i < dizi.Length; i++) // dizinin uzunlugu kadar döngüde kalır
            //    foreach (int sayi in diziler) // dizilerin içerisinde dön sayi değikeni ile yapılacak işlemleri yap
            //        Array.Reverse(diziler); // dizide ki elemanları tersten yazmamıza yarıyor
            //        Array.Sort(diziler) diziyi küçükten büyüğe doğru sıralar.
            //int[] dizi = new int[5];
            //dizi[0] = 1;
            //dizi[1] = 3;
            //dizi[2] = 2;
            //dizi[3] = 7;
            //dizi[4] = 4;


            //Array.Sort(dizi);
            //Array.Reverse(dizi);
            //for (int i = 0; i < dizi.Length; i++)
            //{
            //    Console.WriteLine(dizi[i]);
            //}
            ////////////////////////////////////////////////////////////////////////
            //int sayi=0;
            //Console.WriteLine("Eleman sayısını giriniz");
            //sayi = Convert.ToInt32(Console.ReadLine());
            //string[] ogrenci = new string[sayi];
            //// kullanıcıdan aldıgımız sayı ile diziyi oluşturdum. şimdi eleman eklemesini sağlamak istiyorum
            //// bunun için bir for a ihtiyacım var 0 dan başlayıp dizinin Length i kadar dönecek
            //for (int i = 0; i <ogrenci.Length ; i++)
            //{
            //    Console.WriteLine("Eleman giriniz");
            //    ogrenci[i] = Console.ReadLine();
            //}
            //for (int i = 0; i <ogrenci.Length ; i++)
            //{
            //    Console.WriteLine("oluşturduğunuz dizinin elemanları = " + ogrenci[i]); // yan yana yazmasını nasıl saglarım  
            //}
            /////////////////////////////////
            //int sayi;
            //int sayac = 0;
            //Console.WriteLine("Bir sayı giriniz");
            //sayi = Convert.ToInt32(Console.ReadLine());
            //int[] dizi = { 3, 5, 7, 6, 8, 8, 8, 7, 12, 19, 49 ,49 ,49 ,51 };

            //for (int i = 0; i < dizi.Length; i++)
            //{
            //    if (dizi[i] == sayi)
            //    {
            //        sayac++;
            //    }
            //}
            //    if (sayac==0)
            //    {
            //        Console.WriteLine("Girdiğiniz sayı dizinin içinde yok");

            //    }
            //    else
            //    {
            //    //Console.WriteLine("Girdiğiniz sayı dizinin içinde " + sayac + " tane var");
            //    Console.WriteLine("Girdiğiniz sayı dizinin içinde {0} tane var" ,sayac);
            //}
            int sayac = 0;
            string kelime;

            Console.WriteLine("ingilizce bir kelime yazınız");
            kelime = Console.ReadLine();   
            string[] dizi = { "a", "e", "i", "ı", "o", "ö", "ü", "u" };
            foreach (string i in dizi)
            {
                if (dizi[i] == kelime)
                {
                    sayac++;
                }

                if (sayac == 0)
                {
                    Console.WriteLine("Girdiğiniz kelime içerisinde sesli harf yoktur.");

                }
                else
                {
                    Console.WriteLine("Girdiğiniz sayı dizinin içinde {0} tane sesli harf var", sayac);
                }

            }

            Console.ReadKey();
        }
          }
           }
