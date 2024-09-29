using PrintingHouseFrontend.Models;
using System.Net.Http.Json;

namespace PrintingHouseFrontend.Clients;

public class JobDetailsClient(HttpClient httpClient)
{
    public async Task<JobDetails[]> GetJobsDetailsAsync()
        => await httpClient.GetFromJsonAsync<JobDetails[]>("jobsdetails") ?? [];

    public async Task<JobDetails> GetJobDetailsAsync(int id)
        => await httpClient.GetFromJsonAsync<JobDetails>($"jobsdetails/{id}")
        ?? throw new Exception("Could not find jobdetails");

    public async Task AddJobDetailsAsync(JobDetails jobDetails)
        => await httpClient.PostAsJsonAsync("jobsdetails", jobDetails);

    public async Task UpdateJobDetailsAsync(JobDetails updatedJobDetails)
        => await httpClient.PutAsJsonAsync($"jobsdetails/{updatedJobDetails.Id}", updatedJobDetails);

    public async Task DeleteJobDetailsAsync(int id)
        => await httpClient.DeleteAsync($"jobsdetails/{id}");
}
