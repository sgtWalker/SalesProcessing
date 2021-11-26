using System;
using SalesProcessing.Entities;

namespace SalesProcessing.Factory
{
    public class OrderFactory : SaleFactory
    {
        public override Order CreateOrder(Product product)
        {
            return new Order {
                Id = Guid.NewGuid(),
                OrderDate = DateTime.Now,
                Product = product
            };
        }
    }
}
