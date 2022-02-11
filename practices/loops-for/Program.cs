using System;

namespace loops_for
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ekrandan girilen sayıya kadar olan tek sayıları ekrana yazdır
            Console.Write("Lütfen bir sayi giriniz: ");
            int counter = int.Parse(Console.ReadLine());
            for (int i = 1; i <= counter; i++)
            {
                if (i % 2 == 1)
                    Console.WriteLine(i);
            }

            //1 ve 1000 arasındaki tek ve cift sayilarin kendi iclerinde toplamlarini ekrana yazdir.
            int oddSum = 0;
            int evenSum = 0;
            for (int i = 1; i <= 1000; i++)
            {
                if (i % 2 == 1)
                    oddSum += i;
                else
                    evenSum += i;
            }
            Console.WriteLine("Tek Toplam: " + oddSum);
            Console.WriteLine("Çift Toplam: " + evenSum);


            //break - continue
            /*Break ifadesi döngü içerisinden çıkmak istenildiğinde kullanılır.
            *İç içe döngüler kullanıldığında break ifadesi yalnızca içinde bulunduğu ilk döngüyü sonlandırır.
            *Continue
            *Kullanım amacı break ifadesine benzer ama continue sadece mevcut iterasyonu sonlandırır. Döngü bir sonraki iterasyondan devam eder.
            *for(;;) // Sonsuz döngüyü ifade eder. 
            */

            //Break

            for (int i = 1; i < 10; i++)
            {
                if (i == 4)
                    break;
                Console.WriteLine(i); //1 2 3
            }

            //Continue

            for (int i = 1; i < 10; i++)
            {
                if (i == 4)
                    continue;
                Console.WriteLine(i);//1 2 3 5 6 7 8 9 (4 haric hepsi)
            }

            for (int i = 1; i <= 10; i++)
            {
                if (i % 2 == 0)
                    continue;
                Console.WriteLine(i);//1 ile 10 arasındaki tek sayılar yazdırılacaktır.
            }

        }
    }
}
