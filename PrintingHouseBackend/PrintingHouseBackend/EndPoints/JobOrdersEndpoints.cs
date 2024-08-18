using Microsoft.EntityFrameworkCore;
using PrintingHouseBackend.Data;

namespace PrintingHouseBackend.EndPoints;

public static class JobOrdersEndpoints
{
    public static RouteGroupBuilder MapJobOrdersEndpoints(this WebApplication app)
    {
        var group = app.MapGroup("jobsorders");

        // GET /jobsorders
        group.MapGet("/", async (PrintingHouseContext dbContext) =>
            await dbContext.JobsOrders
                .AsNoTracking()
                .ToListAsync());

        return group;
    }
}
