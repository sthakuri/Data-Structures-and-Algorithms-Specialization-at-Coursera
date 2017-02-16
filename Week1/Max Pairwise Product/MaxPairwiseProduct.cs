using System;

public class MaxPairwiseProduct
{
    static Int64 getMaxPairwiseProduct(int[] numbers)
    {
        Int64 result = 0;
        int n = numbers.Length;
        for (int i = 0; i < n; ++i)
        {
            for (int j = i + 1; j < n; ++j)
            {
                if (numbers[i] * numbers[j] > result)
                {
                    result = (Int64) numbers[i] * numbers[j];
                }
            }
        }
        return result;
    }

    static Int64 getMaxPairwiseProductFast(int[] numbers)
    {        
        int n = numbers.Length;
        int max_index1 = -1;
        for (int i = 0; i < n; ++i)
            if ((max_index1 == -1) || (numbers[i] > numbers[max_index1]))
                max_index1 = i;

        int max_index2 = -1;
        for (int j = 0; j < n; ++j)
            if ((j != max_index1) && ((max_index2 == -1) || (numbers[j] > numbers[max_index2])))
                max_index2 = j;

        return ((Int64)(numbers[max_index1])) *numbers[max_index2];        
    }


    public static void Main(String[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] strNums = Console.ReadLine().Split(' ');
        int[] numbers = new int[n];
        for (int i = 0; i < n; i++)
        {
            numbers[i] = Int32.Parse(strNums[i]);
        }
        Console.WriteLine(getMaxPairwiseProduct(numbers));
        Console.WriteLine(getMaxPairwiseProductFast(numbers));        
    }
}