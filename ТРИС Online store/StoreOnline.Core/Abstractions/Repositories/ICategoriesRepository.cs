using StoreOnline.Core.Models;

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
