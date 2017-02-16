using System;

public class MaxPairwiseProduct {
    static int getMaxPairwiseProduct(int[] numbers) {
        int result = 0;
        int n = numbers.Length;
        for (int i = 0; i < n; ++i) {
            for (int j = i + 1; j < n; ++j) {
                if (numbers[i] * numbers[j] > result) {
                    result = numbers[i] * numbers[j];
                }
            }
        }
        return result;
    }

    public static void Main(String[] args) {        
        int n = Convert.ToInt32(Console.ReadLine());
        string[] strNums= Console.ReadLine().Split(' ');        
        int[] numbers = new int[n];
        for (int i = 0; i < n; i++) {
            numbers[i] =Int32.Parse(strNums[i]);
        }
        Console.WriteLine(getMaxPairwiseProduct(numbers));
    }
}