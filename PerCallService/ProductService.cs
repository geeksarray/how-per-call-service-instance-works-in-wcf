using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;

namespace PerCallService
{
    [ServiceBehavior(Name = "ProductService", Namespace = "http://northwind.com/productservice",
        InstanceContextMode = InstanceContextMode.PerCall)]
    public class ProductService : IProductService
    {
        public void SetProductQty(int qty)
        {
            this.ProductQty = qty;
        }

        public int GetProductQty()
        {
            return this.ProductQty;
        }

        private int ProductQty
        {
            get;
            set;
        }
    }
}
