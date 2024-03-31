using NET_EF_CORE.data;
using NET_EF_CORE.models;

using PizzaContext context = new();

Product veggieSpecial = new()
{
  Name = "Veggie Special Pizza",
  Price = 9.99M
};

context.Products.Add(veggieSpecial);

Product deluxeMeat = new()
{
  Name = "Deluxe Meat Pizza",
  Price = 12.99M
};


context.Products.Add(deluxeMeat);
context.SaveChanges();