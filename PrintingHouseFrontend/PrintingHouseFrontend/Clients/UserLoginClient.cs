using PrintingHouseFrontend.Models;
using System.Net.Http.Json;

namespace PrintingHouseFrontend.Clients;

public class UserLoginClient(HttpClient httpClient)
{
    public async Task<HttpResponseMessage> LoginUserAsync(UserData user)
        => await httpClient.PostAsJsonAsync("auth/login", user);
}
