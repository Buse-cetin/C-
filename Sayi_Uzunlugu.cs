using System;

namespace ödev9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("bir sayı giriniz");
            long sayi = long.Parse(Console.ReadLine());
            int uzunluk = 0;
            while (sayi != 0)
            {
                sayi /= 10;
                uzunluk++;
            }
            Console.WriteLine("girdiğiniz sayı{0} basamaklıdır", uzunluk);

            if (uzunluk == 3) ;
            long onlar, yüzler, birler;
            yüzler = sayi / 100;
            sayi = sayi % 100;
            onlar = sayi / 10;
            birler = sayi % 10;
            long sonuc;
            sonuc = (yüzler ^ 2 + onlar ^ 2 + birler ^ 2);
            Console.WriteLine("girilen sayının basamak kareleri toplamı=" + sonuc);

            if (uzunluk == 4 && sayi % 4 == 0) ;

            Console.WriteLine(sayi + "sayısı 4 ile tam bölünebilir");

            if (uzunluk == 4 && sayi % 4 != 0) ;

            Console.WriteLine(sayi + "sayısı 4 ile tam bölünemez");


            if (uzunluk != 3 && uzunluk != 4) ;

            Console.WriteLine("geçersiz sayı girdiniz");




        }
    }
}
