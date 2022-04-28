using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingLibrary
{
    public class ShoppingCartItem
    {
        public string _nameOfItem;
        public double _priceOfItem;
       
        public ShoppingCartItem(string nameOfItem,double priceOfItem)
        {
             _nameOfItem = nameOfItem;
            _priceOfItem = priceOfItem;
        }

        public string ItemName
        { 
            get { return _nameOfItem; }
        }

        public double PriceOfItem
        {
            get { return _priceOfItem; }
        }
       
    }
}
