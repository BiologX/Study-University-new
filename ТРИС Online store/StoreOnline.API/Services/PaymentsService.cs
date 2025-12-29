using StoreOnline.Core.Abstractions.Repositories;
using StoreOnline.Core.Abstractions.Services;
using StoreOnline.Core.Models;

namespace StoreOnline.API.Services
{
    public class PaymentsService(IPaymentsRepository paymentsRepository) : IPaymentsService
    {
        private readonly IPaymentsRepository paymentsRepository = paymentsRepository;

        public async Task<Guid> CreatePayment(Payment payment)
        {
            return await paymentsRepository.Create(payment);
        }

        public async Task<Guid> DeletePayment(Guid id)
        {
            return await paymentsRepository.Delete(id);
        }

        public async Task<List<Payment>> GetAllPayments()
        {
            return await paymentsRepository.Get();
        }

        public async Task<Guid> UpdatePayment(Payment payment)
        {
            return await paymentsRepository.Update(payment);
        }
    }
}