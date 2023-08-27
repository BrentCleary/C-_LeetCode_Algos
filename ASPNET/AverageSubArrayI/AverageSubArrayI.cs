/*
You are given an integer array nums consisting of n elements, and an integer k.

Find a contiguous subarray whose length is equal to k that has the maximum average value and return this value. Any answer with a calculation error less than 10^5 will be accepted.

----------

Example 1:

Input: nums = [1,12,-5,-6,50,3], k = 4
Output: 12.75000
Explanation: Maximum average is (12 - 5 - 6 + 50) / 4 = 51 / 4 = 12.75
*/


// public double FindMaxAverage(int[] nums, int k)
// {
//   //Checks is k is out of nums range, and doesn't == 0
//   if(nums.Length < k && k != 0)
//   {
//     k = nums.Length;
//   }

//   int newSum = 0;
//   int windowSum = 0;

//   for(int i = 0; i < nums.Length - k; i++)
//   {
//     for(int j = 0; j < k; j++)
//     {
//       newSum += nums[j];
//     }

//     if(newSum / k > windowSum / k)
//     {
//       windowSum = newSum;
//     }
//   }

//   return windowSum;

// }