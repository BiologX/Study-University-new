using StoreOnline.Core.Models;

namespace StoreOnline.Core.Abstractions.Services
{
    public interface IDeliveriesService
    {
        Task<Guid> CreateDelivery(Delivery delivery);
        Task<Guid> DeleteDelivery(Guid id);
        Task<List<Delivery>> GetAllDeliveries();
        Task<Guid> UpdateDelivery(Delivery delivery);
    }
}
