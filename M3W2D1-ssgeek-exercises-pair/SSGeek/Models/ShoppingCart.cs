using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SSGeek.Models
{
    public class ShoppingCart
    {
        public List<ShoppingCartItem> Cart { get; set; } = new List<ShoppingCartItem>();
        public double GrandTotal { get; set; }


        public void AddItem(ShoppingCartItem item)
        {
            int count = 0;
            for(int x=0; x<Cart.Count;x++)
            {
                if(Cart[x].Product.ProductId == item.Product.ProductId)
                {
                    Cart[x].Quantity += item.Quantity;
                    count += 1;
                    break;
                }
            }
            if(count != 1)
            {
                Cart.Add(item);
            }
        }

        public double CalculateGrandTotal()
        {
            foreach(ShoppingCartItem item in Cart)
            {
                GrandTotal += item.TotalCost;
            }
            return GrandTotal;
        }
    }
}