using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatematikMenusu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int islem;
            Console.WriteLine("Matematik Menüsü :)");
            Console.WriteLine();
            Console.WriteLine("1) Aritmetik dört işlem");
            Console.WriteLine("2) Üs alma");
            Console.WriteLine("3) Kök alma");
            Console.WriteLine("4) Karenin çevresi ve alanı");
            Console.WriteLine("5) Dikdörtgen çevresi ve alanı");
            Console.WriteLine("6) Eşkenar üçgen çevresi\n");
            Console.WriteLine("*************\n");
            Console.WriteLine("işlem yapmak istediğiniz alanın numarasını yazın: ");
            islem = Convert.ToInt32(Console.ReadLine());
            if (islem == 1)
            {
                double a, b, toplam, fark, carpim, bolum;
                Console.WriteLine("1. sayıyı giriniz");
                a = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("2. sayıyı giriniz");
                b = Convert.ToDouble(Console.ReadLine());

                toplam = a + b;
                fark = a - b;
                carpim = a * b;
                bolum = a / b;

                Console.WriteLine("Toplam = " + toplam);
                Console.WriteLine("Fark = " + fark);
                Console.WriteLine("Çarpim = " + carpim);
                Console.WriteLine("Bölüm = " + bolum);
                Console.ReadKey();

            }
            if (islem == 2)
            {
                double sayi, us, sonuc;
                Console.WriteLine("sayıyı giriniz");
                sayi = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("üssü sayıyı giriniz");
                us = Convert.ToDouble(Console.ReadLine());
                sonuc = Math.Pow(sayi, us);
                Console.WriteLine("Sonuç = " + sonuc);
                Console.ReadKey();

            }
            if (islem == 3)
            {
                double sayi, kok;
                Console.WriteLine("Kökü alınacak sayıyı giriniz");
                sayi = Convert.ToDouble(Console.ReadLine());
                kok = Math.Sqrt(sayi);
                Console.WriteLine("Sonuç = " + kok);
                Console.ReadKey();

            }
            if (islem == 4)
            {
                int kenar, alan, cevre;
                Console.Write("Kenar değerini giriniz");
                kenar= Convert.ToInt32(Console.ReadLine());
                alan = kenar * kenar;
                cevre = kenar * 4;
                Console.WriteLine("Alanı = " + alan);
                Console.WriteLine("Çevresi = " + cevre);
                Console.ReadKey();

            }
            if (islem == 5) 
            {
                int k1, u1, alan,cevre;
                Console.WriteLine("Kısa kenar değerini giriniz");
                k1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Uzun kenar değerini giriniz");
                u1 = Convert.ToInt32(Console.ReadLine());
                alan = k1 * u1;
                cevre = k1 + u1 +k1 +u1;
                Console.WriteLine("Çevresi = " + cevre);
                Console.WriteLine("Alanı = " + alan);
                Console.ReadKey();

            }
            if (islem == 6)
            {
                int kenar, cevre;
                Console.WriteLine("kenar değerini giriniz");
                kenar = Convert.ToInt32(Console.ReadLine());
                cevre = kenar * 3;
                Console.WriteLine("Çeveresi = " + cevre);
                Console.ReadKey();
            }
        }
    }
}
