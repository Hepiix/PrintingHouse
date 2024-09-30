using Microsoft.EntityFrameworkCore;
using PrintingHouseBackend.Data;
using PrintingHouseBackend.Models;
using PrintingHouseBackend.Mapping;
using PrintingHouseBackend.Dtos.CustomerDtos;
using Microsoft.AspNetCore.Authorization;

namespace PrintingHouseBackend.EndPoints;

public static class CustomersEndpoints
{
    const string GetCustomerEndpointName = "GetCustomer";

    public static RouteGroupBuilder MapCustomersEndpoints(this WebApplication app)
    {
        var group = app.MapGroup("customers");

        // GET /customers
        group.MapGet("/", [Authorize] async (PrintingHouseContext dbContext) =>
            await dbContext.Customers
                .AsNoTracking()
                .ToListAsync())
            .RequireAuthorization();

        // GET /customers/1
        group.MapGet("/{id}", [Authorize] async (int id, PrintingHouseContext dbContext) =>
        {
            Customer? customer = await dbContext.Customers.FindAsync(id);
            return customer is null ? Results.NotFound() : Results.Ok(customer);
        })
            .WithName(GetCustomerEndpointName)
            .RequireAuthorization();

        // POST /customers
        group.MapPost("/", [Authorize] async (CreateCustomerDto newCustomer, PrintingHouseContext dbContext) =>
        {
            Customer customer = newCustomer.ToEntity();
            dbContext.Customers.Add(customer);
            await dbContext.SaveChangesAsync();

            return Results.CreatedAtRoute(GetCustomerEndpointName, new { id = customer.Id }, customer);
        }).RequireAuthorization();

        // DELETE /customers/1
        group.MapDelete("/{id}", [Authorize] async (int id, PrintingHouseContext dbContext) =>
        {
            await dbContext.Customers.Where(customer => customer.Id == id)
                .ExecuteDeleteAsync();

            return Results.NoContent();
        }).RequireAuthorization();

        // PUT /customers/1
        group.MapPut("/{id}", [Authorize] async (int id, UpdatedCustomerDto updatedCustomer, PrintingHouseContext dbContext) =>
        {
            var existingCustomer = await dbContext.Customers.FindAsync(id);

            if (existingCustomer is null)
                return Results.NotFound();

            dbContext.Entry(existingCustomer)
            .CurrentValues
            .SetValues(updatedCustomer.ToEntity(id));

            await dbContext.SaveChangesAsync();
            return Results.NoContent();
        }).RequireAuthorization();

        return group;
    }
}
