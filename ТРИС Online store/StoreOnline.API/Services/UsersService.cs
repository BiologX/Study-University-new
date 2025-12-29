using StoreOnline.Core.Abstractions.Repositories;
using StoreOnline.Core.Abstractions.Services;
using StoreOnline.Core.DTO;

namespace StoreOnline.API.Services
{
    public class UsersService(IUsersRepository usersRepository) : IUsersService
    {
        private readonly IUsersRepository usersRepository = usersRepository;

        public async Task<Guid> CreateUser(User user)
        {
            return await usersRepository.Create(user);
        }

        public async Task<Guid> DeleteUser(Guid id)
        {
            return await usersRepository.Delete(id);
        }

        public async Task<List<User>> GetAllUsers()
        {
            return await usersRepository.Get();
        }

        public async Task<Guid> UpdateUser(User user)
        {
            return await usersRepository.Update(user);
        }
    }
}
