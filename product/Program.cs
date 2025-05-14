// See https://aka.ms/new-console-template for more information

using System.Diagnostics;

List <product> lstproduct= new List<product>();

product p1 = new product();
p1.ProductId = 1;
p1.ProductType = "electronics";
p1.BrandName = "phillips";
p1.Price = 100;
p1.DiscountedPrice = 90;
lstproduct.Add(p1);

lstproduct.Add(new product
{
    ProductId=2, ProductType = "electronics",BrandName = "reliance",Price = 150,DiscountedPrice = 130,
});

lstproduct.Add(new product
{
    ProductId = 3,ProductType = "electronics",BrandName = "lg",Price = 130,DiscountedPrice = 110,
});

lstproduct.Add(new product
{
    ProductId = 4,ProductType = "Bakery",BrandName = "moti Bakery",Price = 200,DiscountedPrice = 180,
});

lstproduct.Add(new product
{
    ProductId = 5,ProductType = "Bakery",BrandName = "john",Price = 300,DiscountedPrice = 280,
});

lstproduct.Add(new product
{
    ProductId = 6,ProductType = "Bakery",BrandName = "william",Price = 250,DiscountedPrice = 230,
});

lstproduct.Add(new product
{
    ProductId = 7,ProductType = "Grocery",BrandName = "D-Mart",Price = 500,DiscountedPrice = 450,
});

lstproduct.Add(new product
{
    ProductId = 8,ProductType = "Grocery",BrandName = "Blinkit",Price = 300,DiscountedPrice = 290,
});

lstproduct.Add(new product
{
    ProductId = 9,ProductType = "Grocery",BrandName = "reliance",Price = 400,DiscountedPrice = 380,
});

lstproduct.Add(new product
{
    ProductId = 10,ProductType = "medical",BrandName = "sun pharma",Price = 1000,DiscountedPrice = 970,
});


Console.WriteLine("count of total product " + lstproduct.Count()); 

Console.WriteLine("count of electronics products "+lstproduct.Where(x=>x.ProductType=="electronics").Count());    

Console.WriteLine("Maximum discounted price " + lstproduct.Max(x=>x.DiscountedPrice)); 

Console.WriteLine("minimum price of grocery " + lstproduct.Where(x => x.ProductType == "Grocery").Min(x => x.Price)); 

Console.WriteLine("get producttype by BrandName " + lstproduct.Where(x => x.BrandName == "lg").Select(x => x.ProductType).FirstOrDefault()); 

Console.WriteLine("get total brand count " + lstproduct.Select(x => x.BrandName).Distinct().Count()); 

Console.WriteLine("get maximum price by brand " + lstproduct.Where(x => x.BrandName == "reliance").Max(x => x.Price));

Console.WriteLine("find last record of electronics product type = " + (lstproduct.Last(x=>x.ProductType=="electronics")));

public class product
{
    public int ProductId { get; set; }
    public string ProductType { get; set; }
    public string BrandName { get; set; }
    public int Price { get; set; }
    public int DiscountedPrice { get; set; }

    public override string ToString()
    {
        return $"ProductId: {ProductId}, ProductType: {ProductType}, BrandName: {BrandName}, Price: {Price}, DiscountedPrice: {DiscountedPrice}";
    }
}
