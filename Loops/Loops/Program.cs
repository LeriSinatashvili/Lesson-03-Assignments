Console.WriteLine("Tell me you employee data and i will tell you things");


List<Product> ProductData = new List<Product>();


string MoreProducts = "";


do
{
    var product = new Product();


    Console.WriteLine("Tell me product name");
    product.ProductName = Console.ReadLine();

    Console.WriteLine("Tell me product price");
    product.ProductPrice = decimal.Parse(Console.ReadLine());

    Console.WriteLine("Tell me product quantity");
    product.ProductQuantity = int.Parse(Console.ReadLine());


    ProductData.Add(product);

    Console.WriteLine("Enter y if there are more products");
    MoreProducts = Console.ReadLine();

} 

while (MoreProducts == "y");


decimal TotalPrice = 0;

for (int i = 0; i < ProductData.Count; i++)
{

    var WriteData = ProductData[i];


    Console.WriteLine($"Here is totall price of {WriteData.ProductName} product");
    decimal TotalProductPrice = WriteData.ProductPrice * WriteData.ProductQuantity;
    Console.WriteLine(TotalProductPrice);

    TotalPrice = TotalPrice + TotalProductPrice;

}


Console.WriteLine("Here is tatall price of all products");
Console.WriteLine(TotalPrice);

class Product
{

    public string ProductName { get; set; }
    public decimal ProductPrice { get; set; }
    public int ProductQuantity { get; set; }

}
