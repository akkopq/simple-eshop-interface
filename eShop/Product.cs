using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShop
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string ManufacturerDate { get; set; }
        public int TypeId { get; set; }
        public string ExpirationDate { get; set; }

        public Product(int id, string name, string description, decimal price, string manufacturerDate, int typeId, string expirationDate)
        {
            Id = id;
            Name = name;
            Description = description;
            Price = price;
            ManufacturerDate = manufacturerDate;
            TypeId = typeId;
            ExpirationDate = expirationDate;
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Product))
            {
                return false;
            }
            Product product = obj as Product;

            return product.Id == Id && product.Name == Name && product.Description == Description && product.Price == Price
                && product.ManufacturerDate == ManufacturerDate && product.TypeId == TypeId && product.ExpirationDate == ExpirationDate;
        }

        public override string ToString()
        {
            return $"ID:{Id};{Name};{Description};{Price};{ManufacturerDate};{TypeId};{ExpirationDate}";
        }
    }
}
