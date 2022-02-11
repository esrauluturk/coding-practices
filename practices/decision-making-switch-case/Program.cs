using System;

namespace decision_making_switch_case
{
    class Program
    {
        static void Main(string[] args)
        {
            int month = DateTime.Now.Month;

            //Expression
            switch (month)
            {
                case 1:
                    Console.WriteLine("January");
                    break;
                case 2:
                    Console.WriteLine("February");
                    break;
                case 4:
                    Console.WriteLine("April");
                    break;
                case 3:
                    Console.WriteLine("March");
                    break;

                default: // Hicbir case uymadiginda yapilacak olan islem.
                    Console.WriteLine("Yanlış Giriş");// Kullanici veri girisini kontrol icin anlamli
                    break;
            }

            //****Kullanım2****
            //Birden fazla kosul oldugu durumlarda daha okunabilir temiz bir yapı(switch - case) 
            //Birden fazla kosulda aynı kodun calısması gereken durumlardaki switch ifadesi(3 veya daha fazla kosul)
            /**
            *Case ifadelerinin sırası önemli değildir.
            *Bilinenin aksine default ifadesi en son yazılmak zorunda değildir.
            *Default ifadesi zorunlu değildir. Yazılmasa da olur.
            *Her case ifadesi birbirinden farklı olmallıdır.(break)
            *Bir switch-case ifadesinde yalnızca bir case çalışmalıdır.
            */

            switch (month)
            {
                case 12:
                case 1:
                case 2:
                    Console.WriteLine("Winter");
                    break;
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("Spring");
                    break;
                case 6:
                case 7:
                case 8:
                    Console.WriteLine("Summer Time");
                    break;
                case 9:
                case 10:
                case 11:
                    Console.WriteLine("Autumn");
                    break;

                default://bu ifade mutlaka olmalı
                    break;

            }
        }
    }
}
