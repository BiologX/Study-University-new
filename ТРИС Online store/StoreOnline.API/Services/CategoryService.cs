using StoreOnline.Core.Abstractions.Repositories;
using StoreOnline.Core.Abstractions.Services;
using StoreOnline.Core.Models;

namespace StoreOnline.API.Services
{
    public class CategoryService(ICategoriesRepository categoriesRepository) : ICategoriesService
    {
        private readonly ICategoriesRepository categoriesRepository = categoriesRepository;

        public async Task<Guid> CreateCategory(Category category)
        {
            return await categoriesRepository.Create(category);
        }

        public async Task<Guid> DeleteCategory(Guid id)
        {
            return await categoriesRepository.Delete(id);
        }

        public async Task<List<Category>> GetAllCategories()
        {
            return await categoriesRepository.Get();
        }

        public async Task<Guid> UpdateCategory(Category category)
        {
            return await categoriesRepository.Update(category);
        }
    }
}