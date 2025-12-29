using Microsoft.EntityFrameworkCore;
using StoreOnline.Core.Abstractions.Repositories;
using StoreOnline.Core.Models;
using StoreOnline.DataAccess.Entities;

namespace StoreOnline.DataAccess.Repositories
{
    public class CategoriesRepository(ApplicationDbContext context) : ICategoriesRepository
    {
        private readonly ApplicationDbContext context = context;

        public async Task<Guid> Create(Category category)
        {
            var categoryEntity = new CategoryEntity
            {
                Id = category.Id,
                Title = category.Title,
                Description = category.Description
            };

            await context.Categories.AddAsync(categoryEntity);
            await context.SaveChangesAsync();

            return categoryEntity.Id;
        }

        public async Task<List<Category>> Get()
        {
            var categoryEntities = await context.Categories
                .AsNoTracking()
                .ToListAsync();

            var categories = categoryEntities.Select(u => Category.Create(u.Id, u.Title, u.Description)).ToList();

            return categories;
        }

        public async Task<Guid> Update(Category category)
        {
            await context.Categories
                .Where(c => c.Id == category.Id)
                .ExecuteUpdateAsync(s => s
                .SetProperty(c => c.Title, c => category.Title)
                .SetProperty(c => c.Description, c => category.Description));

            return category.Id;
        }

        public async Task<Guid> Delete(Guid id)
        {
            await context.Categories
                .Where(c => c.Id == id)
                .ExecuteDeleteAsync();

            return id;
        }
    }
}
