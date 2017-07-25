using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SSGeek.Models
{
    public class ShoppingCartItem
    {
        public Product Product { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public double TotalCost { get; set; }

        public double CalculateTotalCost()
        {
            TotalCost = Quantity * Product.Price;
            return TotalCost;
        }


    }



}