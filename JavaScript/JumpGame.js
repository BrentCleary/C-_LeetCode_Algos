/**
 * @param {number[]} nums
 * @return {boolean}
 */
var canJump = function(nums)
{
    // if array.length == 1, return true. We are there.
    // if first index[0] == 0 and isn't end of array, return false. We can't advance.
    // loop over the array
    // else
      // see if the range is longer then the length of nums
        // if so, return true
      // else
        // find the largest index in range
        // advance to that index
      // continue on in the loop
      

    // if array.length == 1, return true. We are there.
    if(nums.length == 1)
    {
      return true;
    }

    // if first index[0] == 0 and isn't end of array, return false. We can't advance.
    if(nums[0] == 0 && nums.length > 1)
    {
      return false;
    }

    // loop over the array
    for(let i = 0; i < nums.length; i++)
    {
      // check if not at end, and standing on a zero
      if(nums[i] == 0 && i != nums.length-1)
      {
        return false;
      }

      // see if current range is longer then the length of nums
      if(i + nums[i] >= nums.length - 1)
      {
        // if so, return true
        return true;
      }
      else
      {
        // find the largest index in range
        longestJump = nums[i];

        // loop over i for range, set new range to largest i index
        for(let j = 1; j < nums[i]; j++)
        {
          // if(longestJump < nums[i + j])
          if(i + j < nums.length && nums[i + j] >= longestJump - j)
          {
            longestJump = nums[i + j]
          }
          
          // advance i by longestJump
          i += longestJump - 1;
        }
      }
    
    }
      // continue on in the loop


      

};