using Microsoft.EntityFrameworkCore;
using StoreOnline.Core.Abstractions.Repositories;
using StoreOnline.Core.Models;
using StoreOnline.DataAccess.Entities;

namespace StoreOnline.DataAccess.Repositories
{
    public class PaymentsRepository(ApplicationDbContext context) : IPaymentsRepository
    {
        private readonly ApplicationDbContext context = context;

        public async Task<Guid> Create(Payment payment)
        {
            var paymentEntity = new PaymentEntity
            {
                Id = payment.Id,
                PaymentMethod = payment.PaymentMethod,
                CreatedDate = payment.CreatedDate,
                OrderId = payment.OrderId
            };

            await context.AddAsync(paymentEntity);
            await context.SaveChangesAsync();

            return paymentEntity.Id;
        }

        public async Task<Guid> Delete(Guid id)
        {
            await context.Payments
                .Where(p => p.Id == id)
                .ExecuteDeleteAsync();

            return id;
        }

        public async Task<List<Payment>> Get()
        {
            var paymentsEntities = await context.Payments
                .AsNoTracking()
                .Include(p => p.Order)
                .ToListAsync();

            var payments = paymentsEntities.Select(p => Payment.Create(
                p.Id,
                p.PaymentMethod,
                p.CreatedDate,
                p.OrderId))
                .ToList();

            return payments;
        }

        public async Task<Guid> Update(Payment payment)
        {
            await context.Payments
                .Where(p => p.Id == payment.Id)
                .ExecuteUpdateAsync(x => x
                    .SetProperty(p => p.PaymentMethod, p => payment.PaymentMethod)
                    .SetProperty(p => p.CreatedDate, p => payment.CreatedDate)
                    .SetProperty(p => p.OrderId, p => payment.OrderId));

            return payment.Id;
        }
    }
}
