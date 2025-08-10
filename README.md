# 💰 FinanceTracker

FinanceTracker is a simple ASP.NET Core CRUD API for managing financial transactions.  
It is built with **Entity Framework Core** for database operations, **FluentValidation** for input validation, and comes with an interactive **Swagger** UI for testing.  

---

## 🚀 Features

- 📄 **CRUD for Transactions** — Create, Read, Update, and Delete operations.
- 🗄 **SQL Server** — Reliable and robust database support.
- 📏 **FluentValidation** — Strong validation rules for input data.
- 🛠 **Swagger UI** — Built-in API documentation and testing.
- 🏗 **Clean Architecture** — Layered design for maintainability.

---

## 🧾 Entity: Transaction
A `Transaction` represents a financial record with fields such as:
- `Id` — Unique identifier
- `Description` — Short description of the transaction
- `Amount` — Positive or negative value
- `Date` — Date of the transaction
- `Type` — Type (Income,Expense)

---

## 🛠 Tech Stack

- ⚙ *.NET Core 9**
- 🗄 **SQL Server**
- 📝 **Entity Framework Core**
- 📏 **FluentValidation**
- 🛠 **Swagger / Swashbuckle**

---

## 📦 Installation & Setup

### 1️⃣ Clone the repository

```bash
git clone https://github.com/SimoneRamosZ/finance-tracker
cd FinanceTracker
````

### 2️⃣ Configure the database connection

In `appsettings.json`, update your **SQL Server** connection string:

```json
"ConnectionStrings": {
  "DefaultConnection": "Server=localhost;Database=FinanceTracker;User Id=sa;Password=YourPassword;"
}
```

### 3️⃣ Run migrations

```bash
dotnet ef database update
```

### 4️⃣ Run the application

```bash
dotnet run
```

The API will be available at:
➡ **[https://localhost:5001/swagger](https://localhost:5001/swagger)** (Swagger UI)
➡ **[https://localhost:5001/api/transactions](https://localhost:5001/api/transactions)** (Transactions endpoint)

---

## 📖 API Endpoints

| Method | Endpoint                 | Description              |
| ------ | ------------------------ | ------------------------ |
| GET    | `/api/transactions`      | Get all transactions     |
| POST   | `/api/transactions`      | Create a new transaction |
| PUT    | `/api/transactions/{id}` | Update a transaction     |
| DELETE | `/api/transactions/{id}` | Delete a transaction     |

---

## 🧪 Validation Rules (FluentValidation)

* **Description**: Required, max length 255
* **Amount**: Required, cannot be zero
* **Date**: Required, must be a valid date

---

## 🏗 Project Structure

```
FinanceTracker/
├── Controllers/        # API Controllers
├── DTOs/               # Data Transfer Objects
├── Models/           # Entity models
├── Repositories/       # Data access layer
├── Services/           # Business logic
├── Validators/         # FluentValidation classes
├── Data/               # DbContext and configurations
└── Program.cs          # Application entry point
```

---

## 📜 License

This project is licensed under the **MIT License**.

---

✨ *Track your finances with ease!* ✨

