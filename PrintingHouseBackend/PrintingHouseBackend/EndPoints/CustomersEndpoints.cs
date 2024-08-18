using Microsoft.EntityFrameworkCore;
using PrintingHouseBackend.Data;

namespace PrintingHouseBackend.EndPoints;

public static class CustomersEndpoints
{
    public static RouteGroupBuilder MapCustomersEndpoints(this WebApplication app)
    {
        var group = app.MapGroup("customers");

        // GET /customers
        group.MapGet("/", async (PrintingHouseContext dbContext) =>
            await dbContext.Customers
                .AsNoTracking()
                .ToListAsync());

        return group;
    }
}
