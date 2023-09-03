/**
 * @param {number[]} nums
 * @param {number} k
 * @return {number}
 */
var findMaxAverage = function(nums, k)
{
  // setup result var
  let maxSumVal = 0;

  // if array is 1 
  if(nums.length === 1)
  {
    return nums[0];
  }

  // first window of k length
  for (let i = 0; i < k; i++)
  {
    maxSumVal += nums[i];
  }

  let windowSum = maxSumVal;

  // Loop over nums
  for(let i = k; i < nums.length; i++)
  {
    windowSum = windowSum - nums[i-k] + nums[i];

    if(windowSum >= maxSumVal)
    {
      maxSumVal = windowSum;
    }
  
  }

  return (maxSumVal / k);

};


testNums = [1,12,-5,-6,50,3];

moreNums = [4433,-7832,-5068,4009,2830,6544,-6119,-7126,-780,-4254,-8249,-9168,9492,402,5789,6808,8953,5810,-7353,7933,4766,5182,-3230,-1989,5786,6922,-4646,4415,-9906,807,-6373,3370,2604,8751,-9173,-2668,-6876,9500,3465,-1900,4134,-1758,-1453,-5201,-9825,4469,-1999,-1108,1836,3923,6796,-5252,9863,-5997,-3251,9596,-3404,-540,2826,-1737,3341,-3623,-9885,2603,-5782,8174,2710,6504,-4128]


k = 59;
result = findMaxAverage(moreNums, k);
console.log(result);