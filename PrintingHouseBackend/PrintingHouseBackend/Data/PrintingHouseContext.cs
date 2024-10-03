using Microsoft.EntityFrameworkCore;
using PrintingHouseBackend.Models;

namespace PrintingHouseBackend.Data;

public class PrintingHouseContext(DbContextOptions<PrintingHouseContext> options) : DbContext(options)
{
    public DbSet<Customer> Customers => Set<Customer>();
    public DbSet<JobDetails> JobsDetails => Set<JobDetails>();
    public DbSet<JobOrder> JobsOrders => Set<JobOrder>();
    public DbSet<UserModel> UsersData => Set<UserModel>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Customer>().HasData(
            new Customer
            {
                Id = 1,
                Name = "John",
                Surname = "Doe",
                Company = "Doe Designs",
                PhoneNumber = "+1-123-456-7890",
                Email = "john.doe@doedesigns.com",
                StreetAddress = "123 Main St",
                City = "New York",
                State = "NY",
                PostalCode = "10001",
                Country = "USA"
            },
                new Customer
                {
                    Id = 2,
                    Name = "Jane",
                    Surname = "Smith",
                    Company = "Smith Printing Co.",
                    PhoneNumber = "+1-987-654-3210",
                    Email = "jane.smith@smithprinting.com",
                    StreetAddress = "456 Elm St",
                    City = "Los Angeles",
                    State = "CA",
                    PostalCode = "90001",
                    Country = "USA"
                },
                new Customer
                {
                    Id = 3,
                    Name = "Maria",
                    Surname = "Gonzalez",
                    Company = "Gonzalez Graphics",
                    PhoneNumber = "+1-555-123-4567",
                    Email = "maria.gonzalez@gonzalezgraphics.com",
                    StreetAddress = "789 Oak St",
                    City = "Miami",
                    State = "FL",
                    PostalCode = "33101",
                    Country = "USA"
                },
                new Customer
                {
                    Id = 4,
                    Name = "Liam",
                    Surname = "Brown",
                    Company = null,
                    PhoneNumber = "+44-20-7946-0958",
                    Email = "liam.brown@example.co.uk",
                    StreetAddress = "10 Downing Street",
                    City = "London",
                    State = "England",
                    PostalCode = "SW1A 2AA",
                    Country = "UK"
                },
                new Customer
                {
                    Id = 5,
                    Name = "Emily",
                    Surname = "Taylor",
                    Company = "Taylor Marketing",
                    PhoneNumber = "+61-2-9374-4000",
                    Email = "emily.taylor@taylormarketing.au",
                    StreetAddress = "100 George St",
                    City = "Sydney",
                    State = "NSW",
                    PostalCode = "2000",
                    Country = "Australia"
                }
            );

        modelBuilder.Entity<JobDetails>().HasData(
            new JobDetails
            {
                Id = 1,
                Name = "Business Cards",
                Pattern = "BC-001",
                Quantity = 500,
                PaperType = "Glossy",
                Dimensions = "3.5x2 inches",
                ColorMode = "Full Color",
                PrintSides = "Double",
                UnitPrice = 0.20m,
                TotalPrice = 100.00m,
            },
                new JobDetails
                {
                    Id = 2,
                    Name = "Flyers",
                    Pattern = "FL-002",
                    Quantity = 1000,
                    PaperType = "Matte",
                    Dimensions = "8.5x11 inches",
                    ColorMode = "Full Color",
                    PrintSides = "Single",
                    UnitPrice = 0.15m,
                    TotalPrice = 150.00m,
                },
                new JobDetails
                {
                    Id = 3,
                    Name = "Posters",
                    Pattern = "PO-003",
                    Quantity = 200,
                    PaperType = "Satin",
                    Dimensions = "18x24 inches",
                    ColorMode = "Full Color",
                    PrintSides = "Single",
                    UnitPrice = 2.50m,
                    TotalPrice = 500.00m,
                },
                new JobDetails
                {
                    Id = 4,
                    Name = "Brochures",
                    Pattern = "BR-004",
                    Quantity = 300,
                    PaperType = "Glossy",
                    Dimensions = "8.5x11 inches",
                    ColorMode = "Full Color",
                    PrintSides = "Double",
                    UnitPrice = 1.00m,
                    TotalPrice = 300.00m,
                },
                new JobDetails
                {
                    Id = 5,
                    Name = "Stickers",
                    Pattern = "ST-005",
                    Quantity = 1000,
                    PaperType = "Vinyl",
                    Dimensions = "4x4 inches",
                    ColorMode = "Full Color",
                    PrintSides = "Single",
                    UnitPrice = 0.50m,
                    TotalPrice = 500.00m,
                }
            );

        modelBuilder.Entity<JobOrder>().HasData(
            new JobOrder
            {
                Id = 1,
                CustomerId = 1,
                JobDetailsId = 1,
                OrderDate = new DateOnly(2024, 9, 20),
                Status = "Pending",
                DeliveryMethod = "Courier"
            },
                new JobOrder
                {
                    Id = 2,
                    CustomerId = 2,
                    JobDetailsId = 2,
                    OrderDate = new DateOnly(2024, 9, 21),
                    Status = "In Progress",
                    DeliveryMethod = "Self Pickup"
                },
                new JobOrder
                {
                    Id = 3,
                    CustomerId = 3,
                    JobDetailsId = 3,
                    OrderDate = new DateOnly(2024, 9, 22),
                    Status = "Completed",
                    DeliveryMethod = "Courier"
                },
                new JobOrder
                {
                    Id = 4,
                    CustomerId = 4,
                    JobDetailsId = 4,
                    OrderDate = new DateOnly(2024, 9, 23),
                    Status = "Pending",
                    DeliveryMethod = "Courier"
                },
                new JobOrder
                {
                    Id = 5,
                    CustomerId = 5,
                    JobDetailsId = 5,
                    OrderDate = new DateOnly(2024, 9, 24),
                    Status = "In Progress",
                    DeliveryMethod = "Courier"
                }
            );

        modelBuilder.Entity<UserModel>().HasData(
            new { Id = 1, Email = "jeremy20110@yahoo.com", Password = "123", FirstName = "Jeri", LastName = "Medlin" },
            new { Id = 2, Email = "heber_barte@gmail.com", Password = "123", FirstName = "Cynthia", LastName = "Chamberlain" },
            new { Id = 3, Email = "bettie1995@hotmail.com", Password = "123", FirstName = "Justin", LastName = "Smith" }
            );
    }
}
