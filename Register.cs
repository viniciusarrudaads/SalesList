using System;
using System.Collections.Generic;
using System.Text;

namespace ListadeVendas
{
    internal class Register
    {


        public static void productRegister(List<Product> list)
        {
            Console.WriteLine("How many products you are going to register? ");

            int quantity = int.Parse(Console.ReadLine());

            for(int i= 0; i < quantity; i++)
            {
                Console.WriteLine(i+1 + "# PRODUCT REGISTRATION! ");

                Console.WriteLine("# PRODUCT NAME! ");
                string productName = Console.ReadLine();

                Console.WriteLine("# PRODUCT PRICE! ");
                decimal productPrice = decimal.Parse(Console.ReadLine());

                Console.WriteLine("# PRODUCT QUANTITY");
                int productQuantity = int.Parse(Console.ReadLine());

                Product product = new Product(productName, productPrice,productQuantity);
            }

        }
    }
}
