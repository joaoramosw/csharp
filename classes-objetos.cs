var p = new Product("Teclado", 200);

p.ApplyDiscount(20);

Console.WriteLine(p.Price);

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }

    public Product(string name, decimal price)
    {
        this.Name = name;
        this.Price = price;
    }

    public void ApplyDiscount(decimal percentual)
    {
        Price -= Price * percentual / 100;
    }
}