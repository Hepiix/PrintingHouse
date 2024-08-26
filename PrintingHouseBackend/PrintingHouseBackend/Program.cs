using PrintingHouseBackend.Data;
using Microsoft.EntityFrameworkCore;
using PrintingHouseBackend.EndPoints;

var builder = WebApplication.CreateBuilder(args);

var connString = builder.Configuration.GetConnectionString("PrintingHouse");
builder.Services.AddDbContext<PrintingHouseContext>(options =>
    options.UseSqlServer(connString));

var app = builder.Build();
app.MapCustomersEndpoints();
app.MapJobDetailsEndpoints();
app.MapJobOrdersEndpoints();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
app.UseStaticFiles();
app.Run();
