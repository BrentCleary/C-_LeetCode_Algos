public class Solution
{
  public bool IsSubsequence(string s, string t)
  {
    // Check if strings are identical == true
    if(s == t)
    {
      return true;
    }
    // Check if s is empty == true (not sure why)
    else if(s == "")
    {
      return true;
    }
    else
    {
      string compareStr = "";

      Dictionary<int, string> dict = new Dictionary<int, string>();
      for(int i = 0; i < s.Length; i++)
      {
        dict.Add(i, s[i].ToString());
      }

      // start at index 0 for s dictionary
      for(int i = 0; i < s.Length; i++)
      {
        // set t string to check at same index as s
        int j = i;
        while(j < t.Length)
        {
          // if the char at t[j] matches the character in s dict
          if(t[j].ToString() == dict[i])
          {
            // add to compare string
            compareStr += t[j];
            // check to see if they match (return true if so)
            if(compareStr == s)
            {
              return true;
            }
            // break and move onto the next interation in s
            break;
          }
          // or cycle through the next j value in t to look for a match
          j++;
        }
      }
    // return false if no match is found
    return false;
    }
  }

}