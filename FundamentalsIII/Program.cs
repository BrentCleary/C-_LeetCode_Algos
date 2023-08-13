

using System.Collections.Generic;
using System.Runtime.Intrinsics.Arm;

System.Console.WriteLine("-------------------");
System.Console.WriteLine("Iterate and Print Values");
System.Console.WriteLine("-------------------");

static void PrintList(List<string> MyList)
{
  foreach(string item in MyList)
  {
    System.Console.WriteLine(item);
  }

  for(int i = 0; i < MyList.Count; i++)
  {
    System.Console.WriteLine(MyList[i]);
  }

  int j = 0;
  while(j < MyList.Count)
  {
    System.Console.WriteLine(MyList[j]);
    j++;
  }

}
List<string> TestStringList = new List<string>() {"Harry", "Steve", "Carla", "Jeanne"};
PrintList(TestStringList);



System.Console.WriteLine("-------------------");
System.Console.WriteLine("-----Print Sum-----");
System.Console.WriteLine("-------------------");

static void SumOfNumbers(List<int> IntList)
{
  int sum = 0;
  foreach(int value in IntList)
  {
    System.Console.WriteLine("Value is " + value);
    sum = sum + value;
    System.Console.WriteLine("Sum is " + sum);

  }
}
List<int> TestIntList = new List<int>() {2,7,12,9,3};
// You should get back 33 in this example
SumOfNumbers(TestIntList);


System.Console.WriteLine("-------------------");
System.Console.WriteLine("-----Find Max-----");
System.Console.WriteLine("-------------------");

static int FindMax(List<int> IntList)
{
  int max = IntList[0];
  for(int i = 0; i < IntList.Count; i++)
  {
    if(IntList[i] >= max)
    {
      max = IntList[i];
      System.Console.WriteLine("Max is " + max);
    }
  }
  System.Console.WriteLine("IntList Max is " + max);
  return max;
}
List<int> TestIntList2 = new List<int>() {-9,12,10,3,17,5};
// You should get back 17 in this example
FindMax(TestIntList2);


System.Console.WriteLine("-------------------");
System.Console.WriteLine("-----Square the Values-----");
System.Console.WriteLine("-------------------");


static List<int> SquareValues(List<int> IntList)
{
  List<int> squaredVals = new List<int>();
  foreach(int value in IntList)
  {
    System.Console.WriteLine(value);
    squaredVals.Add(value * value);
  }
  foreach(int value in squaredVals)
  {
    System.Console.WriteLine(value);
  }
  return squaredVals;
}
List<int> TestIntList3 = new List<int>() {1,2,3,4,5};
// You should get back [1,4,9,16,25], think about how you will show that this worked
SquareValues(TestIntList3);


System.Console.WriteLine("-------------------");
System.Console.WriteLine("-----Negatives to 0's-----");
System.Console.WriteLine("-------------------");

static int[] NonNegatives(int[] IntArray)
{
  int[] newArray = new int[IntArray.Length];
  for(int i = 0; i < IntArray.Length; i++)
  {
    if(IntArray[i] < 0)
    {
      newArray[i] = 0;
    }
    else
    {
      newArray[i] = IntArray[i];
    }
  }
  foreach(int val in newArray)
  {
    System.Console.WriteLine(val);
  }
  return newArray;
}
int[] TestIntArray = new int[] {-1,2,3,-4,5};
// You should get back [0,2,3,0,5], think about how you will show that this worked
NonNegatives(TestIntArray);



System.Console.WriteLine("-------------------");
System.Console.WriteLine("-----Print Dictionary-----");
System.Console.WriteLine("-------------------");


static void PrintDictionary(Dictionary<string,string> MyDictionary)
{
  foreach(KeyValuePair<string, string> entry in MyDictionary)
  {
    System.Console.WriteLine($"{entry.Key} - {entry.Value}");
  }
}
Dictionary<string,string> TestDict = new Dictionary<string,string>();
TestDict.Add("HeroName", "Iron Man");
TestDict.Add("RealName", "Tony Stark");
TestDict.Add("Powers", "Money and intelligence");
PrintDictionary(TestDict);



System.Console.WriteLine("-------------------");
System.Console.WriteLine("-----Find Key-----");
System.Console.WriteLine("-------------------");

static bool FindKey(Dictionary<string,string> MyDictionary, string SearchTerm)
{
  return MyDictionary.ContainsKey(SearchTerm);
}

Dictionary<string,string> TestDict2 = new Dictionary<string,string>();
TestDict2.Add("HeroName", "Iron Man");
TestDict2.Add("RealName", "Tony Stark");
TestDict2.Add("Powers", "Money and intelligence");
System.Console.WriteLine(FindKey(TestDict2, "ILikeIt"));
// Use the TestDict from the earlier example or make your own
// This should print true
Console.WriteLine(FindKey(TestDict2, "RealName"));
// This should print false
Console.WriteLine(FindKey(TestDict2, "Name"));


System.Console.WriteLine("-------------------");
System.Console.WriteLine("------Generate Dictionary-----");
System.Console.WriteLine("-------------------");




List<string> characters = new List<string>() {"Ryu", "Ken", "Bill", "Ted"};
List<int> powerLevels = new List<int>() {501, 500, 9000, 9001};

static Dictionary<string,int> GenerateDictionary(List<string> Names, List<int> Numbers)
{
  Dictionary<string, int> MyDictionary = new Dictionary<string, int>();
  
  
  for(int i = 0; i < Names.Count; i++)
  {
    MyDictionary.Add(Names[i], Numbers[i]); 
  }
  
  foreach(KeyValuePair<string, int> entry in MyDictionary)
  {
    System.Console.WriteLine($"{entry.Key} - {entry.Value}");
  }

    return MyDictionary;
}






