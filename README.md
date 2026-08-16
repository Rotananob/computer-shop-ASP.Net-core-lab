# Computer Shop - ASP.NET Core MVC E-Commerce Application

## Project Overview

This is a university E-Commerce lab assignment demonstrating fundamental concepts of ASP.NET Core MVC development with Entity Framework Core and PostgreSQL.

**Business Domain:** Computer Shop (Laptops, Desktops, Monitors, Peripherals, Components)

---

## 🏗️ Architecture & Technology Stack

| Component | Technology |
|-----------|-----------|
| **Framework** | ASP.NET Core MVC |
| **.NET Version** | .NET 8 |
| **Language** | C# 12 |
| **Database** | PostgreSQL |
| **ORM** | Entity Framework Core 8.0 |
| **Database Provider** | Npgsql |
| **UI Framework** | Bootstrap 5 |

---

## 📊 Database Design

### Entities

#### 1. **Category**
- `Id` (int, PK)
- `Name` (string)
- `Description` (string)
- **Navigation:** `Products` (1:Many)

#### 2. **Product**
- `Id` (int, PK)
- `Name` (string)
- `Description` (string)
- `Price` (decimal)
- `Stock` (int)
- `ImagePath` (string)
- `CategoryId` (int, FK) → Category
- **Navigation:** `Category`, `OrderDetails` (1:Many)

#### 3. **Customer**
- `Id` (int, PK)
- `FirstName` (string)
- `LastName` (string)
- `Email` (string)
- `Phone` (string)
- `Address` (string)
- **Navigation:** `Orders` (1:Many)

#### 4. **Order**
- `Id` (int, PK)
- `OrderDate` (DateTime)
- `TotalAmount` (decimal)
- `CustomerId` (int, FK) → Customer
- **Navigation:** `Customer`, `OrderDetails` (1:Many)

#### 5. **OrderDetail**
- `Id` (int, PK)
- `Quantity` (int)
- `UnitPrice` (decimal)
- `OrderId` (int, FK) → Order
- `ProductId` (int, FK) → Product
- **Navigation:** `Order`, `Product`

### Relationships

- **Category ↔ Product:** One-to-Many (Cascade Delete)
- **Customer ↔ Order:** One-to-Many (Cascade Delete)
- **Order ↔ OrderDetail:** One-to-Many (Cascade Delete)
- **Product ↔ OrderDetail:** One-to-Many (Restrict Delete)

---

## 🎮 Controllers

### ProductsController
- `Index()` - List all products with categories
- `Details(id)` - View product details
- `Create()` - Create new product (form & save)
- `Edit(id)` - Edit product (form & save)
- `Delete(id)` - Delete product (confirmation & delete)

### CategoriesController
- `Index()` - List all categories
- `Details(id)` - View category and its products
- `Create()` - Create new category
- `Edit(id)` - Edit category
- `Delete(id)` - Delete category

### CustomersController
- `Index()` - List all customers
- `Details(id)` - View customer info and orders
- `Create()` - Create new customer
- `Edit(id)` - Edit customer
- `Delete(id)` - Delete customer

### OrdersController
- `Index()` - List all orders (latest first)
- `Details(id)` - View order with order items
- `Create()` - Create new order
- `Edit(id)` - Edit order
- `Delete(id)` - Delete order

### HomeController
- `Index()` - Dashboard with navigation cards
- `Privacy()` - Privacy policy page
- `Error()` - Error page

---

## 📁 Project Structure

```
Computer-shop/
├── Controllers/
│   ├── HomeController.cs
│   ├── ProductsController.cs
│   ├── CategoriesController.cs
│   ├── CustomersController.cs
│   └── OrdersController.cs
├── Models/
│   ├── Category.cs
│   ├── Product.cs
│   ├── Customer.cs
│   ├── Order.cs
│   ├── OrderDetail.cs
│   └── ErrorViewModel.cs
├── Data/
│   ├── AppDbContext.cs (EF Core DbContext)
│   └── AppDbInitializer.cs (Seed data)
├── Views/
│   ├── Home/
│   │   ├── Index.cshtml
│   │   ├── Privacy.cshtml
│   │   └── Error.cshtml
│   ├── Products/
│   │   ├── Index.cshtml
│   │   ├── Details.cshtml
│   │   ├── Create.cshtml
│   │   ├── Edit.cshtml
│   │   └── Delete.cshtml
│   ├── Categories/
│   │   ├── Index.cshtml
│   │   ├── Details.cshtml
│   │   ├── Create.cshtml
│   │   ├── Edit.cshtml
│   │   └── Delete.cshtml
│   ├── Customers/
│   │   ├── Index.cshtml
│   │   ├── Details.cshtml
│   │   ├── Create.cshtml
│   │   ├── Edit.cshtml
│   │   └── Delete.cshtml
│   ├── Orders/
│   │   ├── Index.cshtml
│   │   ├── Details.cshtml
│   │   ├── Create.cshtml
│   │   ├── Edit.cshtml
│   │   └── Delete.cshtml
│   ├── Shared/
│   │   ├── _Layout.cshtml
│   │   └── _ViewStart.cshtml
├── wwwroot/
│   ├── images/products/ (Product image storage)
│   ├── lib/ (Bootstrap, jQuery)
├── Properties/
├── Program.cs
├── appsettings.json
├── Computer-shop.csproj
└── .gitignore
```

---

## 🗄️ Database Configuration

### appsettings.json
```json
{
  "ConnectionStrings": {
    "DefaultConnectionString": "Host=localhost;Database=ComputerShopDb;Username=postgres;Password=postgres"
  }
}
```

### Program.cs Configuration
```csharp
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnectionString")));
```

---

## 🌱 Data Seeding

### Seed Data Created

The `AppDbInitializer.Seed()` method creates:

**Categories (5):**
- Laptops
- Desktops
- Monitors
- Peripherals
- Components

**Products (12):**
- ASUS ROG Zephyrus (Laptop)
- Lenovo Legion Pro (Laptop)
- Dell XPS 15 (Laptop)
- HP Pavilion Desktop (Desktop)
- NZXT Builder PC (Desktop)
- LG 27" 4K Monitor (Monitor)
- Dell S2421H Monitor (Monitor)
- Logitech MX Master 3S (Peripheral)
- Corsair K95 Keyboard (Peripheral)
- Intel Core i9-13900KS (Component)
- NVIDIA RTX 4090 (Component)
- Corsair Vengeance DDR5 32GB (Component)

**Customers (5):**
- Sample customer records with contact info

**Orders (5):**
- Sample orders with order details linking to products

### Seed Data Features
- ✅ No duplicate records (checks with `.Any()`)
- ✅ Automatic foreign key assignment
- ✅ Valid relationships between entities
- ✅ Realistic sample data
- ✅ Called automatically on application startup via `AppDbInitializer.Seed(app)` in `Program.cs`

---

## 🚀 How to Run

### Prerequisites
1. **PostgreSQL** installed and running on `localhost:5432`
2. Default PostgreSQL user: `postgres` with password `postgres`
3. **.NET 8 SDK** installed
4. **Visual Studio** or another C# IDE

### Steps

1. **Clone the repository**
   ```bash
   git clone https://github.com/Rotananob/computer-shop-ASP.Net-core-lab.git
   cd computer-shop-ASP.Net-core-lab
   ```

2. **Restore NuGet packages**
   ```bash
   dotnet restore
   ```

3. **Build the project**
   ```bash
   dotnet build
   ```

4. **Update PostgreSQL connection (if different)**
   - Edit `appsettings.json`
   - Change `Host`, `Database`, `Username`, `Password` as needed

5. **Run the application**
   ```bash
   dotnet run
   ```

6. **Access the application**
   - Open browser: `https://localhost:5001` (or `http://localhost:5000`)

7. **Database Creation**
   - Database will be automatically created via `EnsureCreated()` on first run
   - Seed data will be inserted automatically

---

## 📋 Features

### CRUD Operations
- ✅ Create, Read, Update, Delete for all main entities
- ✅ Navigation properties automatically loaded
- ✅ Proper validation and error handling

### UI/UX
- ✅ Responsive Bootstrap 5 design
- ✅ Clean navigation bar with all main sections
- ✅ Card-based dashboard on home page
- ✅ Table views for listing
- ✅ Form views for create/edit operations
- ✅ Confirmation pages for delete operations

### Database
- ✅ PostgreSQL integration
- ✅ Entity Framework Core 8.0
- ✅ Proper foreign key relationships
- ✅ Cascade delete where appropriate
- ✅ Automatic seed data

---

## 📝 Sample Data Structure

### Category → Products
Each category contains multiple products with appropriate pricing and stock.

### Customer → Orders
Each customer can have multiple orders, showing order date and total amount.

### Order → OrderDetails
Each order contains multiple order details linking to specific products with quantity and unit price.

---

## 🐛 Troubleshooting

### Database Connection Failed
- Ensure PostgreSQL is running
- Check connection string in `appsettings.json`
- Verify username and password

### Build Errors
- Ensure .NET 8 SDK is installed: `dotnet --version`
- Clean and rebuild: `dotnet clean && dotnet build`

### Database Already Exists
- The app will reuse existing database
- To reset: Drop `ComputerShopDb` database and restart the app

---

## 🔧 Customization

### Add New Product Image
1. Place image in `wwwroot/images/products/`
2. Update product's `ImagePath` to point to the image
3. Display in views using: `<img src="@product.ImagePath" />`

### Add New Entity
1. Create model in `Models/` folder
2. Add `DbSet<Entity>` to `AppDbContext`
3. Add seeding logic to `AppDbInitializer.Seed()`
4. Create controller with CRUD actions
5. Create views for CRUD operations

---

## 📚 Learning Outcomes

This project demonstrates:
- ✅ ASP.NET Core MVC architecture
- ✅ Entity Framework Core ORM usage
- ✅ PostgreSQL database integration
- ✅ Model-View-Controller pattern
- ✅ Database relationships (1:1, 1:Many, Many:Many)
- ✅ CRUD operations
- ✅ Data seeding and initialization
- ✅ Razor view syntax
- ✅ Bootstrap responsive design
- ✅ Git version control

---

## 📄 License

This project is for educational purposes as part of a university E-Commerce lab assignment.

---

## ✅ Completion Checklist

- ✅ Database design with proper relationships
- ✅ PostgreSQL integration with Npgsql
- ✅ Entity Framework Core configuration
- ✅ Model creation with navigation properties
- ✅ DbContext setup with relationship mapping
- ✅ Seed data creation in C# code
- ✅ CRUD controllers for main entities
- ✅ Razor views for all operations
- ✅ Bootstrap UI layout
- ✅ Project builds successfully
- ✅ Git repository initialized with correct remote
- ✅ Initial commit created
- ✅ README documentation

---

**Created:** 2026  
**University Assignment:** E-Commerce with ASP.NET Core MVC  
**Repository:** https://github.com/Rotananob/computer-shop-ASP.Net-core-lab
