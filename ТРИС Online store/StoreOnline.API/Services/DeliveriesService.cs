using StoreOnline.Core.Abstractions.Repositories;
using StoreOnline.Core.Abstractions.Services;
using StoreOnline.Core.DTO;

namespace StoreOnline.API.Services
{
    public class DeliveriesService(IDeliveriesRepository deliveriesRepository) : IDeliveriesService
    {
        private readonly IDeliveriesRepository deliveriesRepository = deliveriesRepository;

        public async Task<Guid> CreateDelivery(Delivery delivery)
        {
            return await deliveriesRepository.Create(delivery);
        }

        public async Task<Guid> DeleteDelivery(Guid id)
        {
            return await deliveriesRepository.Delete(id);
        }

        public async Task<List<Delivery>> GetAllDeliveries()
        {
            return await deliveriesRepository.Get();
        }

        public async Task<Guid> UpdateDelivery(Delivery delivery)
        {
            return await deliveriesRepository.Update(delivery);
        }
    }
}