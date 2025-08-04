using FinanceTracker.Api.Dtos;
using FluentValidation;

namespace FinanceTracker.Api.Validators;
public class CreateTransactionDtoValidator : AbstractValidator<CreateTransactionDto>
{
    public CreateTransactionDtoValidator()
    {
        RuleFor(x => x.Description).NotEmpty();
        RuleFor(x => x.Amount).GreaterThan(0);
        RuleFor(x => x.Type).Must(t => t == "Income" || t == "Expense");
    }
}
