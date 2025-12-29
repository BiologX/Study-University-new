using StoreOnline.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreOnline.Core.Abstractions.Repositories
{
    public interface IOrdersRepository
    {
        Task<Guid> Create(Order order);
        Task<Guid> Delete(Guid id);
        Task<List<Order>> Get();
        Task<Guid> Update(Order order);
    }
}
