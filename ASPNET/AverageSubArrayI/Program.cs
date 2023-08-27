using System;

public class Solution
{
  public double FindMaxAverage(int[] nums, int k)
  {
    double windowSum = double.MinValue;

    for(int i = 0; i <= nums.Length - k; i++)
    {
      double newSum = 0;

      for(int j = i; j < i+k; j++)
      {
        newSum += nums[j];
      }

      double result = newSum / k;

      if(result >= windowSum)
      {
        windowSum = result;
        System.Console.WriteLine("windowSum is " + windowSum);
      }
    }

    return windowSum;
  }
}


class Program
{
    static void Main(string[] args)
    {
        int[] nums = { 1, 12, -5, -6, 50, 3 };
        int k = 4;

        Solution solution = new Solution();
        double maxAverage = solution.FindMaxAverage(nums, k);

        Console.WriteLine($"Maximum average: {maxAverage}");
    }
}