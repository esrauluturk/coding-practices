using System;

namespace decision_making_if_elseif
{
    class Program
    {
        static void Main(string[] args)
        {
            int time = DateTime.Now.Hour;
            if (time >= 6 && time < 11)
                Console.WriteLine("What a wonderful world!");
            else if (time <= 18)
                Console.WriteLine("Have a nice day!");
            else
                Console.WriteLine("What a pity!");

            //*********Ternary**********

            string result = time <= 18 ? "What a wonderful world!" : "What an awful day!";
            Console.WriteLine(result);

            //*********Ternary Operator(?:)**********
            string howaday = time >= 6 && time < 11 ? "What a wonderful world!" : time <= 18 ? "Have a nice day!" : "What a pity!";
            Console.WriteLine(howaday);

            int N = Convert.ToInt32(Console.ReadLine().Trim());
            string sonuc = N % 2 == 1 ? "Weird" : N % 2 == 0 && 2<=N && N<=5 ? "Not Weird" : N % 2 == 0 && 6 <= N && N<= 20 ? "Weird" : N % 2 == 0 && N > 20 ? "Not Weird": "How a nice!";
            Console.WriteLine(sonuc);
        }
    }
}
