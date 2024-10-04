using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShop
{
    public class ProductList
    {
        public List<Product> Products;

        public double TotalPrice { get; set; }

        public ProductList()
        {
            Products = new List<Product>();
        }

        public void Add(Product products)
        {
            if (!Products.Contains(products))
            {
                Products.Add(products);

            }
        }

        public void Remove(Product products)
        {
            if (Products.Contains(products))
            {
                Products.Remove(products);

            }

        }

        public override string ToString()
        {
            string result = string.Empty;
            foreach (Product product in Products)
            {
                result = result + product.ToString() + Environment.NewLine;
            }
            return result;
        }
        public void SortByName()
        {
            Products = Products.OrderBy(p => p.Name).ToList();
        }

        public Product SearchByName(string name)
        {
            return Products.FirstOrDefault(x => x.Name == name);
        }

        public Product SearchById(int productId)
        {
            return Products.FirstOrDefault(x => x.Id == productId);
        }

        public Product SearchByPrice(int price)
        {
            return Products.FirstOrDefault(x => x.Price == price);
        }


        public void SortByPrice()
        {
            Products = Products.OrderBy(prod => prod.Price).ToList();
        }
        public void SortByDate()
        {

            Products = Products.OrderBy(prod => DateTime.Parse(prod.ManufacturerDate)).ToList();
        }
        public void SaveProduct()
        {
            string filePath = ConfigurationManager.AppSettings["FilePath"];

            if (!Directory.Exists(filePath))
            {
                Directory.CreateDirectory(filePath);
            }

            var jsonText = JsonConvert.SerializeObject(Products);

            File.WriteAllText(Path.Combine(filePath, "ProductList.json"), jsonText);
        }
        public ProductList Combine(int typeid)
        {
            ProductList Prod;
            Prod = new ProductList();
            foreach (Product p in Products)
                if (p.TypeId == typeid)
                    Prod.Add(p);
            return Prod;
        }

        public void LoadProduct()
        {
            string filePath = ConfigurationManager.AppSettings["FilePath"];
            string jsonFilePath = Path.Combine(filePath, "ProductList.json");

            if (!File.Exists(jsonFilePath))
            {
                return;
            }

            Products = JsonConvert.DeserializeObject<List<Product>>(File.ReadAllText(jsonFilePath));
        }


    }
}

