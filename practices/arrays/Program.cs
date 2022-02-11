using System;

namespace arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dizideki elemanların veri tipleri aynı olur.
            //Dizi Tanımlama
            string[] bookNames = new string[5];

            string[] colors = { "green", "blue", "yellow", "pink" };

            int[] arr;
            arr = new int[5];

            //Dizilere Deger Atama ve Erisim
            bookNames[0] = "Anna Karenina";
            arr[4] = 23;

            Console.WriteLine(colors[2] + " " + bookNames[0] + " " + arr[4]);

            //Döngülerle Dizi Kullanımı
            //Klavyeden girilen n tane sayının ortalamasını hesaplayan program
            Console.Write("Lütfen dizinin eleman sayısını giriniz :");
            int arrLength = int.Parse(Console.ReadLine());
            int[] numberArr = new int[arrLength];
            for (int i = 0; i < arrLength; i++)
            {
                Console.Write("Lütfen {0}.sayıyı giriniz: ", i + 1);
                numberArr[i] = int.Parse(Console.ReadLine());// ReadLine string döner.
            }

            int sum = 0;
            foreach (var number in numberArr)
                sum += number;
            Console.WriteLine("Ortalama : " + sum / arrLength);
        }
    }
}
