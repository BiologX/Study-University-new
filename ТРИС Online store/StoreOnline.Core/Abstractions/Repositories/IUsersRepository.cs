using StoreOnline.Core.Models;

namespace StoreOnline.Core.Abstractions.Repositories
{
    public interface IUsersRepository
    {
        Task<Guid> Create(User user);
        Task<Guid> Delete(Guid id);
        Task<List<User>> Get();
        Task<Guid> Update(User user);
    }
}
