using System;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(GCD(100, 100));
            Console.WriteLine(GCD(100, 10));
            Console.WriteLine(GCD(100, 1000));
            Console.WriteLine(GCD(65, 55));
            Console.WriteLine(GCD(60, 72));
        }

        static int GCD(int a, int b)
        {
            int mod = int.MaxValue;
            while (mod > 0)
            {
                if (a > b)
                {
                    mod = a % b;
                    a = mod;
                }
                else if (a < b)
                {
                    mod = b % a;
                    b = mod;
                }
                else
                    mod = 0;
            }
            return a == 0 ? b : a;
        }
    }
}
