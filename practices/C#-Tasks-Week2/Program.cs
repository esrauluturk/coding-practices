using System;

namespace C__Tasks_Week2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Alıştırma 1 : 1 – 1.000.000 Arasındaki Asal Sayıları Listeleme
            int check = 0, nCount = 0, k = 2;
            do
            {
                check = 0;
                int m = 2;
                while (m <= k / 2)
                {
                    if (k % m == 0)
                    {
                        check++;
                        break;
                    }
                    m++;
                }
                if (check == 0)
                {
                    nCount++;
                    Console.Write(k + "-");
                }
                k++;

            } while (k <= 10);

            Console.WriteLine();
            Console.WriteLine("{0} adet asal sayı bulundu.", nCount);

            //Alıştırma 2 : 1-N arası 3 e ve 7’ye Tam Bölünen Sayıları Listeleme
            int limit = 0;
            string conclusion = "";
            Console.WriteLine("1 ile Limit arasında 3'e ve 7’ye Tam Bölünen Sayıları Listeleme yapılacaktır.");
            Console.Write("Lütfen limiti giriniz (Ör:250) : ");

            conclusion = int.TryParse(Console.ReadLine(), out limit) ? "" : "HATALI GİRİŞ! ";
            Console.WriteLine(conclusion);

            int start = 1;
            while (start <= limit)
            {
                if (start % 3 == 0 && start % 7 == 0)
                {
                    Console.Write("{0} ", start);
                }
                start++;
            }

            //Alıştırma 3 : Diziyi Alfabetik Olarak Sıralama (Kullanıcının gireceği kelimelerden oluşan diziyi alfabetik olarak sıralama)
            int cnt;
            Console.WriteLine("Program önce veri adedini sonra kelimelerinizi girmenizi isteyecek.\nSıralanmış bir listeye ulaşacaksınız:)");
            Console.Write("Kaç adet kelime gireceksiniz(Ör:5) : ");
            string rst;
            rst = int.TryParse(Console.ReadLine(), out cnt) ? "" : "Hatalı Giriş";
            Console.WriteLine(rst);
            string[] words = new string[cnt];

            for (int c = 0; c < cnt; c++)
            {
                Console.Write(c + 1 + ". Kelimeyi Giriniz : ");
                words[c] = Console.ReadLine();
            }

            Console.WriteLine();
            Console.WriteLine("Sıralamadan önce liste:");
            Arrangement(words);

            // Sıralama
            Array.Sort(words);
            Console.WriteLine("\nA-Z Sıralama:");
            Arrangement(words);
            // Tersten Sıralama
            Array.Reverse(words);
            Console.WriteLine("\nZ-A Sıralama:");
            Arrangement(words);

            //Alıştırma 4 : Girilen Metindeki Sesli Harfleri Bulan Program
            Console.Write("Bir Metin Giriniz : ");
            string message = Console.ReadLine().Trim();
            string vowel = "aeıioöuü";
            vowel += vowel.ToUpper();
            int toCount = 0;
            foreach (char c in message)
            {
                if (vowel.Contains(c)) toCount++;
            }
            Console.WriteLine("'{0}' ifadesinde toplam {1} tane sesli harf vardır.", message, toCount);

            //Alıştırma 5 : Kullanıcıdan 10 adet sayı alarak bu sayıların toplamını ekranda gösteren program
            int sum = 0, count = 1, num = 0;
            Console.WriteLine("Hoşgeldiniz:> 10 adet sayı girmeniz isteniyor...");
            do
            {
                Console.Write("Lütfen {0}. Sayıyı  Giriniz : ", count);
                if (int.TryParse(Console.ReadLine(), out num)) sum += num;
                else
                {
                    Console.WriteLine("Hatalı Formatta bir Giriş Yapıldı.Tekrar Deneyin...");
                    break;
                }
                count++;

            } while (count <= 10);
            Console.WriteLine("Girdiğiniz Sayıların Toplamı: {0}", sum);

            //Alıştırma 6 : Bilgisayarın rastgele tuttuğu 10 sayıdan çift ve tek olanların sayısını gösteren program
            int number, oddCount = 0, evenCount = 0;
            Random rnd = new Random();
            for (int j = 1; j <= 10; j++)
            {
                number = rnd.Next(1, 250);
                Console.WriteLine("{0}. Sayımız : {1}", j, number);
                if (number % 2 == 0) evenCount++;
                else oddCount++;
            }
            Console.WriteLine("Çift sayıların toplamı : {0} \nTek sayıların toplamı : {1}", evenCount, oddCount);

            //Alıştırma 7 : Kullanıcının girdiği metni kullanıcının girdiği sayıda ekranda yazdıran program
            Console.Write("Lütfen bir metin giriniz : ");
            string text = Console.ReadLine();
            Console.Write("Ekrana metnin kaç kere yazmasını istersiniz(Ör:8) : ");
            string result;
            int counter = 0;
            result = int.TryParse(Console.ReadLine(), out counter) ? "Sonucunuz : " : "Hatalı Giriş Yapildi";
            Console.WriteLine(result);
            int i = 1;
            while (i <= counter)
            {
                Console.WriteLine("{0}. {1}", i, text);
                i++;
            }
        }
        static void Arrangement(string[] list)
        {

            foreach (string item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
