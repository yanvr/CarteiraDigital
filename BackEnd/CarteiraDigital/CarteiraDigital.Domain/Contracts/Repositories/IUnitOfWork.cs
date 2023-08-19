namespace CarteiraDigital.Domain.Contracts.Repositories
{
    public interface IUnitOfWork
    {
        ITransactionRepository TransactionRepository { get; }
        IUserRepository UserRepository { get; }
        IWalletRepository WalletRepository { get; }
        IUserTypeRepository UserTypeRepository { get; }

        Task SaveChagesAsync();
    }
}
