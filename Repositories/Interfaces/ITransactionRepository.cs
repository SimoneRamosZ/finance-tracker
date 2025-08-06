using FinanceTracker.Api.Models;

namespace FinanceTracker.Api.Repositories.Interfaces;

public interface ITransactionRepository
{
    Task<IEnumerable<Transaction>> GetAll();
    Task<Transaction> Add(Transaction transaction);
}
