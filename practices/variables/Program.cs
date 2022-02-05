using System;

namespace variables
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Notes
            //Degisken tanimlanirken kullanmadan once mutlaka bir degere atanmali.
            //Compile Time'da hata verir. Run Time'da degil.
            #endregion
            //---------------RULES-------------------
            //Hatali Kullanim
            //int deger;
            //Console.WriteLine(deger);
            //Dogru Kullanim
            int deger;
            deger = 2;
            Console.WriteLine(deger);
            //Ornek Kullanimlar
            int deger = 2;
            //Degisken ve degisken ikisi farklidir.
            string degisken = null; 
            string Degisken = null;
            //Degisken adlari rakamla baslayamaz!
            //int 3degisken = 5;

            //Ayrilmis-Ozel isimler verilemez! (namespace ismi, func ismi etc.verilemez)
            //string System = "";
            //string class = "merhaba";

            //Ayni kod blogu içinde ayni degisken birden fazla kez tanimlanamaz! Farkli bir func. icinde tanimlanabilirdi.
            int degisken = 5;
            string degisken = "";

            //İslem operatoru iceremez!
            //string degisken+veri = null;

            //Bir degisken ismi tanimlarken yalnizca "_" kullanilabilir.
            string degisken_veri = null;
            
            //degisken ismi taniminda bosluk olamaz!
            //string v z = null;


            
            //White space, hataya acik olabilen noktalardir.
            Console.WriteLine("");
            String degisken = " "; // Bos degil.
            if(degisken == "") //false
            if(degisken == " ") //true

            //string'e null atama yapabiliriz.


            // BELLEK

            byte b = 5; //0 - 255                           //1 byte   //unsigned
            sbyte c = 5;//-128 127                          //1 byte
            short s = 5;//-32768 32767                      //2 byte
            ushort us = 5;//0 ile 65.535 arasında           //2 byte
            Int16 i16 = 2;                                  //2 byte
            int i = 2;//-2.147.483.648 ile 2.147.483.647    //4 byte
            Int32 i32 = 2;                                  //4 byte
            Int64 i64 = 2;                                  //8 byte
            uint ui = 2;                                    //4 byte
            long l = 4;                                     //8 byte
            ulong ul = 4;                                   //8 byte


            float f = 5;                                    //4 byte
            double d = 5;                                   //8 byte
            decimal de = 5;                                 //16 byte


            char ch = '2';                                  //2 byte
            string str = "Hello World";                     //sinirsiz


            bool b1 = true;
            bool b2 = false;

            DateTime dt = DateTime.Now; //calistirdigi anin tarih ve saat karsiligini getirir.
            Console.WriteLine(dt);

            //object, her turden veriyi alabiliyor. Degisken tipleri aslinda birer objedir. Object turunden turetilmistir.

            object o1 = "x";
            object o2 = 'y';
            object o3 = 4;
            object o4 = 4.3;
            
            //string ifadeler
            string str = "";
            string st = null;
            string sr = string.Empty;
            sr = "Hello World";
            string ad = "Ad";
            string soyad = "Soyad";
            string tam = ad + " " + soyad;

            //integer tanimlama
            int integer1 = 5;
            int integer2 = 3;
            int integer3 = integer1 * integer2;

            //boolean
            bool bool1 = 10 > 2;

            //degisken donusumleri
            string str20 = "20";
            int int20 = 20;
            string yeniDeger = str20 + int20.ToString();
            Console.WriteLine(yeniDeger);






            




            
        







        }
    }
}
