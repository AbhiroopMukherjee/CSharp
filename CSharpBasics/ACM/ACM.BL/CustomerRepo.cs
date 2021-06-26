using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class CustomerRepo
    {
        public CustomerRepo()
        {
            addressrepository = new AddressRepo();
        }
        private AddressRepo addressrepository { get; set; }
        public Customer Retrieve(int customerId)
        {
            Customer cust = new Customer(customerId);
            //Code that retieves defined customer 
            //Temporary hard coded

            if (customerId == 1)
            {
                cust.EmailAddress = "Abhi@yahoo.com";
                cust.FirstName = "Abhiroop";
                cust.LastName = "Mukherjee";
                cust.AddressList = addressrepository.RetrieveByCustomerId(customerId).ToList();
            }
            return cust;
        }

        public bool Save()
        {
            //Temporary hard coded
            return true;
        }
    }
}
