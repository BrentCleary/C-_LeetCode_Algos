/*

283. Move Zeroes
Easy

Given an integer array nums, move all 0's to the end of it while maintaining the relative order of the non-zero elements.

Note that you must do this in-place without making a copy of the array.

*/

public class Solution
{
  public void MoveZeroes(int[] nums)  
  {
    for(int i = nums.Length-1; i >= 0 ; i--)
    {
      int counter = i;
      while(counter < nums.Length - 1)
      {
        if(nums[counter] == 0)
        {
          int temp = nums[counter];
          nums[counter] = nums[counter+1];
          nums[counter+1] = temp;
        }
        counter++;
      }
    }
  }

}

