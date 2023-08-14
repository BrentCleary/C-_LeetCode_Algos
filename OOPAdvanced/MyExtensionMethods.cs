// Note the static keyword
public static class MyExtensionMethods
{
  // Note how the parameters for the new function is the previous class
  public static decimal TotalPrices(this ShoppingCart cartParam)
  {
        decimal total = 0;
        foreach (Product prod in cartParam.Products)
        {
            total += prod.Price;
        }
        return total;
  }
}

