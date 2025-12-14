using Microsoft.EntityFrameworkCore;
using StoreOnline.Core.Abstractions.Repositories;
using StoreOnline.Core.Models;
using StoreOnline.DataAccess.Entities;

namespace StoreOnline.DataAccess.Repositories
{
    public class UsersRepository(ApplicationDbContext context) : IUsersRepository
    {
        private readonly ApplicationDbContext context = context;

        public async Task<Guid> Create(User user)
        {
            var userEntity = new UserEntity
            {
                Id = user.Id,
                Name = user.Name,
                Login = user.Login,
                PasswordHash = user.PasswordHash
            };

            await context.Users.AddAsync(userEntity);
            await context.SaveChangesAsync();

            return userEntity.Id;
        }

        public async Task<List<User>> Get()
        {
            var userEntities = await context.Users
                .AsNoTracking()
                .ToListAsync();

            var users = userEntities.Select(u => User.Create(u.Id, u.Name, u.Login, u.PasswordHash))
            .ToList();

            return users;
        }

        public async Task<Guid> Update(Guid id, string name, string login, string passwordHash)
        {
            await context.Users 
                .Where(u => u.Id == id)
                .ExecuteUpdateAsync(s => s
                .SetProperty(u => u.Name, u => name)
                .SetProperty(u => u.Login, u => login)
                .SetProperty(u => u.PasswordHash, u => passwordHash));

            return id;
        }

        public async Task<Guid> Delete(Guid id)
        {
            await context.Users
                .Where(u => u.Id == id)
                .ExecuteDeleteAsync();

            return id;
        }
    }
}
