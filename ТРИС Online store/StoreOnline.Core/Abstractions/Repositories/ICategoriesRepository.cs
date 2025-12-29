using StoreOnline.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreOnline.Core.Abstractions.Repositories
{
    public interface ICategoriesRepository
    {
        Task<Guid> Create(Category category);
        Task<Guid> Delete(Guid id);
        Task<List<Category>> Get();
        Task<Guid> Update(Category category);
    }
}
