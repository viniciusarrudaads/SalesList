namespace SalesList.Services;

using SalesList.Entities;

public class ProductServices
{
    public static decimal TotalValue(List<Product> list)
    {
        decimal totalValue = 0M;
        decimal totalIndividual = 0M;
        for (int i = 0; i < list.Count; i++)
        {
            totalIndividual = list[i].ProductPrice * list[i].QuantitySold;

            totalValue += totalIndividual;
        }
        return totalValue;
    }

    public static decimal TotalMedia(Product product, List<Product> list)
    {
        decimal totalMedia = 0M;

        for (int i = 0; i < list.Count; i++)
        {

            totalMedia = (TotalValue(list) / list.Count);
        }

        return totalMedia;
    }

    public static string MoreExpensive(List<Product>list)
    {
        decimal expansiveQuantity = 0M;
        string moreExpansive = string.Empty;

        for(int i = 0; i<list.Count;i++)
        {
            if (list[i].ProductPrice > expansiveQuantity)
            {
                expansiveQuantity = list[i].ProductPrice;
                moreExpansive = list[i].ProductName;
            }
        }
        return moreExpansive;
    }

    public static string Cheaper(List<Product> list)
    {
        decimal cheaperQuantity = decimal.MaxValue;
        string moreCheaper = string.Empty;

        for (int i = 0; i < list.Count; i++)
        {
            if (list[i].ProductPrice < cheaperQuantity)
            {
                cheaperQuantity = list[i].ProductPrice;
                moreCheaper = list[i].ProductName;
            }
        }
        return moreCheaper;

    }

}
