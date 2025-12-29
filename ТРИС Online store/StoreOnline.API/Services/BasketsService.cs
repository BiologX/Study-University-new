using StoreOnline.Core.Abstractions.Repositories;
using StoreOnline.Core.Abstractions.Services;
using StoreOnline.Core.DTO;

namespace StoreOnline.API.Services
{
    public class BasketsService(IBasketsRepository basketsRepository) : IBasketsService
    {
        private readonly IBasketsRepository basketsRepository = basketsRepository;

        public async Task<Guid> AddToBasket(Basket basket)
        {
            return await basketsRepository.Create(basket);
        }

        public async Task<Guid> RemoveFromBasket(Guid id)
        {
            return await basketsRepository.Delete(id);
        }

        public async Task<List<Basket>> GetAllBasketItems()
        {
            return await basketsRepository.Get();
        }

        public async Task<Guid> UpdateBasketItem(Basket basket)
        {
            return await basketsRepository.Update(basket);
        }
    }
}