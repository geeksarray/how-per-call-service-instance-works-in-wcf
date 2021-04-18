using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PerCallServiceClient
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductServiceRef.ProductServiceClient client = new ProductServiceRef.ProductServiceClient();
            client.SetProductQty(10);
            Console.WriteLine(string.Format("Current Product Qty: {0}",client.GetProductQty()));
            Console.Read(); 
        }
    }
}
