using Microsoft.EntityFrameworkCore;
using PrintingHouseBackend.Data;
using PrintingHouseBackend.Models;

namespace PrintingHouseBackend.EndPoints;

public static class JobDetailsEndpoints
{
    const string GetJobDetailsEndpointName = "GetJobDetails";

    public static RouteGroupBuilder MapJobDetailsEndpoints(this WebApplication app)
    {
        var group = app.MapGroup("jobsdetails");

        // GET /jobsdetails
        group.MapGet("/", async (PrintingHouseContext dbContext) =>
            await dbContext.JobsDetails
                .AsNoTracking()
                .ToListAsync());

        // GET /jobsdetails/1
        group.MapGet("/{id}", async (int id, PrintingHouseContext dbContext) =>
        {
            JobDetails? jobDetails = await dbContext.JobsDetails.FindAsync(id);
            return jobDetails is null ? Results.NotFound() : Results.Ok(jobDetails);
        })
            .WithName(GetJobDetailsEndpointName);

        return group;
    }
}
