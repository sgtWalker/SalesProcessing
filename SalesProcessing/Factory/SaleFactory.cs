using SalesProcessing.Entities;

namespace SalesProcessing.Factory
{
    public abstract class SaleFactory
    {
        public abstract Order CreateOrder(Product product);
    }
}
