using System;

public class Solution
{
  public double FindMaxAverage(int[] nums, int k)
  {
    double windowSum;

    for(int i = 0; i <= nums.Length - k; i++)

      System.Console.WriteLine("window: " + i);
      double newSum = 0;
      

      for(int j = i; j < i+k; j++)
      {
        System.Console.WriteLine("newSum: " + newSum + " + nums[j] " + nums[j]);
        newSum += nums[j];
      }

      System.Console.WriteLine("newSum is " + newSum);
      double result = newSum / k;
      System.Console.WriteLine("newSum / k is " + result);

      if(result >= windowSum && windowSum != null)
      {
        windowSum = result;
        System.Console.WriteLine("windowSum is " + windowSum);
      }
      
    }

    return windowSum;

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