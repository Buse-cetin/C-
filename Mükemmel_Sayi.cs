using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mükemmel_sayi
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi;
            Console.WriteLine("bir sayı giriniz ");
            sayi = Convert.ToInt32(Console.ReadLine());
            string bolenler = "";
            int toplam = 0;
            for (int i = 1; i <= sayi / 2; i++) 
            {
                if (sayi % i == 0)
                {
                    bolenler += i.ToString() + "+";
                    toplam = toplam + i;

                }
                    
            }
            if (sayi == toplam)
            {
                Console.WriteLine(sayi + "mükemmel sayıdır");

            }
            else
            {
                Console.WriteLine(sayi + "mükemmel sayı değildir");
            }
            Console.Write(bolenler);
            Console.WriteLine("=" + toplam);
            Console.ReadLine();


                
        }

    }
}
