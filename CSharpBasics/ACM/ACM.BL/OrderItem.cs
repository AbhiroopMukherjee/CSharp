using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class OrderItem
    {
        public OrderItem()
        {

        }
        public OrderItem(int orderitemId)
        {
            OrderItemId = orderitemId;
        }
        public int OrderItemId { get; private set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public decimal? PurcahsePrice { get; set; }

        public bool Validate()
        {
            var isValid = true;
            if (Quantity < 0) isValid = false;
            if (ProductId < 0) isValid = false;
            if (PurcahsePrice==null) isValid = false;

            return isValid;
        }

        public OrderItem Retrieve()
        {
            return this;
        }

        public void Save()
        {

        }
    }
}
