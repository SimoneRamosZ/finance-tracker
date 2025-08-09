using FinanceTracker.Api.Models;

namespace FinanceTracker.Api.Repositories.Interfaces;

public interface ITransactionRepository
{
    Task<IEnumerable<Transaction>> GetAll();
    Task<Transaction?> GetById(int id);
    Task<Transaction> Add(Transaction transaction);
    Task Update(Transaction transaction);
    Task Delete(Transaction transaction);
}
