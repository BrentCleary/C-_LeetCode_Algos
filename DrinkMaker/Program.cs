using System.Reflection.PortableExecutable;

Water glassOfWater = new Water(false);
Soda canOfSoda = new Soda("cherry");
HotChocolate hotChocolate = new HotChocolate(false);

List<Drink> AllBeverages = new List<Drink>();
AllBeverages.Add(glassOfWater);
AllBeverages.Add(canOfSoda);
AllBeverages.Add(hotChocolate);

foreach(Drink drink in AllBeverages)
{
  System.Console.WriteLine($"---------{drink.Name}----------");
  drink.ShowDrink();
}

