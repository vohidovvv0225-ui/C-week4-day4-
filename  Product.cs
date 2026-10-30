class Product
{
    public string name;
    public double price;
    public int quantity;

    public Product(string name, double price, int quantity)
    {
        this.name = name;
        this.price = price;
        this.quantity = quantity;
    }

    public void PrintProduct()
    {
        Console.WriteLine($"{name}: price {price}: {quantity} pcs");
    }
}


