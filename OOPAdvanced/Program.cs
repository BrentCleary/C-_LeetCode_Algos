
// Initializes Products from the Product class
Product macaroni = new Product(5);
Product chicken = new Product(10);

// Creates Instance of Shopping Cart
ShoppingCart myCart = new ShoppingCart();
myCart.Products = new List<Product>();

myCart.Products.Add(macaroni);
myCart.Products.Add(chicken);


decimal total = myCart.TotalPrices();
System.Console.WriteLine(total);