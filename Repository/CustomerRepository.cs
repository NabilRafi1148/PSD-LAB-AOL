using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AOL_Code_1.Model;
using AOL_Code_1.Factory;


namespace AOL_Code_1.Repository
{
    public class CustomerRepository
    {
        Database1Entities db = new Database1Entities();
        public void addCustomer(string CustomerName, string CustomerEmail, string CustomerPassword, string CustomerGender, string CustomerAddress, string CustomerRole)
        {
            db.Customers.Add(CustomerFactory.createCustomer(CustomerName, CustomerEmail, CustomerPassword, CustomerGender, CustomerAddress, CustomerRole));
            db.SaveChanges();
        }

        public void deleteCustomer(int CustomerID)
        {
            Customer customer = db.Customers.Where(x => x.CustomerID == CustomerID).FirstOrDefault();

            db.Customers.Remove(customer);
            db.SaveChanges();
                    
        }

        public void updateCustomer(int CustomerID, string CustomerName, string CustomerEmail, string CustomerPassword, string CustomerGender, string CustomerAddress, string CustomerRole)
        {
            Customer customer = db.Customers.Where(x => x.CustomerID == CustomerID).FirstOrDefault();
            customer.CustomerName = CustomerName;
            customer.CustomerEmail = CustomerEmail;
            customer.CustomerPassword = CustomerPassword;
            customer.CustomerGender = CustomerGender;
            customer.CustomerAddress = CustomerAddress;
            customer.CustomerRole = CustomerRole;
            db.SaveChanges();
        }
    }
}