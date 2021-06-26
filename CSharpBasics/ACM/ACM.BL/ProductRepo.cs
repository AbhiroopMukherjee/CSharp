using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class ProductRepo
    {
        public Product Retrieve(int productId)
        {
            Product pr = new Product(productId);
            //Code that retieves defined customer 

            //Temporary hard coded
            if (productId == 2)
            {
                pr.ProductName = "Sunflowers";
                pr.ProductDescription = "Mini sunflowers";
                pr.CurrentPrince = 15.96M;

            }
            object myobject = new object();
            Console.WriteLine($"Object: {myobject.ToString()}");
            Console.WriteLine($"Object: {pr.ToString()}");
            return pr;
        }

        public bool Save(Product product)
        {
            var success = true;

            if (product.HasChanges)
            {
                if (product.IsValid)
                {
                    if (product.IsNew)
                    {
                        //call an insert stored procedure
                    }
                    else
                    {
                        //call an update stored procedure
                    }
                }
                else
                {
                    success = false;
                }
            }
            return success;
        }
    }
}
