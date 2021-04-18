using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;

namespace PerCallService
{
    [ServiceContract(Name = "ProductService", Namespace = "http://northwind.com/productservice")]
    public interface IProductService
    {

        [OperationContract]
        void SetProductQty(int qty);

        [OperationContract]
        int GetProductQty();
    }
}
