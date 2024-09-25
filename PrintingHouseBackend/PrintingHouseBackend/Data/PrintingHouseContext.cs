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
            new { Id = 1, Name = "Steven", Surname = "Waters", Company = "Courtesy Hardware Store", PhoneNumber = "7815219682" },
            new { Id = 2, Name = "Matthew", Surname = "Clark", Company = "Friendly Advice", PhoneNumber = "6209959419" },
            new { Id = 3, Name = "Robert", Surname = "Phillips", Company = "Peaches", PhoneNumber = "4026489114" });

        modelBuilder.Entity<JobDetails>().HasData(
            new { Id = 1, Name = "SW. Courtesy Hardward Store", Pattern = "swchs12" },
            new { Id = 2, Name = "MC. Friendly Advice", Pattern = "mcfa3" },
            new { Id = 3, Name = "RP. Peaches", Pattern = "rpp1" });

        modelBuilder.Entity<JobOrder>().HasData(
            new { Id = 1, CustomerId = 1, JobDetailsId = 1, OrderDate = new DateOnly(2024,2,12), Status = false },
            new { Id = 2, CustomerId = 2, JobDetailsId = 2, OrderDate = new DateOnly(2024,6,1), Status = false },
            new { Id = 3, CustomerId = 3, JobDetailsId = 3, OrderDate = new DateOnly(2023,7,27), Status = true });

        modelBuilder.Entity<UserModel>().HasData(
            new { Id = 1, Email = "jeremy20110@yahoo.com", Password = "123", FirstName = "Jeri", LastName = "Medlin" },
            new { Id = 2, Email = "heber_barte@gmail.com", Password = "123", FirstName = "Cynthia", LastName = "Chamberlain" },
            new { Id = 3, Email = "bettie1995@hotmail.com", Password = "123", FirstName = "Justin", LastName = "Smith" }
            );
    }
}
