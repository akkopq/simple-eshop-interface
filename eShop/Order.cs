using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShop
{
    public class Order
    {
        public int ProductId { get; set; }
        public int Count { get; set; }


        public Order(int productId, int count)
        {
            ProductId = productId;
            Count = count;

        }

        public override bool Equals(object obj)
        {
            if (!(obj is Order))
            {
                return false;
            }
            Order order = obj as Order;

            return order.ProductId == ProductId && order.Count == Count;
        }

        public override string ToString()
        {
            return $"Product ID:{ProductId}; Quantity:{Count}";
        }
    }
}
