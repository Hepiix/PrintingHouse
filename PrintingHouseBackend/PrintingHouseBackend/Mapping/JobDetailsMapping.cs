using PrintingHouseBackend.Dtos.JobDetails;
using PrintingHouseBackend.Models;

namespace PrintingHouseBackend.Mapping;

public static class JobDetailsMapping
{
    public static JobDetails ToEntity(this CreateJobDetailsDto jobDetails)
    {
        return new JobDetails()
        {
            Name = jobDetails.Name,
            Pattern = jobDetails.Pattern
        };
    }

    public static JobDetails ToEntity(this UpdatedJobDetailsDto jobDetails, int id)
    {
        return new JobDetails()
        {
            Id = id,
            Name = jobDetails.Name,
            Pattern = jobDetails.Pattern
        };
    }
}
