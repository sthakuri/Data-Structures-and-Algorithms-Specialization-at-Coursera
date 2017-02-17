using System;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(ComputeFibonacciNum(1));
            Console.WriteLine(ComputeFibonacciNum(2));
            Console.WriteLine(ComputeFibonacciNum(3));
            Console.WriteLine(ComputeFibonacciNum(10));
            Console.WriteLine(ComputeFibonacciNum(4));

            PrintFibonacciNums(5);
            PrintFibonacciNums(100);
        }

        static long ComputeFibonacciNum(int n)
        {
            if (n == 1 || n == 2)
                return n - 1;

            long[] arr = new long[n];

            arr[0] = 0;
            arr[1] = 1;
            int i = 2;
            while (i < n)
            {
                arr[i] = arr[i - 1] + arr[i - 2];
                i++;
            }
            return arr[n - 1];
        }

        static void PrintFibonacciNums(int n)
        {
            long[] arr = new long[n];
            if (n == 1)
            {
                arr[0] = 0;
                Console.Write("{0} ", arr[0]);
            }
            if (n == 2)
            {
                arr[1] = 1;
                Console.Write("{0} ", arr[1]);
            }


            else
            {


                arr[0] = 0; Console.Write("{0} ", arr[0]);
                arr[1] = 1; Console.Write("{0} ", arr[1]);
                int i = 2;
                while (i < n)
                {
                    arr[i] = arr[i - 1] + arr[i - 2];
                    Console.Write("{0} ", arr[i]);
                    i++;

                }
            }
        }
    }
}
