// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string one  = "abc";
string two = "pqr";
string result = "";

string MergeAlternately(string word1, string word2) {

  string mergedStr = "";
  int length = 0;

  if(word1.Length >= word2.Length)
  {
    length = word1.Length;
  }
  else
  {
    length = word2.Length;
  }

  for(int i = 0; i < length; i++)
  {
    Console.WriteLine(i);

    if(word1[i] != null)
    {
      mergedStr += word1[i];
      Console.WriteLine(mergedStr);
    }
    if(word2[i] != null)
    {
      mergedStr += word2[i];
      Console.WriteLine(mergedStr);
    }
  }

  return mergedStr;
}




result = MergeAlternately(one, two);
Console.WriteLine("The result is : " + result);

