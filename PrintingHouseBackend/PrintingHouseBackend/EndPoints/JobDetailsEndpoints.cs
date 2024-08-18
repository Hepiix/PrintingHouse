using Microsoft.EntityFrameworkCore;
using PrintingHouseBackend.Data;

namespace PrintingHouseBackend.EndPoints;

public static class JobDetailsEndpoints
{
    public static RouteGroupBuilder MapJobDetailsEndpoints(this WebApplication app)
    {
        var group = app.MapGroup("jobsdetails");

        // GET /jobsdetails
        group.MapGet("/", async (PrintingHouseContext dbContext) =>
            await dbContext.JobsDetails
                .AsNoTracking()
                .ToListAsync());

        return group;
    }
}
