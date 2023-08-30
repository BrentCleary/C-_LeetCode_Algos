using System.Diagnostics.Metrics;

// public class Solution
// {
//     public string ReverseVowels(string s)
//     {
//       string vowels = "aeiou";

//       Dictionary<int, string> vowelDict= new Dictionary<int,string>();


//       for(int i = 0; i < s.Length; i++)
//       {
//         if(vowels.Contains(s[i]))
//         {
//           vowelDict.Add(i, s[i].ToString());
//         }
//       }

//       char[] charArray = s.ToCharArray();

//       for(int j = s.Length - 1; j >= 0 ; j--)
//       {
//         if(vowelDict.ContainsKey(j))
//         {
//           charArray[s.Length - 1 - j ] = vowelDict[j][0];
//         }
//       }

//       foreach(KeyValuePair<int, string> str in vowelDict)
//       {
//         System.Console.WriteLine(str);
//       }

//       return new string(charArray);
//     }
// }


public class Solution
{
    public string ReverseVowels(string s)
    {
        string vowels = "aeiou";

        Dictionary<int, char> vowelDict = new Dictionary<int, char>();

        for (int i = 0; i < s.Length; i++)
        {
            if(vowels.Contains(s[i]))
            {
                vowelDict.Add(i, s[i]);
            }
        }

        char[] charArray = s.ToCharArray();

        int j = 0;
        while(j < charArray.Length)
        {
          int counter = 0;
          if(charArray[j] == vowelDict[j])
          {
            charArray[j] = vowelDict[vowelDict.Count - counter];
            counter++;
          }
          j++;
        }

        foreach(KeyValuePair<int,char> str in vowelDict)
        {
            System.Console.WriteLine(str);
        }

        string done = "Done";

        return new string(charArray);
    }
}
