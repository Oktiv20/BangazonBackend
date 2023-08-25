using Microsoft.EntityFrameworkCore;
using BangazonBackend.Models;

public class BangazonBackendDbContext : DbContext
{

    public DbSet<User> Users { get; set; }
    public DbSet<UserPaymentType> UserPaymentTypes { get; set; }
    public DbSet<Product> Products { get; set; }    
    public DbSet<ProductType> ProductTypes { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<OrderedProduct> OrderedProducts { get; set; }
    public DbSet<PaymentType> PaymentTypes { get; set; }

    public BangazonBackendDbContext(DbContextOptions<BangazonBackendDbContext> context) : base(context)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>().HasData(new User[]
        {
            new User {Id = 1, FirstName = "Jack", LastName = "Dough", Email = "jack.dough@jd.com", Address = "123 Main St", IsSeller = false},
            new User {Id = 2, FirstName = "Jane", LastName = "Allen", Email = "jane.allen@ja.com", Address = "456 Elm St", IsSeller = false},
            new User {Id = 3, FirstName = "Michael", LastName = "Johson", Email = "michael.johnson@mj.com", Address = "789 Oak Ave", IsSeller = false},
            new User {Id = 4, FirstName = "Emily", LastName = "Brown", Email = "emily.brown@eb.com", Address = "555 Pine Rd", IsSeller = true},
        });

        modelBuilder.Entity<UserPaymentType>().HasData(new UserPaymentType[]
        {
            new UserPaymentType {Id = 1, UserId = 1, PaymentId = 1},
            new UserPaymentType {Id = 2,UserId = 2, PaymentId = 2},
            new UserPaymentType {Id = 3, UserId = 3, PaymentId = 3},
            new UserPaymentType {Id = 4,UserId = 4, PaymentId = 4},
        });

        modelBuilder.Entity<PaymentType>().HasData(new PaymentType[]
        {
            new PaymentType {Id = 1, Type = "Credit Card"},
            new PaymentType {Id = 2, Type = "PayPal"},
            new PaymentType {Id = 3, Type = "Gift Card"},
            new PaymentType {Id = 4, Type = "Debit Card"},
        });

        modelBuilder.Entity<Product>().HasData(new Product[]
        {
            new Product {Id = 1, SellerId = 1, Title = "Smartphone", Price = 499.99m, Description = "High-end smartphone with advanced features.", ProductType = "Electronics", InStock = true, Quantity = 50, DateAdded = DateTime.Now },
            new Product {Id = 2, SellerId = 2, Title = "Golf Club Set", Price = 299.99m, Description = "Complete set of golf clubs for all skill levels.", ProductType = "Sports Equipment", InStock = true, Quantity = 20, DateAdded = DateTime.Now},
            new Product {Id = 3, SellerId = 3, Title = "Running Shoes", Price = 79.99m, Description = "Comfortable running shoes with excellent cushioning.", ProductType = "Footwear", InStock = true, Quantity = 100, DateAdded = DateTime.Now},
            new Product {Id = 4, SellerId = 4, Title = "Refrigerator", Price = 799.99m, Description = "Energy-efficient refrigerator with ample storage space.", ProductType = "Appliances", InStock = true, Quantity = 5,  DateAdded = DateTime.Now},
        });

        modelBuilder.Entity<ProductType>().HasData(new ProductType[]
        {
            new ProductType {Id = 1, Type = "Electronics"},
            new ProductType {Id = 2, Type = "Sports Equipment"},
            new ProductType {Id = 3, Type = "Footwear"},
            new ProductType {Id = 4, Type = "Appliances"},
        });

        modelBuilder.Entity<Order>().HasData(new Order[]
        {
            new Order {Id = 1, ProductId = 1, CustomerId = 1, Completed = true, PaymentType = "Credit Card", TotalPrice = 499.99m },
            new Order {Id = 2, ProductId = 2, CustomerId = 2, Completed = true, PaymentType = "PayPal", TotalPrice = 299.99m },
            new Order {Id = 3, ProductId = 3, CustomerId = 3, Completed = true, PaymentType = "Debit Card", TotalPrice = 79.99m},
            new Order {Id = 4, ProductId = 4, CustomerId = 3, Completed = true, PaymentType = "Gift Card", TotalPrice = 799.99m},
        });

        modelBuilder.Entity<OrderedProduct>().HasData(new OrderedProduct[]
        {
            new OrderedProduct {Id = 1, ProductId = 1, OrderId = 1},
            new OrderedProduct {Id = 2, ProductId = 2, OrderId = 2},
            new OrderedProduct {Id = 3, ProductId = 3, OrderId = 3},
            new OrderedProduct {Id = 4, ProductId = 4, OrderId = 4},
        });

    }
}
