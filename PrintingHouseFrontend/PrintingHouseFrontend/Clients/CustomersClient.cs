using PrintingHouseFrontend.Models;

namespace PrintingHouseFrontend.Clients;

public class CustomersClient(HttpClient httpClient)
{
    public async Task<Customer[]> GetCustomersAsync()
        => await httpClient.GetFromJsonAsync<Customer[]>("customers") ?? [];

    public async Task<Customer> GetCustomerAsync(int id)
        => await httpClient.GetFromJsonAsync<Customer>($"customers/{id}")
        ?? throw new Exception("Could not find customer");

    public async Task AddCustomerAsync(Customer customer)
        => await httpClient.PostAsJsonAsync("customers", customer);

    public async Task UpdateCustomerAsync(Customer updatedCustomer)
        => await httpClient.PutAsJsonAsync($"customers/{updatedCustomer.Id}", updatedCustomer);

    public async Task DeleteCustomerAsync(int id)
        => await httpClient.DeleteAsync($"customers/{id}");
}
