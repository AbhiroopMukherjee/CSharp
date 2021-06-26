using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    class AddressRepo
    {
        public Address Retrieve(int addressId)
        {
            Address addr = new Address(addressId);
            //Code that retieves defined address 

            //Temporary hard coded
            if (addressId == 1)
            {
                addr.AddressType = 1;
                addr.StreetLine1 = "street1";
                addr.StreetLine2 = "street2";
                addr.City = "kolkata";
                addr.State = "WB";
                addr.Country = "India";
                addr.PostalCode = "560035";
                               
            }
            return addr;
        }

        public IEnumerable<Address> RetrieveByCustomerId(int customerId)
        {
            List<Address> addresslist = new List<Address>();
            Address address = new Address(1)
            {
                AddressType = 1,
                StreetLine1 = "street11",
                StreetLine2 = "street22",
                City = "kolkata2",
                State = "WB2",
                Country = "India2",
                PostalCode = "560036"
            };
            addresslist.Add(address);
            address = new Address(2)
            {
                AddressType = 2,
                StreetLine1 = "street111",
                StreetLine2 = "street222",
                City = "kolkata22",
                State = "WB22",
                Country = "India22",
                PostalCode = "560037"
            };
            addresslist.Add(address);

            return addresslist;
        }

        public bool Save(Address addr)
        {
            //Temporary hard coded
            return true;
        }
    }
}
