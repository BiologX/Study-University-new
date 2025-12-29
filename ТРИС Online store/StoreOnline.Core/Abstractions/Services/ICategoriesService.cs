using StoreOnline.Core.Models;

namespace StoreOnline.Core.Abstractions.Services
{
    public interface ICategoriesService
    {
        Task<Guid> CreateCategory(Category user);
        Task<Guid> DeleteCategory(Guid id);
        Task<List<Category>> GetAllCategory();
        Task<Guid> UpdateCategory(Category user);
    }
}
