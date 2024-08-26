using Microsoft.EntityFrameworkCore;
using PrintingHouseBackend.Data;
using PrintingHouseBackend.Dtos.JobDetailsDtos;
using PrintingHouseBackend.Mapping;
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

        // POST /jobsdetails
        group.MapPost("/", async (CreateJobDetailsDto newJobDetails, PrintingHouseContext dbContext) =>
        {
            JobDetails jobDetails = newJobDetails.ToEntity();
            dbContext.JobsDetails.Add(jobDetails);
            await dbContext.SaveChangesAsync();

            return Results.CreatedAtRoute(GetJobDetailsEndpointName, new { id = jobDetails.Id }, jobDetails);
        });

        // DELETE /jobsdetails/1
        group.MapDelete("/{id}", async (int id, PrintingHouseContext dbContext) =>
        {
            await dbContext.JobsDetails.Where(jobDetails => jobDetails.Id == id)
                .ExecuteDeleteAsync();

            return Results.NoContent();
        });

        // PUT /jobsdetails/1
        group.MapPut("/{id}", async (int id, UpdatedJobDetailsDto updatedJobDetails, PrintingHouseContext dbContext) =>
        {
            var existingJobDetails = await dbContext.JobsDetails.FindAsync(id);

            if (existingJobDetails is null)
                return Results.NotFound();

            dbContext.Entry(existingJobDetails)
                .CurrentValues
                .SetValues(updatedJobDetails.ToEntity(id));

            await dbContext.SaveChangesAsync();
            return Results.NoContent();
        });
        return group;
    }
}
