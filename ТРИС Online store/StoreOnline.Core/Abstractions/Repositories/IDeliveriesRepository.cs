using StoreOnline.Core.Models;

namespace StoreOnline.Core.Abstractions.Repositories
{
    public interface IDeliveriesRepository
    {
        Task<Guid> Create(Delivery delivery);
        Task<Guid> Delete(Guid id);
        Task<List<Delivery>> Get();
        Task<Guid> Update(Delivery delivery);
    }
}
