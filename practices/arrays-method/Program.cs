using System;

namespace arrays_method
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sort
            int[] numArr = { 23, 12, 4, 86, 72, 3, 11, 17 };
            Console.WriteLine("****** Sırasız Dizi ******");
            foreach (var num in numArr)
                Console.WriteLine(num);
            Console.WriteLine("****** Sıralı Dizi ******");
            Array.Sort(numArr);//Atama yapmaya gerek yok. Void fonk. Verilen dizi üzerinde değişiklik yapar.
            foreach (var num in numArr)
                Console.WriteLine(num);

            //Clear
            //Verilen index ten baslayarak, verilen eleman sayısı kadar değeri sıfırlar. Dizinin o elemanına sıfırı atar.
            Console.WriteLine("****** Array Clear Method ******");
            //numArr dizisi elemanlarını kullanaak 2.index ten itibaren 2 tane elemanı sıfırlar. 
            Array.Clear(numArr, 2, 2);

            foreach (var num in numArr)
                Console.WriteLine(num);

            //Reverse
            //Ters Çevirme
            Console.WriteLine("****** Array Reverse Method ******");
            Array.Reverse(numArr);
            foreach (var num in numArr)
                Console.WriteLine(num);


            //IndexOf
            //Verilen eleman dizi içerisinde varsa index ini doner.
            Console.WriteLine("****** Array IndexOf Method ******");
            Console.WriteLine(Array.IndexOf(numArr, 23)); //2


            //Resize
            //Yeniden Boyutlandırma
            Console.WriteLine("****** Array Resize Method ******");
            Array.Resize<int>(ref numArr, 9); //Boyutunu 9 yap--normalde boyut:8 idi
            numArr[8] = 99;

            foreach (var num in numArr)
                Console.WriteLine(num);
        }
    }
}
