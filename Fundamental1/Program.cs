// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// 1 For Loop
Console.WriteLine("-----------");
Console.WriteLine("For Loop");
Console.WriteLine("-----------");

for(int i = 0; i <= 255; i++)
{
  Console.WriteLine(i);
}

// 2 Loop Random
Console.WriteLine("-----------");
Console.WriteLine("Loop Random");
Console.WriteLine("-----------");

Random rand = new Random();

for(int i = 0; i < 5; i++)
{
    Console.WriteLine(rand.Next(10, 21));
}


// 3

Console.WriteLine("-----------");
Console.WriteLine("Loop Random Addition");
Console.WriteLine("-----------");

int newSum = 0;

for(int i = 0; i < 5; i++)
{
    newSum += (rand.Next(10,21));
    Console.WriteLine(newSum);
}


// 4 

Console.WriteLine("-----------");
Console.WriteLine("Print i modulo 3 or 5, but not both");
Console.WriteLine("-----------");

for(int i = 0; i <= 100; i++)
{
  if((i % 3 == 0) && (i % 5 == 0))
  {
    i++;
  }
  else if((i % 3 == 0) || (i % 5 == 0))
  {
    Console.WriteLine(i);
  }
}


// 5

Console.WriteLine("-----------");
Console.WriteLine("Print i modulo 3 as Fizz, 5 as Buzz, but not both");
Console.WriteLine("-----------");

for(int i = 0; i <= 100; i++)
{
  if((i % 3 == 0) && (i % 5 == 0))
  {
    i++;
  }
  else if(i % 3 == 0)
  {
    Console.WriteLine("Fizz " + i);
  }
  else if(i % 5 == 0)
  {
    Console.WriteLine("Buzz " + i);
  }
}


// 5

Console.WriteLine("-----------");
Console.WriteLine("Fizz, Buzz, FizzBuzz");
Console.WriteLine("-----------");

for(int i = 0; i <= 100; i++)
{
  if((i % 3 == 0) && (i % 5 == 0))
  {
    Console.WriteLine("FizzBuzz " + i);
  }
  else if(i % 3 == 0)
  {
    Console.WriteLine("Fizz " + i);
  }
  else if(i % 5 == 0)
  {
    Console.WriteLine("Buzz " + i);
  }
}


// 1 While Loop Challenge

Console.WriteLine("-----------");
Console.WriteLine("While Loop");
Console.WriteLine("-----------");

int j = 0;
while( j <= 255)
{
  Console.WriteLine(j);
  j++;
}


// 2 While Loop Random

Console.WriteLine("-----------");
Console.WriteLine("While Loop Random");
Console.WriteLine("-----------");

int p = 0;
while(p < 5)
{
  Console.WriteLine(rand.Next(10,21));
  p++;
}


// 3 While Loop

Console.WriteLine("-----------");
Console.WriteLine("While Loop Random Addition");
Console.WriteLine("-----------");

int y = 0;
int sumAgain = 0;
while(y < 5)
{
  sumAgain = sumAgain + rand.Next(10,21);
  Console.WriteLine(sumAgain);
  y++;
}


// 4 While Loop

Console.WriteLine("-----------");
Console.WriteLine("While Loop i modulo 3 or 5, but not both");
Console.WriteLine("-----------");

int r = 0;
while(r <= 255)
{
  if((r % 3 == 0) && (r % 5 == 0))
  {
    r++;
  }
  else if((r % 3 == 0) || (r % 5 == 0))
  {
    Console.WriteLine(r);
  }
  r++;
}


// 4 While Loop

Console.WriteLine("-----------");
Console.WriteLine("While Loop i modulo 3 or 5, but not both");
Console.WriteLine("-----------");

int e = 0;
while(e <= 255)
{
  if((e % 3 == 0) && (e % 5 == 0))
  {
    e++;
  }
  else if(e % 3 == 0)
  {
    Console.WriteLine("Fizz");
  }
  else if(e % 5 == 0)
  {
    Console.WriteLine("Buzz");
  }
  e++;
}


// 5

Console.WriteLine("-----------");
Console.WriteLine("Fizz, Buzz, FizzBuzz");
Console.WriteLine("-----------");

int w = 0;
while(w <= 255)
{
  if((w % 3 == 0) && (w % 5 == 0))
  {
    Console.WriteLine("FizzBuzz " + w);
  }
  else if(w % 3 == 0)
  {
    Console.WriteLine("Fizz " + w);
  }
  else if(w % 5 == 0)
  {
    Console.WriteLine("Buzz " + w);
  }
  w++;
}