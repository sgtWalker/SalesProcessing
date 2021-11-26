using System;

namespace SalesProcessing.Entities
{
    public class Product
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }

        public Product()
        {

        }

        public Product(Guid id, string name, int quantity, double price)
        {
            Id = id;
            Name = name;
            Price = price;
            Quantity = quantity;
        }

    }
}
