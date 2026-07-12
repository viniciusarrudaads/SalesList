using System;
using System.Collections.Generic;
using System.Text;

namespace ListadeVendas
{
    public class Product
    {
        public string productName { get; set; }
        public decimal productPrice { get; set; }
        public int productQuantity { get; set; }
        

        public Product(string productName, decimal productPrice, int productQuantity)
        {
            this.productName= productName;
            this.productPrice= productPrice;
            this.productQuantity= productQuantity;
        }
    }
}
