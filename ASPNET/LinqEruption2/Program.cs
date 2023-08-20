List<Eruption> eruptions = new List<Eruption>()
{
    new Eruption("La Palma", 2021, "Canary Is", 2426, "Stratovolcano"),
    new Eruption("Villarrica", 1963, "Chile", 2847, "Stratovolcano"),
    new Eruption("Chaiten", 2008, "Chile", 1122, "Caldera"),
    new Eruption("Kilauea", 2018, "Hawaiian Is", 1122, "Shield Volcano"),
    new Eruption("Hekla", 1206, "Iceland", 1490, "Stratovolcano"),
    new Eruption("Taupo", 1910, "New Zealand", 760, "Caldera"),
    new Eruption("Lengai, Ol Doinyo", 1927, "Tanzania", 2962, "Stratovolcano"),
    new Eruption("Santorini", 46, "Greece", 367, "Shield Volcano"),
    new Eruption("Katla", 950, "Iceland", 1490, "Subglacial Volcano"),
    new Eruption("Aira", 766, "Japan", 1117, "Stratovolcano"),
    new Eruption("Ceboruco", 930, "Mexico", 2280, "Stratovolcano"),
    new Eruption("Etna", 1329, "Italy", 3320, "Stratovolcano"),
    new Eruption("Bardarbunga", 1477, "Iceland", 2000, "Stratovolcano")
};
// Example Query - Prints all Stratovolcano eruptions
IEnumerable<Eruption> stratovolcanoEruptions = eruptions.Where(c => c.Type == "Stratovolcano");
PrintEach(stratovolcanoEruptions, "Stratovolcano eruptions.");
// Execute Assignment Tasks here!

// Helper method to print each item in a List or IEnumerable. This should remain at the bottom of your class!
static void PrintEach(IEnumerable<Eruption> items, string msg = "")
{
    Console.WriteLine("\n" + msg);
    foreach (Eruption item in items)
    {
        Console.WriteLine(item.ToString());
    }
}

Eruption firstChile = eruptions.Where( e => e.Location == "Chile").OrderBy(e => e.Year).FirstOrDefault();
Console.WriteLine("First Chilean eruption was year " + firstChile.Year);

























// Products List for Practice

Product[] myProducts = new Product[]
{     
    new Product { Name = "Jeans", Category = "Clothing", Price = 24.7 },     
    new Product { Name = "Socks", Category = "Clothing", Price = 8.12 },     
    new Product { Name = "Scooter", Category = "Vehicle", Price = 99.99 },     
    new Product { Name = "Skateboard", Category = "Vehicle", Price = 24.99 },     
    new Product { Name = "Skirt", Category = "Clothing", Price = 17.5 }
};

int numberOfProds = myProducts.Count();
Console.WriteLine(numberOfProds);

IEnumerable<Product> productList = myProducts.OrderByDescending(prod => prod.Price);
foreach(Product prodsort in productList)
{
  Console.WriteLine(prodsort.Name);
}

double sumOfPrice = myProducts.Sum(s => s.Price);
Console.WriteLine("Sum of all prices is " + sumOfPrice);



// Numbers list for Practice

List<int> numbers = new List<int>() {2, 10, 19, 12, 5, 7 ,16};

// Numbers larger than 10
List<int> numsAboveTen = numbers.Where( num => num > 10).ToList();

// Largest Number
int largestNumber = numbers.Max();
Console.WriteLine("Largest number is: " + largestNumber);

foreach(int numba in numsAboveTen)
{
  Console.WriteLine(numba);
}
