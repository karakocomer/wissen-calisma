using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31072017
{
    class Program
    {
        static void Main(string[] args)
        {
            //int a, b ;
            //Console.WriteLine("bir sayı girin.");
            //a = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("bir sayı girin.");
            //b = Convert.ToInt32(Console.ReadLine());
            //for (int i = a+1; i < b; i++)   // girilen sayıları da yazmaması için +1 ekledim
            //    if (i % 4 == 0)
            //    {
            //        Console.WriteLine("4 ün katı olan sayılar= " + i);
            //    }
            //**************************************************************************************************************
            // string cinsiyet ;
            // int kilo, boy;
            // Console.WriteLine("Cinsiyetiniz ? Bay / Bayan.");
            //cinsiyet = Console.ReadLine(); 
            // Console.WriteLine("Boyunuzu cm cinsinden giriniz.");
            // boy = Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine("Kilonuzu giriniz.");
            // kilo = Convert.ToInt32(Console.ReadLine());
            // if (cinsiyet=="Bay")
            // {
            //     Console.WriteLine(" İdeal Kilonuz = " + (boy - 108));
            // }
            // else
            // {
            //     if (cinsiyet == "Bayan") ;
            //     {
            //         Console.WriteLine(" ideal kilonuz = " + (boy - 110));
            //     }    
            // }
            //////////////////////////// switchcase
            //switch (string or integer)
            //{
            //    default:
            //   break;
            //}
            // kullanıcı sayı girsin 1-7 arası hangi gün oldugunu gösterelim
            //***********************************************************************************************
            //Console.WriteLine("1 ile 7 arası sayı giriniz. ");
            //int gun = Convert.ToInt32(Console.ReadLine());
            //switch (gun)
            //{
            //    case 1: // case den sonrak sayı girilen ile aynı ise case in altında kini ekrana yazacak 1 yerine harf te yazabiliriz.
            //        Console.WriteLine("1.Gün Pazartesidir.");
            //        break;
            //    case 2:
            //        Console.WriteLine("2.Gün Salıdır.");
            //        break;
            //    case 3:
            //        Console.WriteLine("3.Gün Çarşambadır.");
            //        break;
            //    case 4:
            //        Console.WriteLine("4.Gün Perşembedir.");
            //        break;
            //    case 5:
            //        Console.WriteLine("5.Gün Cumadır.");
            //        break;
            //    case 6:
            //        Console.WriteLine("6.Gün Cumartesidir.");
            //        break;
            //    case 7:
            //        Console.WriteLine("7.Gün Pazardır.");
            //        break;
            //}
            //***********************************************************************************************
            //Console.WriteLine("Plakasını ögrenmek istediğiniz il i yazınız. ");
            //string il=Console.ReadLine();
            //switch (il)
            //{
            //    case "istanbul":
            //        Console.WriteLine("İstanbulun plakası 34 dür.");
            //        break;
            //    case "ankara":
            //        Console.WriteLine("Ankaranın plakası 06 dır.");
            //        break;
            //    case "muş":
            //        Console.WriteLine("Muşun plakası 49 dur.");
            //        break;
            //    case "yaramış":
            //        Console.WriteLine("yaramış muşun köyüdür muşun plakası da 49 dur.");
            //        break;
            //}
            //****************************************************************************************
            //int alan, cevre, kenar;
            //string islem;
            //Console.WriteLine("Karenin kenarını giriniz.");
            //kenar = Convert.ToInt32(Console.ReadLine ());
            //Console.WriteLine("hesaplamak istediğinizi yazınız alan/çevre");
            //islem = Console.ReadLine();
            //switch (islem)
            //{
            //    case "alan":
            //        alan = kenar * kenar;
            //        Console.WriteLine("Alanı= " +alan);
            //        break;
            //    case "çevre":
            //        cevre = kenar * 4;
            //        Console.WriteLine("Çevresi = " +cevre);
            //        break;      
            //}
            //********************************************************************************
            //int sayi1, sayi2;
            //string islem;
            //Console.WriteLine("Birinci sayıyıgiriniz.");
            //sayi1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("+, - *, /");
            //islem = Console.ReadLine();
            //Console.WriteLine("İkinci sayıyıgiriniz.");
            //sayi2 = Convert.ToInt32(Console.ReadLine());


            //switch (islem)
            //{
            //    case "+":
            //        Console.WriteLine("sonuc = " + (sayi1 + sayi2));
            //        break;
            //    case "-":
            //        Console.WriteLine("sonuc = " + (sayi1 - sayi2));
            //        break;
            //    case "*":
            //        Console.WriteLine("sonuc = " + (sayi1 * sayi2));
            //        break;
            //    case "/":
            //        Console.WriteLine("sonuc = " + (sayi1 / sayi2));
            //        break;
            //}
            //    int ay;
            //    Console.WriteLine("Kaçıncı ayda olduğumuzu giriniz.");
            //    ay = Convert.ToInt32(Console.ReadLine())
            //    switch (ay)
            //    {
            //        case 1:

            //        case 2:

            //        case 3:
            //            Console.WriteLine("kış.");
            //            break;
            //        case 4:

            //        case 5:

            //        case 6:
            //            Console.WriteLine("ilkbahar.");
            //            break;
            //        case 7:

            //        case 8:

            //        case 9:
            //            Console.WriteLine("yaz.");
            //            break;
            //        case 10:

            //        case 11:

            //        case 12:
            //            Console.WriteLine("sonbahar.");
            //            break;

            //    }

            //Console.ReadKey();
            int maas, urun;
            Console.WriteLine("Maaşınızı giriniz");
            maas = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ürettiğini ürün miktarını giriniz.");
            urun = Convert.ToInt32(Console.ReadLine());
            if (1<=urun && urun>=10 )
            {
                Console.WriteLine("maaşınız" + (maas + (urun * 5)));

            }
            else
            {
                if (11<=urun && urun<=25)
                {
                    Console.WriteLine("maaşınız" + (maas + (urun * 11)));
                }
                else
                {
                    if (26 <= urun && urun <= 40)
                    {
                        Console.WriteLine("maaşınız" + (maas + (urun * 17)));
                    }
                    else
                    {
                        if (41 <= urun )
                        {
                            Console.WriteLine("maaşınız" + (maas + (urun * 30)));
                        }
                    }

                }
            }
            Console.ReadKey();
        }
    }

}