using StoreOnline.Core.DTO;

namespace StoreOnline.Core.Abstractions.Services
{
    public interface IPaymentsService
    {
        Task<Guid> CreatePayment(Payment payment);
        Task<Guid> DeletePayment(Guid id);
        Task<List<Payment>> GetAllPayments();
        Task<Guid> UpdatePayment(Payment payment);
    }
}
