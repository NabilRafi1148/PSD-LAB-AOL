using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AOL_Code_1.Model;

namespace AOL_Code_1.Factory
{
    public class TransactionDetailFactory
    {
        public static TransactionDetail createTransactionDetail(int Qty)
        {
            return new TransactionDetail
            {
                Qty = Qty
            };
        }
    }
}