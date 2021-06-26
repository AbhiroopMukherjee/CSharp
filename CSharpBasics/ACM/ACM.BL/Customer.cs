using Acme.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Customer:EntityBase, ILoggable
    {
        public Customer():this(0) //Constructor chaining
        {
            
        }

        public Customer(int customerId)
        {
            CustomerId = customerId;
            AddressList = new List<Address>();
        }
        public List<Address> AddressList { get; set; }
        public int CustomerId { get; private set; }
        public string EmailAddress { get; set; }

        public string FirstName { get; set; }

        public override string ToString() => FullName;
        public string FullName
        {
            get
            {
                string fn = FirstName;
                string ln = LastName;
                if (string.IsNullOrWhiteSpace(fn))
                {
                    return ln;
                }
                else if (string.IsNullOrWhiteSpace(ln))
                {
                    return fn;
                }
                else
                {
                    return LastName + "," + FirstName;
                }
                
            }
        }
        private string _lastname;
        public string LastName
        {
            get
            {
                return _lastname;
            }
            set
            {
                _lastname = value;
            }
        }

        public string Log() => $"{CustomerId} : {FullName} Email: {EmailAddress} Status: {EntityState.ToString()}";
        public override bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(FullName)) isValid = false;
            if (string.IsNullOrWhiteSpace(EmailAddress)) isValid = false;

            return isValid;
        }
    }
}
