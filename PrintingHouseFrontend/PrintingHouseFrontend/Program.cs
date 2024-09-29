using PrintingHouseFrontend.Clients;
using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using System.Net.Http;
using PrintingHouseFrontend;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");

// Get the PrintingHouseApiUrl from the WebAssembly host configuration (appsettings.json in wwwroot)
var printingHouseApiUrl = builder.Configuration["PrintingHouseApiUrl"] ??
    throw new Exception("PrintingHouseApiUrl is not set");

// Configure services for HttpClient with base URL for API calls
builder.Services.AddTransient<AuthService>();

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(printingHouseApiUrl) });
builder.Services.AddHttpClient<CustomersClient>(client => client.BaseAddress = new Uri(printingHouseApiUrl)).AddHttpMessageHandler<AuthService>();
builder.Services.AddHttpClient<JobDetailsClient>(client => client.BaseAddress = new Uri(printingHouseApiUrl));
builder.Services.AddHttpClient<JobOrderClient>(client => client.BaseAddress = new Uri(printingHouseApiUrl));
builder.Services.AddHttpClient<UserLoginClient>(client => client.BaseAddress = new Uri(printingHouseApiUrl));

// Add local storage for WebAssembly
builder.Services.AddBlazoredLocalStorage();

await builder.Build().RunAsync();
