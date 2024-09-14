using PrintingHouseFrontend.Models;

namespace PrintingHouseFrontend.Clients;

public class JobOrderClient(HttpClient httpClient)
{
    public async Task<JobOrderViewModel[]> GetJobOrdersAsync()
        => await httpClient.GetFromJsonAsync<JobOrderViewModel[]>("jobsorders") ?? [];

    public async Task<JobOrderViewModel> GetJobOrderAsync(int id)
        => await httpClient.GetFromJsonAsync<JobOrderViewModel>($"jobsorders/{id}")
        ?? throw new Exception("Could not find joborder");

    public async Task AddJobOrderAsync(JobOrderEntity jobOrder)
        => await httpClient.PostAsJsonAsync("jobsorders", jobOrder);

    public async Task UpdateJobOrderAsync(JobOrderEntity updatedJobOrder)
        => await httpClient.PutAsJsonAsync($"jobsorders/{updatedJobOrder.Id}", updatedJobOrder);

    public async Task DeleteJobOrderAsync(int id)
        => await httpClient.DeleteAsync($"jobsorders/{id}");
}
