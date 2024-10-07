using PrintingHouseFrontend.Clients;
using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using System.Net.Http;
using PrintingHouseFrontend;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");

var printingHouseApiUrl = builder.Configuration["PrintingHouseApiUrl"] ??
    throw new Exception("PrintingHouseApiUrl is not set");

builder.Services.AddTransient<AuthService>();
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(printingHouseApiUrl) });
builder.Services.AddHttpClient<CustomersClient>(client => client.BaseAddress = new Uri(printingHouseApiUrl))
    .AddHttpMessageHandler<AuthService>();
builder.Services.AddHttpClient<JobDetailsClient>(client => client.BaseAddress = new Uri(printingHouseApiUrl))
    .AddHttpMessageHandler<AuthService>();
builder.Services.AddHttpClient<JobOrderClient>(client => client.BaseAddress = new Uri(printingHouseApiUrl))
    .AddHttpMessageHandler<AuthService>();
builder.Services.AddHttpClient<UserLoginClient>(client => client.BaseAddress = new Uri(printingHouseApiUrl))
    .AddHttpMessageHandler<AuthService>();
builder.Services.AddBlazoredLocalStorage();

await builder.Build().RunAsync();
