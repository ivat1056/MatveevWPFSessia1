using MatveevWPFSessia1.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatveevWPFSessia1
{
    public partial class Order
    {
        public string Orders
        {
            get
            {
                List<OrderProduct> products = Base.ep.OrderProduct.Where(x => x.OrderID == OrderID).ToList();
                string orderList = "";
                for (int i = 0; i < products.Count; i++)
                {
                    if (i == products.Count - 1)
                    {
                        orderList = orderList + products[i].Product.ProductName + " Количество: " + products[i].Count;
                    }
                    else
                    {
                        orderList = orderList + products[i].Product.ProductName + " Количество: " + products[i].Count + "\n";
                    }
                }
                return orderList;
            }
        }
    }
}
