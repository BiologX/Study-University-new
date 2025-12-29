using StoreOnline.Core.Models;

namespace StoreOnline.Core.Abstractions.Repositories
{
    public interface IPaymentsRepository
    {
        Task<Guid> Create(Payment payment);
        Task<Guid> Delete(Guid id);
        Task<List<Payment>> Get();
        Task<Guid> Update(Payment payment);
    }
}
