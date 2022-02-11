using System;

namespace error_handling
{
    //Exception Handling
    class Program
    {
        //***Compile Time - Run Time Exceptions***
        //Degiskene ilk deger atamasini yapmadan kullanmaya calismak, derleyici standartlarina uygun degisken tanimlamamak-->Compile Time Exception
        //Run time hatalari mumkun oldugunca handle etmek gerekir.
        static void Main(string[] args)
        {
            //Run Time Exceptions
            try
            {
                //Hataya neden olabilecek kisim
                Console.WriteLine("Bir sayı giriniz: ");
                int sayi = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Girmiş oldugunuz sayi:  " + sayi);

            }
            catch (Exception ex)
            {
                Console.WriteLine("Hata: " + ex.Message.ToString());
            }
            finally //optional
            {
                //Hep calisir
                Console.WriteLine("İşlem tamamlandi!");
            }

            //Exception Tipleri
            try
            {
                //int a = int.Parse(null); //String Degerleri donusturmek
                //int b = int.Parse("test");
                int c = int.Parse("-200000000000000000");

            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine("Boş değer girdiniz!");
                Console.WriteLine(ex); //Value cannot be null.
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Veri tipi uygun değil!");
                Console.WriteLine(ex);//Input string was not in a correct format.
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("Çok küçük ya da çok büyük bir değer girdiniz!");
                Console.WriteLine(ex); //Value was either too large or too small for an Int32.
            }
            finally
            {
                Console.WriteLine("İşlem başarı ile tamamlandı!");
            }

            //Compile Time hatası alır.
            //int a = 5;
            //byte s = a; //Daha kucuk olana atmaya calismak

            //Compile Time hatası almaz.
            int t = 5;
            decimal p = t;

            //Karşılaştırılacak iki degiskenin tipleri farklı oldugunda Compile Time Hatası alır
            //bool k = true;
            //if (a > k)
            //{

            //}

        }
    }
}
