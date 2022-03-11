using ApplicationCore.Entities;
using Ardalis.Specification;
using System.Linq;

namespace ApplicationCore.Specifications
{
    public class BasketWithItemsSpecification : Specification<Basket>
    {
        public BasketWithItemsSpecification(int basketId)
        {
            Query.Where(x => x.Id.Equals(basketId))
                .Include(x => x.Items)
                .ThenInclude(x => x.Product);
        }
        public BasketWithItemsSpecification(string buyerId)
        {
            Query.Where(x => x.BuyerId.Equals(buyerId))
                .Include(x => x.Items)
                .ThenInclude(x => x.Product);
        }
    }
}