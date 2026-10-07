namespace SalesList;

using SalesList.Entities;
using SalesList.Services;


    class Program
{
    static void Main(string[] args)
    {
        List<Product> list = new List<Product>();
        Product product = new Product();

        Console.WriteLine("=======================");
        Console.WriteLine("RELATÓRIO DE VENDAS: ");
        Console.WriteLine("\n=======================");

        Console.WriteLine();

        Console.WriteLine("How many products you want to register? ");
        int n = int.Parse(Console.ReadLine());

        while (n <= 0)
        {
            Console.WriteLine("Invalid quantity, type again!");
            n = int.Parse(Console.ReadLine());
        }

        for(int i = 0; i < n; i++)
        {
            Console.WriteLine("PRODUCT #"+ (i+1));

            Console.WriteLine("PRODUCT NAME: ");
            string? name = Console.ReadLine();

            Console.WriteLine("QUANTITY SOLD: ");
            int quantity = int.Parse(Console.ReadLine());
            while(quantity <= 0)
            {
               Console.WriteLine("Invalid quantity, type again!");
                quantity = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("PRODUCT PRICE: ");
            decimal price = decimal.Parse(Console.ReadLine());

            product = new Product(name, quantity, price);

            list.Add(product);
        }

      
        Console.WriteLine("TOTAL DE VENDAS: " + ProductServices.TotalValue(list));
        Console.WriteLine("PRODUTO MAIS CARO: "+ ProductServices.MoreExpensive(list));
        Console.WriteLine("PRODUTO MAIS BARATO: "+ ProductServices.Cheaper(list));
        Console.WriteLine($"MÉDIA DE VALOR POR VENDA:"+ ProductServices.TotalMedia(product,list).ToString("F2")); 
    }


}