﻿using ApplicationCore.Entities;
using System.Threading.Tasks;
using Web.Models;

namespace Web.Interfaces
{
    public interface IBasketViewModelService
    {
        Task<BasketViewModel> GetBasketViewModelAsync();
        Task<int> GetBasketItemsCountAsync();
        Task<string> GetOrCreateBuyerId();
        Task<Basket> GetOrCreateBasketAsync();
        Task<BasketViewModel> AddToBasketAsync(int productId, int quantity);
    }
}
