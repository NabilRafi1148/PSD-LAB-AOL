using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AOL_Code_1.Model;

namespace AOL_Code_1.Factory
{
    public class TransactionHeaderFactory
    {
        public static TransactionHeader createTransactionHeader(DateTime TransactionDate)
        {
            return new TransactionHeader
            {
                TransactionDate = TransactionDate
            };
        }
    }
}