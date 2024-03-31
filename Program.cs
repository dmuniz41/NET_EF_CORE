using NET_EF_CORE.data;
using NET_EF_CORE.models;

using PizzaContext context = new();

var products = context.Products
                      .Where(p => p.Price > 10.00M)
                      .OrderBy(p => p.Name);

foreach (Product p in products)
{
  Console.WriteLine($"Id:       {p.Id}");
  Console.WriteLine($"Name:     {p.Name}");
  Console.WriteLine($"Price:    {p.Price}");
  Console.WriteLine(new string('-', 20));
}


// Product veggieSpecial = new()
// {
//   Name = "Veggie Special Pizza",
//   Price = 9.99M
// };

// context.Products.Add(veggieSpecial);

// Product deluxeMeat = new()
// {
//   Name = "Deluxe Meat Pizza",
//   Price = 12.99M
// };


// context.Products.Add(deluxeMeat);
// context.SaveChanges();

