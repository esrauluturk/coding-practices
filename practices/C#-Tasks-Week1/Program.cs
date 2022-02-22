using System;

namespace C__Tasks_Week1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Alıştırma - 1
            //Ad ve soyad bilgisini string degiskenlere alarak ekranda yazdırma

            string name, surname;
            Console.Write("Lütfen İsminizi Giriniz : ");
            name = Console.ReadLine();
            Console.Write("Lütfen Soyadınızı Giriniz : ");
            surname = Console.ReadLine();
            Console.WriteLine(string.Format("Adınız : {0}\nSoyadınız : {1}\nMerhaba {0} {1}", name, surname));

            //Alıştırma - 2
            //Kullanıcıdan 2 sayı isteyerek bu sayıların toplamını bulan program
            try
            {
                int number1, number2, sum;
                Console.Write("1.Sayıyı Giriniz : ");
                number1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("2.Sayıyı Giriniz : ");
                number2 = Convert.ToInt32(Console.ReadLine());
                sum = number1 + number2;
                Console.WriteLine("{0} ve {1} Sayısının Toplamı : {2}", number1, number2, sum);

            }
            catch (FormatException)
            {
                Console.WriteLine("Hatalı Giriş Yapıldı! Lütfen Doğru Formatta Bir Giriş Yapınız!");
            }

            //Alıştırma - 3
            //Dikdörtgenin alanını ve çevresini hesaplayarak ekranda gösteren program
            double kisaKenar, uzunKenar;
            Console.Write("Kısa Kenar : ");
            kisaKenar = Convert.ToDouble(Console.ReadLine());
            Console.Write("Uzun Kenar : ");
            uzunKenar = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(string.Format("Kısa Kenar : {0}\nUzun Kenar : {1}\nAlan : {2}\nÇevre : {3}",
            kisaKenar, uzunKenar, areaRectangle(kisaKenar, uzunKenar), perimeterRectangle(kisaKenar, uzunKenar)));

            //Alıştırma - 4
            //Girilen sayının tek mi çift mi olduğunu bulan program
            try
            {
                int input;
                Console.WriteLine("Tek mi -- Çift mi");
                Console.Write("Lütfen bir tamsayı girişi yapınız : ");
                input = Convert.ToInt32(Console.ReadLine());
                if (input % 2 == 0) Console.WriteLine("Girdiğiniz sayı çifttir.");
                else Console.WriteLine("Girdiğiniz sayı tektir.");
            }
            catch (Exception)
            {
                Console.WriteLine("Tamsayı girişi yapınız!");
            }

            //Alıştırma - 5
            //Girilen sayının 0-100 arasında olup olmadığını kontrol eden program
            int num;
            Console.Write("Lütfen bir sayı giriş yapınız : ");
            num = Convert.ToInt32(Console.ReadLine());
            string result = (num >= 0 && num <= 100) ? "Sayı 0 ile 100 arasındadır :)" : "Sayı 0 ile 100 arasında bir değere sahip değil:(";
            Console.WriteLine(result);

            //Alıştırma - 6
            //Vücut kitle indeksini hesaplayan program
            double height, weight, indeks = 0;
            Console.Write("Boyunuzu m cinsinden Giriniz (Ör:1,75)  : ");
            height = Convert.ToDouble(Console.ReadLine());
            Console.Write("Kilonuzu Giriniz : ");
            weight = Convert.ToDouble(Console.ReadLine());
            indeks = weight / (height * height);

            Console.WriteLine("Vücut Kitle İndexiniz : {0}\nBilgilendirme : {1}", indeks, BodyMassIndex(indeks));

            //Alıştırma - 7
            //Cümledeki harf sayısını bulan program
            string text;
            Console.Write("Lütfen bir metin giriniz : ");
            text = Console.ReadLine().Trim();

            string list = "ABCÇDEFGĞHİIJKLMNOÖPRSŞTUÜVYZ"
                           + "abcçdefgğhiıjklmnoöprsştuüvyz"
                           + "0123456789";

            int letterCount = 0,numCount = 0;
            for (int i = 0; i < text.Length; i++)
            {
                //karakter katarkter kontrol ediyoruz.
                if (list.Contains(text[i]))
                {
                    if(!Char.IsNumber(text[i])) letterCount++;
                    else numCount++;
                   
                }
            }
            Console.WriteLine("Yukarıdaki ifadede toplam {0} tane harf {1} rakam vardır.",letterCount,numCount);

        }

        static double areaRectangle(double a, double b)
        {
            return a * b;
        }

        static double perimeterRectangle(double a, double b)
        {
            return 2 * (a + b);
        }
        static string BodyMassIndex(double indeks)
        {
            string result =
            (indeks < 18) ? "Zayıf" :
            (indeks >= 18 && indeks < 25) ? "Normal" :
            (indeks >= 25 && indeks < 30) ? "Kilolu" :
            (indeks >= 30 && indeks < 35) ? "Obez" :
            "Ciddi Obez";
            return result;

        }
    }
}
