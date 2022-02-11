using System;

namespace converts
{
    class Program
    {
        static void Main(string[] args)
        {
            //Implicit Conversion (Bilinçsiz Dönüşüm)
            //low-->high
            Console.WriteLine("*******Implicit Conversion*******");
            byte a = 5;
            sbyte b = 30;
            short c = 10;

            int d = a + b + c;
            Console.WriteLine("d:" + d);

            long h = d;
            Console.WriteLine("h:" + h);

            float i = h;
            Console.WriteLine("i:" + i);

            // Sorunsuz çalıştı. Object, yüksek kapasiteli bir veri tipidir.

            string e = "hello";
            char f = 'k';
            object g = e + f + d;
            Console.WriteLine("g:" + g);


            //Explicit Conversion (Bilinçli Dönüşüm)
            Console.WriteLine("*******Explicit Conversion*******");
            int x = 4;
            byte y = (byte)x; // cast 
            Console.WriteLine("y: " + y);

            int z = 100;
            byte t = (byte)z; // cast 
            Console.WriteLine("t: " + t);

            //Çevrimlerde veri kaybolabilir

            float w = 10.3f;
            byte v = (byte)w;
            Console.WriteLine("v:" + v); //10


            //*****ToString Methodu*****
            Console.WriteLine("*******ToString Methodu*******");
            int xx = 6;
            string yy = xx.ToString();
            Console.WriteLine("yy:" + yy);


            string zz = 12.5f.ToString();
            Console.WriteLine("zz:" + zz); //12.5

            //*****System.Convert*****
            Console.WriteLine("***** System.Convert sınıfı *****");
            string s1 = "10", s2 = "20";
            int sayi1, sayi2;
            int Toplam;
            sayi1 = Convert.ToInt32(s1);
            sayi2 = Convert.ToInt32(s2);
            Toplam = sayi1 + sayi2;
            Console.WriteLine("Toplam: " + Toplam);


            //Parse
            Console.WriteLine("***** Parse Methodu *****");
            ParseMethod();

            //Not: Convert.ToDateTime() and DateTime.Parse()
            //Herhangi bir tipteki değişkeni string tipine en kolay string.From() methodu ile çevrilir.
            //string->byte tip dönüşümü explicit dahi olsa gerçekleştirilemez.

        }
        public static void ParseMethod()
        {
            //static methodlar içerisinden static methodlar kullanılabilir.
            string metin1 = "10";
            string metin2 = "10.25";
            int rakam1;
            double double1;

            rakam1 = Int32.Parse(metin1);
            double1 = Double.Parse(metin2);

            Console.WriteLine("rakam1: " + rakam1);
            Console.WriteLine("double1: " + double1);
        }
    }
}
