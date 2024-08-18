using Microsoft.EntityFrameworkCore;
using PrintingHouseBackend.Models;

namespace PrintingHouseBackend.Data;

public class PrintingHouseContext(DbContextOptions<PrintingHouseContext> options) : DbContext(options)
{
    public DbSet<Customer> Customers => Set<Customer>();
    public DbSet<JobDetails> JobsDetails => Set<JobDetails>();
    public DbSet<JobOrder> JobsOrders => Set<JobOrder>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Customer>().HasData(
            new { Id = 1, Name = "Steven", Surname = "Waters", Company = "Courtesy Hardware Store", PhoneNumber = "7815219682" },
            new { Id = 2, Name = "Matthew", Surname = "Clark", Company = "Friendly Advice", PhoneNumber = "6209959419" },
            new { Id = 3, Name = "Robert", Surname = "Phillips", Company = "Peaches", PhoneNumber = "4026489114" });

        modelBuilder.Entity<JobDetails>().HasData(
            new { Id = 1, Name = "SW. Courtesy Hardward Store", Pattern = "swchs12" },
            new { Id = 2, Name = "MC. Friendly Advice", Pattern = "mcfa3" },
            new { Id = 3, Name = "RP. Peaches", Pattern = "rpp1" });

        modelBuilder.Entity<JobOrder>().HasData(
            new { Id = 1, CustomerId = 1, OrderDate = new DateOnly(2024,2,12), Status = false },
            new { Id = 2, CustomerId = 2, OrderDate = new DateOnly(2024,6,1), Status = false },
            new { Id = 3, CustomerId = 3, OrderDate = new DateOnly(2023,7,27), Status = true });
    }
}
