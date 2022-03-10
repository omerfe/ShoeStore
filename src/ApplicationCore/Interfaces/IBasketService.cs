using ApplicationCore.Entities;
using System.Threading.Tasks;

namespace ApplicationCore.Interfaces
{
    public interface IBasketService
    {
        Task<Basket> AddItemToBasketAsync(int basketId, int productId, int quantity);
    }
}
