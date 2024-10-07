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
                }, new Customer { Id = 6, Name = "John", Surname = "Doe", Company = "Doe Inc.", PhoneNumber = "123-456-7890", Email = "john.doe@example.com", StreetAddress = "123 Main St", City = "Springfield", State = "IL", PostalCode = "62704", Country = "USA" },
                new Customer { Id = 7, Name = "Jane", Surname = "Smith", Company = "Smith LLC", PhoneNumber = "234-567-8901", Email = "jane.smith@example.com", StreetAddress = "456 Oak St", City = "Greenville", State = "TX", PostalCode = "75401", Country = "USA" },
                new Customer { Id = 8, Name = "Alice", Surname = "Johnson", Company = "Johnson Co.", PhoneNumber = "345-678-9012", Email = "alice.johnson@example.com", StreetAddress = "789 Pine St", City = "Lincoln", State = "NE", PostalCode = "68508", Country = "USA" },
                new Customer { Id = 9, Name = "Robert", Surname = "Brown", Company = "Brown Enterprises", PhoneNumber = "456-789-0123", Email = "robert.brown@example.com", StreetAddress = "321 Elm St", City = "Columbus", State = "OH", PostalCode = "43215", Country = "USA" },
                new Customer { Id = 10, Name = "Emily", Surname = "Davis", Company = "Davis & Co.", PhoneNumber = "567-890-1234", Email = "emily.davis@example.com", StreetAddress = "654 Maple Ave", City = "Hartford", State = "CT", PostalCode = "06103", Country = "USA" },
                new Customer { Id = 11, Name = "Michael", Surname = "Clark", Company = "Clark Industries", PhoneNumber = "678-901-2345", Email = "michael.clark@example.com", StreetAddress = "987 Cedar St", City = "Dover", State = "DE", PostalCode = "19901", Country = "USA" },
                new Customer { Id = 12, Name = "Sophia", Surname = "Martinez", Company = "Martinez Ltd.", PhoneNumber = "789-012-3456", Email = "sophia.martinez@example.com", StreetAddress = "111 Birch Ln", City = "Bismarck", State = "ND", PostalCode = "58501", Country = "USA" },
                new Customer { Id = 13, Name = "James", Surname = "Lewis", Company = "Lewis Brothers", PhoneNumber = "890-123-4567", Email = "james.lewis@example.com", StreetAddress = "222 Spruce St", City = "Denver", State = "CO", PostalCode = "80202", Country = "USA" },
                new Customer { Id = 14, Name = "Olivia", Surname = "Walker", Company = "Walker Solutions", PhoneNumber = "901-234-5678", Email = "olivia.walker@example.com", StreetAddress = "333 Ash St", City = "Phoenix", State = "AZ", PostalCode = "85001", Country = "USA" },
                new Customer { Id = 15, Name = "David", Surname = "Hall", Company = "Hall & Partners", PhoneNumber = "012-345-6789", Email = "david.hall@example.com", StreetAddress = "444 Palm Dr", City = "Sacramento", State = "CA", PostalCode = "95814", Country = "USA" },
                new Customer { Id = 16, Name = "Lucas", Surname = "Young", Company = "Young Corp.", PhoneNumber = "321-123-4321", Email = "lucas.young@example.com", StreetAddress = "555 Cypress St", City = "Atlanta", State = "GA", PostalCode = "30303", Country = "USA" },
                new Customer { Id = 17, Name = "Mia", Surname = "King", Company = "King Enterprises", PhoneNumber = "432-234-5432", Email = "mia.king@example.com", StreetAddress = "666 Olive St", City = "Austin", State = "TX", PostalCode = "73301", Country = "USA" },
                new Customer { Id = 18, Name = "Henry", Surname = "Scott", Company = "Scott LLC", PhoneNumber = "543-345-6543", Email = "henry.scott@example.com", StreetAddress = "777 Pine Rd", City = "Las Vegas", State = "NV", PostalCode = "88901", Country = "USA" },
                new Customer { Id = 19, Name = "Grace", Surname = "Green", Company = "Green Solutions", PhoneNumber = "654-456-7654", Email = "grace.green@example.com", StreetAddress = "888 Aspen Ln", City = "Miami", State = "FL", PostalCode = "33101", Country = "USA" },
                new Customer { Id = 20, Name = "Ethan", Surname = "Hill", Company = "Hill Group", PhoneNumber = "765-567-8765", Email = "ethan.hill@example.com", StreetAddress = "999 Oak Dr", City = "Seattle", State = "WA", PostalCode = "98101", Country = "USA" },
                new Customer { Id = 21, Name = "Ava", Surname = "Adams", Company = "Adams LLC", PhoneNumber = "876-678-9876", Email = "ava.adams@example.com", StreetAddress = "1001 Maple St", City = "Portland", State = "OR", PostalCode = "97201", Country = "USA" },
                new Customer { Id = 22, Name = "Benjamin", Surname = "Nelson", Company = "Nelson Technologies", PhoneNumber = "987-789-0987", Email = "benjamin.nelson@example.com", StreetAddress = "1102 Willow St", City = "Chicago", State = "IL", PostalCode = "60601", Country = "USA" },
                new Customer { Id = 23, Name = "Ella", Surname = "Carter", Company = "Carter Enterprises", PhoneNumber = "098-890-1098", Email = "ella.carter@example.com", StreetAddress = "1203 Cedar St", City = "Boston", State = "MA", PostalCode = "02108", Country = "USA" },
                new Customer { Id = 24, Name = "Daniel", Surname = "Mitchell", Company = "Mitchell Industries", PhoneNumber = "109-901-2109", Email = "daniel.mitchell@example.com", StreetAddress = "1304 Birch Ln", City = "New York", State = "NY", PostalCode = "10001", Country = "USA" },
                new Customer { Id = 25, Name = "Lily", Surname = "Perez", Company = "Perez & Co.", PhoneNumber = "210-012-3210", Email = "lily.perez@example.com", StreetAddress = "1405 Elm St", City = "San Francisco", State = "CA", PostalCode = "94101", Country = "USA" }
            );

        modelBuilder.Entity<JobDetails>().HasData(
            new JobDetails
            {
                Id = 1,
                Name = "Business Cards",
                Pattern = "BC-001",
                PaperType = "Glossy",
                Dimensions = "3.5x2 inches",
                ColorMode = "Full Color",
                PrintSides = "Double",
                UnitPrice = 0.20m,
            },
                new JobDetails
                {
                    Id = 2,
                    Name = "Flyers",
                    Pattern = "FL-002",
                    PaperType = "Matte",
                    Dimensions = "8.5x11 inches",
                    ColorMode = "Full Color",
                    PrintSides = "Single",
                    UnitPrice = 0.15m,
                },
                new JobDetails
                {
                    Id = 3,
                    Name = "Posters",
                    Pattern = "PO-003",
                    PaperType = "Satin",
                    Dimensions = "18x24 inches",
                    ColorMode = "Full Color",
                    PrintSides = "Single",
                    UnitPrice = 2.50m,
                },
                new JobDetails
                {
                    Id = 4,
                    Name = "Brochures",
                    Pattern = "BR-004",
                    PaperType = "Glossy",
                    Dimensions = "8.5x11 inches",
                    ColorMode = "Full Color",
                    PrintSides = "Double",
                    UnitPrice = 1.00m,
                },
                new JobDetails
                {
                    Id = 5,
                    Name = "Stickers",
                    Pattern = "ST-005",
                    PaperType = "Vinyl",
                    Dimensions = "4x4 inches",
                    ColorMode = "Full Color",
                    PrintSides = "Single",
                    UnitPrice = 0.50m,
                },
                new JobDetails
                {
                    Id = 6,
                    Name = "Letterheads",
                    Pattern = "LH-006",
                    PaperType = "Bond",
                    Dimensions = "8.5x11 inches",
                    ColorMode = "Grayscale",
                    PrintSides = "Single",
                    UnitPrice = 0.10m,
                },
                new JobDetails
                {
                    Id = 7,
                    Name = "Envelopes",
                    Pattern = "EN-007",
                    PaperType = "Standard",
                    Dimensions = "9.5x4.125 inches",
                    ColorMode = "Full Color",
                    PrintSides = "Single",
                    UnitPrice = 0.25m,
                },
                new JobDetails
                {
                    Id = 8,
                    Name = "Banners",
                    Pattern = "BA-008",
                    PaperType = "Vinyl",
                    Dimensions = "3x6 feet",
                    ColorMode = "Full Color",
                    PrintSides = "Single",
                    UnitPrice = 15.00m,
                },
                new JobDetails
                {
                    Id = 9,
                    Name = "Notepads",
                    Pattern = "NP-009",
                    PaperType = "Bond",
                    Dimensions = "5x7 inches",
                    ColorMode = "Grayscale",
                    PrintSides = "Single",
                    UnitPrice = 0.50m,
                },
                new JobDetails
                {
                    Id = 10,
                    Name = "Calendars",
                    Pattern = "CA-010",
                    PaperType = "Glossy",
                    Dimensions = "11x17 inches",
                    ColorMode = "Duotone",
                    PrintSides = "Double",
                    UnitPrice = 3.00m,
                }
            );

        modelBuilder.Entity<JobOrder>().HasData(
            new JobOrder
            {
                Id = 1,
                CustomerId = 1,
                JobDetailsId = 1,
                OrderDate = new DateOnly(2024, 9, 20),
                Quantity = 100,
                TotalPrice = 20m,
                Status = "Pending",
                DeliveryMethod = "Courier"
            },
                new JobOrder
                {
                    Id = 2,
                    CustomerId = 2,
                    JobDetailsId = 2,
                    OrderDate = new DateOnly(2024, 9, 21),
                    Quantity = 100,
                    TotalPrice = 15m,
                    Status = "In Progress",
                    DeliveryMethod = "Self Pickup"
                },
                new JobOrder
                {
                    Id = 3,
                    CustomerId = 3,
                    JobDetailsId = 3,
                    OrderDate = new DateOnly(2024, 9, 22),
                    Quantity = 100,
                    TotalPrice = 250m,
                    Status = "Completed",
                    DeliveryMethod = "Courier"
                },
                new JobOrder
                {
                    Id = 4,
                    CustomerId = 4,
                    JobDetailsId = 4,
                    OrderDate = new DateOnly(2024, 9, 23),
                    Quantity = 100,
                    TotalPrice = 100m,
                    Status = "Pending",
                    DeliveryMethod = "Courier"
                },
                new JobOrder
                {
                    Id = 5,
                    CustomerId = 5,
                    JobDetailsId = 5,
                    OrderDate = new DateOnly(2024, 9, 24),
                    Quantity = 100,
                    TotalPrice = 50m,
                    Status = "In Progress",
                    DeliveryMethod = "Courier"
                },
                new JobOrder { Id = 6, CustomerId = 1, JobDetailsId = 1, OrderDate = DateOnly.FromDateTime(DateTime.Now.AddDays(-10)), Quantity = 100, TotalPrice = 500.50m, Status = "Completed", DeliveryMethod = "Courier" },
                new JobOrder { Id = 7, CustomerId = 2, JobDetailsId = 2, OrderDate = DateOnly.FromDateTime(DateTime.Now.AddDays(-5)), Quantity = 200, TotalPrice = 1000.00m, Status = "Pending", DeliveryMethod = "Pickup" },
                new JobOrder { Id = 8, CustomerId = 3, JobDetailsId = 3, OrderDate = DateOnly.FromDateTime(DateTime.Now.AddDays(-8)), Quantity = 150, TotalPrice = 750.75m, Status = "Shipped", DeliveryMethod = "Courier" },
                new JobOrder { Id = 9, CustomerId = 4, JobDetailsId = 4, OrderDate = DateOnly.FromDateTime(DateTime.Now.AddDays(-12)), Quantity = 300, TotalPrice = 1500.00m, Status = "Completed", DeliveryMethod = "Courier" },
                new JobOrder { Id = 10, CustomerId = 5, JobDetailsId = 5, OrderDate = DateOnly.FromDateTime(DateTime.Now.AddDays(-3)), Quantity = 250, TotalPrice = 1250.25m, Status = "Processing", DeliveryMethod = "Courier" },
                new JobOrder { Id = 11, CustomerId = 6, JobDetailsId = 6, OrderDate = DateOnly.FromDateTime(DateTime.Now.AddDays(-15)), Quantity = 175, TotalPrice = 875.50m, Status = "Shipped", DeliveryMethod = "Pickup" },
                new JobOrder { Id = 12, CustomerId = 7, JobDetailsId = 7, OrderDate = DateOnly.FromDateTime(DateTime.Now.AddDays(-2)), Quantity = 100, TotalPrice = 500.00m, Status = "Pending", DeliveryMethod = "Courier" },
                new JobOrder { Id = 13, CustomerId = 8, JobDetailsId = 8, OrderDate = DateOnly.FromDateTime(DateTime.Now.AddDays(-7)), Quantity = 220, TotalPrice = 1100.00m, Status = "Processing", DeliveryMethod = "Courier" },
                new JobOrder { Id = 14, CustomerId = 9, JobDetailsId = 9, OrderDate = DateOnly.FromDateTime(DateTime.Now.AddDays(-9)), Quantity = 180, TotalPrice = 900.00m, Status = "Completed", DeliveryMethod = "Courier" },
                new JobOrder { Id = 15, CustomerId = 10, JobDetailsId = 10, OrderDate = DateOnly.FromDateTime(DateTime.Now.AddDays(-1)), Quantity = 130, TotalPrice = 650.50m, Status = "Processing", DeliveryMethod = "Courier" },

                new JobOrder { Id = 16, CustomerId = 11, JobDetailsId = 1, OrderDate = DateOnly.FromDateTime(DateTime.Now.AddDays(-11)), Quantity = 160, TotalPrice = 800.00m, Status = "Completed", DeliveryMethod = "Pickup" },
                new JobOrder { Id = 17, CustomerId = 12, JobDetailsId = 2, OrderDate = DateOnly.FromDateTime(DateTime.Now.AddDays(-14)), Quantity = 270, TotalPrice = 1350.75m, Status = "Shipped", DeliveryMethod = "Courier" },
                new JobOrder { Id = 18, CustomerId = 13, JobDetailsId = 3, OrderDate = DateOnly.FromDateTime(DateTime.Now.AddDays(-16)), Quantity = 320, TotalPrice = 1600.00m, Status = "Completed", DeliveryMethod = "Courier" },
                new JobOrder { Id = 19, CustomerId = 14, JobDetailsId = 4, OrderDate = DateOnly.FromDateTime(DateTime.Now.AddDays(-18)), Quantity = 140, TotalPrice = 700.00m, Status = "Pending", DeliveryMethod = "Pickup" },
                new JobOrder { Id = 20, CustomerId = 15, JobDetailsId = 5, OrderDate = DateOnly.FromDateTime(DateTime.Now.AddDays(-6)), Quantity = 190, TotalPrice = 950.00m, Status = "Shipped", DeliveryMethod = "Courier" },
                new JobOrder { Id = 21, CustomerId = 16, JobDetailsId = 6, OrderDate = DateOnly.FromDateTime(DateTime.Now.AddDays(-13)), Quantity = 210, TotalPrice = 1050.00m, Status = "Completed", DeliveryMethod = "Courier" },
                new JobOrder { Id = 22, CustomerId = 17, JobDetailsId = 7, OrderDate = DateOnly.FromDateTime(DateTime.Now.AddDays(-17)), Quantity = 230, TotalPrice = 1150.00m, Status = "Processing", DeliveryMethod = "Courier" },
                new JobOrder { Id = 23, CustomerId = 18, JobDetailsId = 8, OrderDate = DateOnly.FromDateTime(DateTime.Now.AddDays(-20)), Quantity = 300, TotalPrice = 1500.00m, Status = "Shipped", DeliveryMethod = "Courier" },
                new JobOrder { Id = 24, CustomerId = 19, JobDetailsId = 9, OrderDate = DateOnly.FromDateTime(DateTime.Now.AddDays(-22)), Quantity = 250, TotalPrice = 1250.50m, Status = "Pending", DeliveryMethod = "Courier" },
                new JobOrder { Id = 25, CustomerId = 20, JobDetailsId = 10, OrderDate = DateOnly.FromDateTime(DateTime.Now.AddDays(-24)), Quantity = 120, TotalPrice = 600.00m, Status = "Processing", DeliveryMethod = "Courier" }
            );

        modelBuilder.Entity<UserModel>().HasData(
            new { Id = 1, Email = "jeremy20110@yahoo.com", Password = "123", FirstName = "Jeri", LastName = "Medlin" },
            new { Id = 2, Email = "heber_barte@gmail.com", Password = "123", FirstName = "Cynthia", LastName = "Chamberlain" },
            new { Id = 3, Email = "bettie1995@hotmail.com", Password = "123", FirstName = "Justin", LastName = "Smith" }
            );
    }
}
