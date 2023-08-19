using CarteiraDigital.Domain.Entities;

namespace CarteiraDigital.Domain.Contracts.Repositories
{
    public interface ITransactionRepository
    {
        void Insert(Transaction transaction);
    }
}
