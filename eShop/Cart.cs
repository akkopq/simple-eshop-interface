using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShop
{
    public class Cart
    {
        public List<Order> Orders;

        ProductList products;

        public int TotalPrice { get; set; }

        public Cart()
        {
            Orders = new List<Order>();
            products = new ProductList();

        }

        public Cart(int totalPrice)
        {
            TotalPrice = totalPrice;
        }

        public void Add(Order order)
        {
            if (!Orders.Contains(order))
            {
                Orders.Add(order);
            }
        }

        public void Remove(Order order)
        {
            if (Orders.Contains(order))
            {
                Orders.Remove(order);
            }
        }

        public Order GetById(int id)
        {
            foreach (Order c in Orders)
            {
                if (c.ProductId == id)
                {
                    return c;
                }
            }
            return null;
        }

        public override string ToString()
        {
            string result = string.Empty;
            foreach (Order order in Orders)
            {
                result = result + order.ToString() + Environment.NewLine;
            }
            return result;
        }

        public void SaveOnDiskOrder(int i)
        {
            string filePath = ConfigurationManager.AppSettings["FilePath"];

            if (!Directory.Exists(filePath))
            {
                Directory.CreateDirectory(filePath);
            }

            var jsonText = JsonConvert.SerializeObject(Orders);

            File.WriteAllText(Path.Combine(filePath, i + "Orders.json"), jsonText);
        }
        public void AlreadyHere(Order ord)
        {

            foreach (Order o in Orders)
            {
                if (o.ProductId == ord.ProductId)
                    o.Count += ord.Count;
                else Orders.Add(ord);

            }

        }

        public void RemoveHere(Order ord)
        {

            foreach (Order o in Orders)
            {
                if (o.ProductId == ord.ProductId && o.Count > 1)
                    o.Count -= ord.Count;
                else Orders.Remove(ord);

            }

        }
        public void LoadFromDiskOrder(int i)
        {
            string filePath = ConfigurationManager.AppSettings["FilePath"];
            string jsonFilePath = Path.Combine(filePath, i + "Orders.json");

            if (!File.Exists(jsonFilePath))
            {
                return;
            }

            Orders = JsonConvert.DeserializeObject<List<Order>>(File.ReadAllText(jsonFilePath));
        }

        public void DeleteOrd()
        {
            string filePath = ConfigurationManager.AppSettings["FilePath"];
            File.Delete(Path.Combine(filePath, "Orders.json"));

        }

        public int Calc(int r)
        {

            products.LoadProduct();
            Product s = products.SearchById(r);
            return (int)s.Price;

        }

    }
}
