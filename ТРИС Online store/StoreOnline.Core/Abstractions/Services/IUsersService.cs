using StoreOnline.Core.DTO;

namespace StoreOnline.Core.Abstractions.Services
{
    public interface IUsersService
    {
        Task<Guid> CreateUser(User user);
        Task<Guid> DeleteUser(Guid id);
        Task<List<User>> GetAllUsers();
        Task<Guid> UpdateUser(User user);
    }
}
