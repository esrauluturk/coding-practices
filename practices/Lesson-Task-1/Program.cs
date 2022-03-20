using System;

namespace Lesson_Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Alıştırma 1 : Faktöriyel Hesaplama
            // Console.Write("Lütfen bir sayı giriniz : ");
            // Console.WriteLine(Factorial(Convert.ToInt32(Console.ReadLine())));


            // Alıştırma 2: Girilen Sayinin Asal Olup Olmadigini Bulma
            // int count = 0;
            // Console.Write("Sayı Giriniz : ");
            // int number = Convert.ToInt32(Console.ReadLine());
            // int i = 2;
            // while (i < number / 2)
            // {
            //     Console.WriteLine(number / 2);
            //     if (number % i == 0)
            //         count++;

            //     i++;
            // }

            // if (count != 0)
            //     Console.WriteLine("Girdiğiniz sayı asal değildir.");
            // else
            //     Console.WriteLine("Girdiğiniz sayı asaldır.");


            //Alıştırma 3: 1 – 10.000 Arasındaki Asal Sayıları Listeleme
            // int check = 0, nCount = 0, k = 2;
            // do
            // {
            //     check = 0;
            //     int m = 2;
            //     while (m <= k / 2)
            //     {
            //         if (k % m == 0)
            //         {
            //             check++;
            //             break;
            //         }
            //         m++;
            //     }
            //     if (check == 0)
            //     {
            //         nCount++;
            //         Console.Write(k + "-");
            //     }
            //     k++;

            // } while (k < 10000);

            // Console.WriteLine();
            // Console.WriteLine("{0} adet asal sayı bulundu.", nCount);


            // Alıştırma : Fibonacci
            Console.Write("Bir sayı giriniz : ");
            int num = Int32.Parse(Console.ReadLine());
            for (int i = 0; i <= num; i++)
                Console.WriteLine(Fibonacci(i));
        }
        public static int Factorial(int number)
        {

            if (number <= 1)
            {
                return 1;
            }

            return number * Factorial(number - 1);
        }

        public static int Fibonacci(int number)
        {
            if (number == 0)

                return 0;

            else if (number == 1)

                return 1;

            return Fibonacci(number - 1) + Fibonacci(number - 2);
        }
    }
}
