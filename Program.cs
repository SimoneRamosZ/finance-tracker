using FinanceTracker.Api.Data;
using FinanceTracker.Api.Repositories.Interfaces;
using FinanceTracker.Api.Repositories;
using FinanceTracker.Api.Services.Interfaces;
using FinanceTracker.Api.Services;
using FinanceTracker.Api.Validators;
using Microsoft.EntityFrameworkCore;
using FluentValidation;
using FluentValidation.AspNetCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddScoped<ITransactionRepository, TransactionRepository>();
builder.Services.AddScoped<ITransactionService, TransactionService>();

builder.Services.AddValidatorsFromAssemblyContaining<CreateTransactionDtoValidator>();
builder.Services.AddFluentValidationAutoValidation();

var app = builder.Build();

app.MapControllers();

app.Run();
