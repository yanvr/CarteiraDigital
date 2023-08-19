using CarteiraDigital.Domain.Entities;

namespace CarteiraDigital.Domain.Contracts.Repositories
{
    public interface IUserRepository
    {
        Task<User> GetByIdAsync(Guid id);
    }
}
