using System;

using 
    
    
    System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace üçgensayi
{
    //kullanıcıdan en fazla 4basamaklı ve pozitif bir sayı girmesini isteyiniz.*
    //girilen sayı ilgili koşulları sağlayana kadar tekrar girişi isteyiniz.*
    //daha sonra girilen sayının üçgensel sayı olup olmadığını bulan kodu yazınız.
    //ekran çıktısı 15 üçgen sayıdır veya 22 üçgen sayı değildir şeklinde olmalıdır.*
    //üçgen sayı:1den n'ye kadar ardışık doğal sayıların toplamını veren sayılardır.(n*(n+1))/2 şeklinde yazılır.
    //örn:15 üçgen sayıdır.5'e kadar olan sayma sayıları toplamı:1+2+3+4+5=15*
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("bir sayı giriniz");
             int sayi1 = Convert.ToInt32(Console.ReadLine());
            int basamak = 0;
            int sayi2 = sayi1;
            int sayı = 1;
            int toplam = 0;
            while (sayi1 > 0)
            {
                sayi1/ = 10;
                basamak ++;
            }
            Console.WriteLine("basamak sayısı:" + basamak);
            if (basamak >= 5 && sayi2<0)
            {
                Console.WriteLine("tekrar sayı giriniz");
                sayi1 = Convert.ToInt32(Console.ReadLine());
            }
            if (basamak < 5 && sayi2>0)
            {
                Console.WriteLine("basamak şartını sağlıyor, devam ediniz");
            }

            while (toplam < sayi2) 
            {
                toplam = toplam + sayı;
                sayı++;
              
            }
           if(toplam==sayi2)
            {
                Console.WriteLine(sayi2+ "üçgen sayıdır");

            }
            if(toplam!=sayi2)
            {
                Console.WriteLine(sayi2+ "üçgen sayı değildir");
            }
           
        }
    }
}
