using PrintingHouseFrontend.Clients;
using PrintingHouseFrontend.Components;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

var printingHouseApiUrl = builder.Configuration["PrintingHouseApiUrl"] ??
    throw new Exception("PrintingHouseApiUrl is not set");

builder.Services.AddHttpClient<CustomersClient>(client => client.BaseAddress = new Uri(printingHouseApiUrl));
builder.Services.AddHttpClient<JobDetailsClient>(client => client.BaseAddress = new Uri(printingHouseApiUrl));
builder.Services.AddHttpClient<JobOrderClient>(client => client.BaseAddress = new Uri(printingHouseApiUrl));
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
