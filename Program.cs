namespace Donguler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            //kötü yöntem
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Hello, World!");

            Console.WriteLine("--------------------------------");

            //iyi yöntem 1
            int sayac = 0;
            while(sayac < 10)
            {
                Console.WriteLine((sayac + 1) + " - Hello, World!");
                sayac++;
            }

            Console.WriteLine("--------------------------------");

            //iyi yöntem 2
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Hello, World!");
            }
            */

            //------------------------------------
            //0-100 arası çift sayılar

            //for (int i = 0; i < 100; i++)
            //{
            //    if(i % 2 == 0)
            //        Console.WriteLine(i);
            //}

            //for (int i = 0; i < 100; i+=2)
            //{
            //    Console.WriteLine(i);
            //}
            //10 -> 10, 20 -> 30, 5 -> 35

            //int toplam = 0;
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.Write("Lütfen " + (i + 1) + ". sayıyı giriniz: ");
            //    int ekrandanOkunanSayi = Convert.ToInt32(Console.ReadLine());

            //    toplam += ekrandanOkunanSayi;

            //    Console.WriteLine("Toplam: " + toplam);

            //    //tekrar sayı girmek istiyor musunuz?
            //    //e dersek devam etsin, h dersek dursun
            //}

            //string devamEt = "e";
            //int toplam = 0;
            //while (devamEt == "e")
            //{
            //    Console.Write("Lütfen bir sayı giriniz: ");

            //    int ekrandanOkunanSayi = Convert.ToInt32(Console.ReadLine());
            //    toplam += ekrandanOkunanSayi;

            //    Console.WriteLine("Toplam: " + toplam);
            //    Console.Write("Devam etmek istiyor musunuz? ");
            //    devamEt = Console.ReadLine();
            //}

            //string devamEt;
            //int toplam = 0;

            //do
            //{
            //    Console.Write("Lütfen bir sayı giriniz: ");

            //    int ekrandanOkunanSayi = Convert.ToInt32(Console.ReadLine());
            //    toplam += ekrandanOkunanSayi;

            //    Console.WriteLine("Toplam: " + toplam);
            //    Console.Write("Devam etmek istiyor musunuz? ");
            //    devamEt = Console.ReadLine();
            //} while (devamEt == "e");

            //verilen karakter kadar ekrana sayı yaz

            //string yazi = "asdasdaa";
            ////yazi.Length

            ////1
            ////2
            ////3
            ////4
            ////5
            ////6
            ////7
            ////8
            ////9
            ////10

            //for (int i = 1; i <= yazi.Length; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //-----------------------------------
            //tek-cift sayılar toplamı

            //int tekSayilarToplami = 0, ciftSayilarToplami = 0;
            //for (int i = 0; i < 100; i++)
            //{
            //    if (i % 2 == 0)
            //        ciftSayilarToplami += i;
            //    else
            //        tekSayilarToplami += i;
            //}

            //Console.WriteLine("Tek sayılar toplamı: " + tekSayilarToplami + ", Çift sayılar toplamı: " + ciftSayilarToplami);
            //Console.Read();

            //continue - bir sonraki döngü adımına geçer
            //for (int i = 1; i <= 10; i++)
            //{
            //    if (i % 2 != 0)
            //        continue;

            //    Console.WriteLine(i);
            //}

            //break -  döngüden çıkar

            //for (int i = 0; i < 10; i++)
            //{
            //    if (i == 5)
            //        break;

            //    Console.WriteLine(i);
            //}
        }
    }
}