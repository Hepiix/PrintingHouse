using Microsoft.EntityFrameworkCore;
using PrintingHouseBackend.Data;
using PrintingHouseBackend.Models;

namespace PrintingHouseBackend.EndPoints;

public static class CustomersEndpoints
{
    const string GetCustomerEndpointName = "GetCustomer";

    public static RouteGroupBuilder MapCustomersEndpoints(this WebApplication app)
    {
        var group = app.MapGroup("customers");

        // GET /customers
        group.MapGet("/", async (PrintingHouseContext dbContext) =>
            await dbContext.Customers
                .AsNoTracking()
                .ToListAsync());

        // GET /customers/1
        group.MapGet("/{id}", async (int id, PrintingHouseContext dbContext) =>
        {
            Customer? customer = await dbContext.Customers.FindAsync(id);
            return customer is null ? Results.NotFound() : Results.Ok(customer);
        })
            .WithName(GetCustomerEndpointName);
            
        return group;
    }
}
