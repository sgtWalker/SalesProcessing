using System;
using System.Text;

namespace SalesProcessing.Entities
{
    public class Order
    {
        public Guid Id { get; set; }
        public DateTime OrderDate { get; set; }
        public Product Product { get; set; }

        public Order()
        {

        }

        public Order(Guid id, DateTime orderDate, Product product)
        {
            Id = id;
            OrderDate = orderDate;
            Product = product;
        }

        public string GetPrintOrder() 
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Order ID: {Id}");
            sb.AppendLine($"Order Date: {OrderDate:yyyy-MM-dd hh:mm:ss}");
            sb.AppendLine($"Product ID: {Product.Id}");
            sb.AppendLine($"Product Name: {Product.Name}");
            sb.AppendLine($"Product Price: {Product.Price}");
            sb.AppendLine($"Sold Amount: {Product.Quantity}");

            return sb.ToString();            
        }
    }
}
