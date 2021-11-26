using System;
using System.Globalization;
using SalesProcessing.Entities;
using SalesProcessing.Factory;

namespace SalesProcessing
{
    class Program
    {
        static void Main(string[] args)
        {
            SaleFactory sale = new OrderFactory();
            var order = sale.CreateOrder(RequestProduct());
            Console.WriteLine();
            Console.WriteLine(order.GetPrintOrder());
        }

        public static Product RequestProduct()
        {
            Console.WriteLine("Enter the sale data:");
            Console.Write("Product ID: ");
            var productId = Guid.Parse(Console.ReadLine());
            
            Console.Write("Product Name: ");
            var productName = Console.ReadLine();
            
            Console.Write("Sold Amount: ");
            var produtctQuantity = int.Parse(Console.ReadLine());
            
            Console.Write("Product Price: ");
            var productPrice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            return new Product(productId, productName, produtctQuantity, productPrice);
        }
    }
}
