using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AOL_Code_1.Model;

namespace AOL_Code_1.Factory
{
    public class CartFactory
    {
        public static Cart createCart(int Qty)
        {
            return new Cart
            {
                Qty = Qty
            };
        }
    }
}