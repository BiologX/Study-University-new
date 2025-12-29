using StoreOnline.Core.DTO;

namespace StoreOnline.Core.Abstractions.Services
{
    public interface IBasketsService
    {
        Task<Guid> AddToBasket(Basket basket);
        Task<Guid> RemoveFromBasket(Guid id);
        Task<List<Basket>> GetAllBasketItems();
        Task<Guid> UpdateBasketItem(Basket basket);
    }
}