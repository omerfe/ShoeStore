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
    }
}