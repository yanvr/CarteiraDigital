using CarteiraDigital.Domain.Entities;

namespace CarteiraDigital.Domain.Contracts.Repositories
{
    public interface IWalletRepository
    {
        Task<Wallet> GetByUserId(Guid userId);
        void Update(Wallet wallet);
    }
}
