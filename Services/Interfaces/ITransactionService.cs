using FinanceTracker.Api.Dtos;
using FinanceTracker.Api.Models;

namespace FinanceTracker.Api.Services.Interfaces;
public interface ITransactionService
{
    Task<IEnumerable<Transaction>> GetAll();
    Task<Transaction> Create(CreateTransactionDto dto);
    Task<Transaction?> Update(int id, UpdateTransactionDto dto);
    Task<bool> Delete(int id);
}


