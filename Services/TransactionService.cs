using FinanceTracker.Api.Dtos;
using FinanceTracker.Api.Models;
using FinanceTracker.Api.Repositories.Interfaces;
using FinanceTracker.Api.Services.Interfaces;

namespace FinanceTracker.Api.Services;

public class TransactionService : ITransactionService
{
    private readonly ITransactionRepository _repository;

    public TransactionService(ITransactionRepository repository)
    {
        _repository = repository;
    }

    public async Task<IEnumerable<Transaction>> GetAll()
    {
       return await _repository.GetAll();
    }

    public async Task<Transaction> Create(CreateTransactionDto dto)
    {
        var transaction = new Transaction
        {
            Amount = dto.Amount,
            Description = dto.Description,
            Type = dto.Type,
            Date = DateTime.Now,
        };

        return await _repository.Add(transaction);  
    }

    public async Task<Transaction?> Update(int id, UpdateTransactionDto dto)
    {
        var transaction = await _repository.GetById(id);
        if (transaction == null) return null;

        transaction.Description = dto.Description;
        transaction.Amount = dto.Amount;
        transaction.Date = dto.Date;
        transaction.Type = dto.Type;

        await _repository.Update(transaction);
        return transaction;
    }

    public async Task<bool> Delete(int id)
    {
        var transaction = await _repository.GetById(id);
        if (transaction == null) return false;

        await _repository.Delete(transaction);
        return true;
    }
}

