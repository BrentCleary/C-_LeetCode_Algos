// Given a binary array nums, return the maximum number of consecutive 1's in the array.

function findMaxConsecutiveOnes(nums)
{

  let maxConsecutive = 0;
  let counter = 0;

  for (let i = 0; i < nums.length; i++) 
  {
    if(nums[i] == 1)
    {
      counter += 1;
      if(counter >= maxConsecutive)
      {
        maxConsecutive = counter;
      }
    }

    if(nums[i] == 0)
    {
      if(counter >= maxConsecutive)
      {
        maxConsecutive = counter;
      }
      counter = 0;
    }
  }

  return maxConsecutive;
}