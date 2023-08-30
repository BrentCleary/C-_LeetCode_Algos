public class Solution {

  public int PivotIndex(int[] nums)
  {
    int totalSum = 0;
    int leftSum = 0;
    int rightSum = 0;

    for(int i = 0; i < nums.Length; i++)
    {
      totalSum += nums[i];
    }

    if(totalSum - nums[0] == 0)
    {
      return 0;
    }
    if(totalSum - nums[nums.Length - 1] == 0)
    {
      return nums.Length - 1;
    }
    else
    {
      int j = 1;
      rightSum = ((totalSum - nums[j]) - nums[j-1]);
      while(j < nums.Length - 2)
      {
        leftSum += nums[j-1];
        rightSum -=  nums[j+1];
        if(leftSum == rightSum)
        {
          return j;
        }
        j++;
      }
      return -1;
    }

  }
}