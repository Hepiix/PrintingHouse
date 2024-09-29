using System.Net.Http.Headers;
using System.Threading;
using System.Threading.Tasks;
using Blazored.LocalStorage;

namespace PrintingHouseFrontend.Clients;

public class AuthService : DelegatingHandler
{
    private readonly ILocalStorageService _localStorage;

    public AuthService(ILocalStorageService localStorage)
    {
        _localStorage = localStorage;
    }

    protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
    {
        try
        {
            var token = await _localStorage.GetItemAsStringAsync("token");
            if (!string.IsNullOrWhiteSpace(token))
            {
                // Add the JWT token to the request headers
                request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", token);
            }
        }
        catch
        {
            Console.WriteLine("Client not rendered");
            return await base.SendAsync(request, cancellationToken);
        }



        // Proceed with the request
        return await base.SendAsync(request, cancellationToken);
    }
}

