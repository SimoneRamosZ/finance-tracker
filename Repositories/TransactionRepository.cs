using FinanceTracker.Api.Data;
using FinanceTracker.Api.Models;
using FinanceTracker.Api.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace FinanceTracker.Api.Repositories;
public class TransactionRepository : ITransactionRepository
{
    private readonly ApplicationDbContext _context;

    public TransactionRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Transaction>> GetAll()
    {
        return await _context.Transactions.ToListAsync();
    }

    public async Task<Transaction> Add(Transaction transaction)
    {
        _context.Transactions.Add(transaction);
        await _context.SaveChangesAsync();
        return transaction;
    }
}
