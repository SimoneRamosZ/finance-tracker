namespace FinanceTracker.Api.Dtos;
public class UpdateTransactionDto
{
    public string Description { get; set; } = string.Empty;
    public decimal Amount { get; set; }
    public DateTime Date { get; set; }
    public string Type { get; set; } = "Expense"; // or "Income"
}



