using StoreOnline.Core.DTO;

namespace StoreOnline.Core.Abstractions.Repositories
{
    public interface IBasketsRepository
    {
        Task<Guid> Create(Basket basket);
        Task<Guid> Delete(Guid id);
        Task<List<Basket>> Get();
        Task<Guid> Update(Basket basket);
    }
}