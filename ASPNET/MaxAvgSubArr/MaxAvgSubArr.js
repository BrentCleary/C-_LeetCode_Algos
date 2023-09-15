/**
 * @param {number[]} nums
 * @param {number} k
 * @return {number}
 */
var findMaxAverage = function(nums, k)
{
  // create var to hold max sum
  let largestSum = 0;
  
  // create var to hold temp sums
  let windowSum = 0;

  for(let i = 0; i < k; i++)
  {
    windowSum += nums[i];
  }

  // set first map val to windowSum
  largestSum = windowSum;

  for(let i = k; i < nums.length; i++)
  {
    windowSum = (windowSum + -nums[i-k] + nums[i])

    if(largestSum < windowSum)
    {
      largestSum = windowSum;
    }
  }    

  return largestSum / k;
};