using ShoppingLibrary;
using System;
using System.Collections.Generic;

namespace ShoppingCartApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ShoppingCart shoppingcart = new ShoppingCart();

            var item1 = new ShoppingCartItem("Xbox",3950.99);
            shoppingcart.ShoppingList(item1);

            item1 = new ShoppingCartItem("PS4", 5999.49);
            shoppingcart.ShoppingList(item1);


            //can add another item to shoppingcart
            //item1 = new ShoppingCartItem("Switch", 7999.99);
            //shoppingcart.ShoppingList(item1);

            List<ShoppingCartItem> itemProduct = shoppingcart.ShoppingCartItems();
            foreach(ShoppingCartItem product in itemProduct)
            {
                Console.Write(product.ItemName +"\t\t");
                Console.WriteLine(product.PriceOfItem);
            }

            Console.WriteLine("Sub Total: \t" + shoppingcart.GetSubTotal());
            Console.WriteLine("With VAT: \t" + shoppingcart.GetVat());

        }
    }
}
