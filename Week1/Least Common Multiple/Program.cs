using System;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(LCM(12,80));
            Console.WriteLine(LCM(12,8));
        }

        static long LCM(int a, int b)
        {
            return (long)a*b/GCD(a,b);
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
