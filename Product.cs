public class Product 
{
    private readonly string Name;
    private readonly double Price;

    public Product(string name, double price)
    {
        if (price > 0) 
        {
            Price = price;
            Name = name;
        }
        else throw new Exception("Price must be positive");
    }

    public string GetName()
    {   
        return Name;
    }

    public double GetPrice()
    {
        return Price;
    }
    
} 