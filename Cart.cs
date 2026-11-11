public class Cart
{
    private int Quantity;
    private double FullPrice;
    private List<Product> ProductsList;    
    
    public Cart()
    {
        Quantity = 0;
        FullPrice = 0;
        ProductsList = new List<Product>();
    }
    
    public int GetQuantity()
    {
        return Quantity;
    }

    public double GetFullPrice()
    {
        return FullPrice;
    }

    public List<Product> GetProductsList()
    {
        return new List<Product>(ProductsList);
    }

    public void AddProduct(Product product)
    {
        Quantity++;
        FullPrice += product.GetPrice();
        ProductsList.Add(product);
    }

    public void RemoveProduct(Product product)
    {
        if (ProductsList.Remove(product))
        {
            Quantity--;
            FullPrice -= product.GetPrice();
        }
    }
    hahaha changes
}