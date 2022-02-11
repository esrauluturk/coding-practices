using System;

namespace loops_while_foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            //While
            //1 den baslayarak console dan girilen sayiya kadar (sayi dahil) ortalama hesaplayıp console a yazdıran program
            Console.Write("Lütfen bir sayı giriniz: ");
            int number = int.Parse(Console.ReadLine()); // Parse, string donusumu icin kullanilir.
            int counter = 1;
            int sum = 0;
            while (counter <= number)
            {
                sum += counter;
                counter++;
            }
            Console.WriteLine(sum / number);

            //'a' dan 'z' ye kadar tüm harfleri console'a yazdır.
            char character = 'a';
            while (character < 'z')
            {
                Console.Write(character);
                character++;
            }//abcdefghijklmnopqrstuvwxy

            //Foreach
            Console.WriteLine("****** Foreach ******");
            string[] authors = { "Kafka", "Wolf", "Nietzsche", "Sartre" };
            foreach (var author in authors)
            {
                Console.WriteLine(author);
            }

            //Example - 2
            int[] numberArr = { 2, 4, 5, 1, 2, 4 };
            int arrSum = 0;

            foreach (int i in numberArr)
            {
                arrSum += i;
            }
            //Belirsiz sayıda iterasyona sahip, yalnızca belli bir koşul sağlandığı sürece kullanmamız gereken döngü while'dır.
        }
    }
}
