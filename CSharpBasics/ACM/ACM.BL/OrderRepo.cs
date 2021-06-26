using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class OrderRepo
    {
        public Order Retrieve(int orderId)
        {
            Order odr = new Order(orderId);
            //Code that retieves defined customer 

            //Temporary hard coded
            if (orderId == 10)
            {
                odr.OrderDate = new DateTimeOffset(DateTime.Now.Year, 4, 14, 10, 00, 00, new TimeSpan(7, 0, 0));
            }
            Console.WriteLine($"Object: {odr.ToString()}");
            return odr;
        }

        public bool Save()
        {
            //Temporary hard coded
            return true;
        }
    }
}
