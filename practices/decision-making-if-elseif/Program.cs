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
        }
    }
}
