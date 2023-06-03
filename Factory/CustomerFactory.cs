using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AOL_Code_1.Model;

namespace AOL_Code_1.Factory
{
    public class CustomerFactory
    {
        public static Customer createCustomer(string CustomerName, string CustomerEmail, string CustomerPassword, string CustomerGender, string CustomerAddress, string CustomerRole)
        {
            return new Customer
            {
                CustomerName = CustomerName,
                CustomerEmail = CustomerEmail,
                CustomerPassword = CustomerPassword,
                CustomerGender = CustomerGender,
                CustomerAddress = CustomerAddress,
                CustomerRole = CustomerRole
            };
            
        }
    }
}