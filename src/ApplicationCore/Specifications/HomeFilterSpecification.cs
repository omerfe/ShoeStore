using ApplicationCore.Entities;
using Ardalis.Specification;
using System.Linq;

namespace ApplicationCore.Specifications
{
	public class HomeFilterSpecification : Specification<Product>
	{
		public HomeFilterSpecification(int? categoryId, int? brandId)
		{
			if (categoryId.HasValue)
				Query.Where(x => x.CategoryId == categoryId);
			if (brandId.HasValue)
				Query.Where(x => x.BrandId == brandId);
		}
	}
}