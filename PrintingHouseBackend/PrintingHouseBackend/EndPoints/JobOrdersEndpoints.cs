using Microsoft.EntityFrameworkCore;
using PrintingHouseBackend.Data;
using PrintingHouseBackend.Dtos;
using PrintingHouseBackend.Mapping;
using PrintingHouseBackend.Models;

namespace PrintingHouseBackend.EndPoints;

public static class JobOrdersEndpoints
{
    const string GetJobOrderEndpointName = "GetJobOrder";

    public static RouteGroupBuilder MapJobOrdersEndpoints(this WebApplication app)
    {
        var group = app.MapGroup("jobsorders");

        // GET /jobsorders
        group.MapGet("/", async (PrintingHouseContext dbContext) =>
            await dbContext.JobsOrders
                .AsNoTracking()
                .ToListAsync());

        // GET /jobsorders/1
        group.MapGet("/{id}", async (int id, PrintingHouseContext dbContext) =>
        {
            JobOrder? jobOrder = await dbContext.JobsOrders
                    .Include(i => i.Customer)
                    .Include(i => i.JobDetails)
                    .FirstOrDefaultAsync(i => i.Id == id);

            if (jobOrder == null)
                return Results.NotFound();

            return  Results.Ok(jobOrder.ToJobOrderDto());
        })
            .WithName(GetJobOrderEndpointName);
        return group;
    }
}
