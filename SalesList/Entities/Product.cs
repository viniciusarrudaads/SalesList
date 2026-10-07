
namespace SalesList.Entities;

public class Product
{
    public string ProductName { get; set; } = string.Empty;
    public int QuantitySold { get; set; }
    public decimal ProductPrice { get; private set; }

    public Product() { }
    public Product(string name, int quantity, decimal price)
    {
        ProductName = name;
        QuantitySold = quantity;
        ProductPrice = price;
    }
}
