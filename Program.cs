Cart cart = new Cart(); //יצירת עגלה

Product[] products = //יצירת מוצרים
{
    new Product("Milk", 6.5),
    new Product("Banana", 3.5),
    new Product("Cofee", 5),
    new Product("Shampoo", 10.9),
    new Product("water", 3)
};

foreach (Product p in products) //הוספת המוצרים לעגלה
{
    cart.AddProduct(p);
}

List<Product> cartProducts = cart.GetProductsList(); //יצירת רשימה למוצרים בעגלה

for (int i = 0; i < cartProducts.Count; i++) //הדפסה של העגלה עם פור
{
    Console.WriteLine($"{cartProducts[i].GetName()}: {cartProducts[i].GetPrice()}$");
}
Console.WriteLine(); //הדפסת שורה ריקה לשמירה על סדר באאוטפוט

foreach (Product p in cartProducts) //הדפסה של העגלה עם פוראיץ
{
    Console.WriteLine($"{p.GetName()}: {p.GetPrice()}$");  
}
Console.WriteLine(); //הדפסת שורה ריקה לשמירה על סדר באאוטפוט

cart.RemoveProduct(cartProducts[1]); //הורדה של מוצרים
cart.RemoveProduct(cartProducts[3]);

foreach (Product p in cartProducts) //הדפסה של מה שנותר בעגלה
{
    Console.WriteLine($"{p.GetName()}: {p.GetPrice()}$");  
}
Console.WriteLine(); //הדפסת שורה ריקה לשמירה על סדר באאוטפוט

Console.WriteLine($"Total Price: {cart.GetFullPrice() + 0.18 * cart.GetFullPrice()}$"); //הדפסת המחיר הסופי בתוספת 18 אחוז מעמ