using System.Collections.Generic;
using System;

namespace ShoppingLibrary
{
   
    public class ShoppingCart
    {

        List<ShoppingCartItem> _items = new List<ShoppingCartItem>();

        public void ShoppingList(ShoppingCartItem item)
        {
            _items.Add(item);
        }
        
        public double GetSubTotal()
        {
            double total = 0;

            foreach (ShoppingCartItem item in _items)
            {
                total = total + item.PriceOfItem; 
            }
            return total;
        }
        public double GetVat()
        {
            double vat = 0;

            vat += 1.15 * GetSubTotal();

            return vat;
        }

        public List<ShoppingCartItem>ShoppingCartItems()
        {
            return _items;
        }


    }
}
