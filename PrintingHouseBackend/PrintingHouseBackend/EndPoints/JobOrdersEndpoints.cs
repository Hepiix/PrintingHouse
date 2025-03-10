﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using PrintingHouseBackend.Data;
using PrintingHouseBackend.Dtos.JobOrderDtos;
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
        group.MapGet("/", [Authorize] async (PrintingHouseContext dbContext) =>
        {
            var jobOrders = await dbContext.JobsOrders
                .Include(i => i.Customer)
                .Include(i => i.JobDetails)
                .AsNoTracking()
                .ToListAsync();
            return jobOrders is null ? Results.NotFound() : Results.Ok(jobOrders.ToJobOrdersSummaryDto());
        }).RequireAuthorization();

        // GET /jobsorders/1
        group.MapGet("/{id}", [Authorize] async (int id, PrintingHouseContext dbContext) =>
        {
            JobOrder? jobOrder = await dbContext.JobsOrders
                .Include(i => i.Customer)
                .Include(i => i.JobDetails)
                .FirstOrDefaultAsync(i => i.Id == id);
            return jobOrder is null ? Results.NotFound() : Results.Ok(jobOrder.ToJobOrderSummaryDto());
        })
            .WithName(GetJobOrderEndpointName).RequireAuthorization();

        // POST /jobsorders/1
        group.MapPost("/", [Authorize] async (CreateJobOrderDto createdJobOrder, PrintingHouseContext dbContext) =>
        {
            JobOrder jobOrder = createdJobOrder.ToEntity();
            dbContext.JobsOrders.Add(jobOrder);
            await dbContext.SaveChangesAsync();
            return Results.CreatedAtRoute(GetJobOrderEndpointName, new { id = jobOrder.Id });
        }).RequireAuthorization();

        // DELETE /jobsorders/1
        group.MapDelete("/{id}", [Authorize] async (int id, PrintingHouseContext dbContext) =>
        {
            await dbContext.JobsOrders.Where(jobOrder => jobOrder.Id == id)
                .ExecuteDeleteAsync();
            return Results.NoContent();
        }).RequireAuthorization();

        // PUT /jobsorders/1
        group.MapPut("/{id}", [Authorize] async (int id, UpdatedJobOrderDto updatedJobOrder, PrintingHouseContext dbContext) =>
        {
            var existingJobOrder = await dbContext.JobsOrders.FindAsync(id);
            if (existingJobOrder is null)
                return Results.NotFound();
            dbContext.Entry(existingJobOrder)
                .CurrentValues
                .SetValues(updatedJobOrder.ToEntity(id));
            await dbContext.SaveChangesAsync();
            return Results.NoContent();
        }).RequireAuthorization();
        return group;
    }
}