using PrintingHouseBackend.Dtos.JobDetailsDtos;
using PrintingHouseBackend.Models;

namespace PrintingHouseBackend.Mapping;

public static class JobDetailsMapping
{
    public static JobDetails ToEntity(this CreateJobDetailsDto jobDetails)
    {
        return new JobDetails()
        {
            Name = jobDetails.Name,
            Pattern = jobDetails.Pattern,
            PaperType = jobDetails.PaperType,
            Dimensions = jobDetails.Dimensions,
            ColorMode = jobDetails.ColorMode,
            PrintSides = jobDetails.PrintSides,
            UnitPrice = jobDetails.UnitPrice,
        };
    }

    public static JobDetails ToEntity(this UpdatedJobDetailsDto jobDetails, int id)
    {
        return new JobDetails()
        {
            Id = id,
            Name = jobDetails.Name,
            Pattern = jobDetails.Pattern,
            PaperType = jobDetails.PaperType,
            Dimensions = jobDetails.Dimensions,
            ColorMode = jobDetails.ColorMode,
            PrintSides = jobDetails.PrintSides,
            UnitPrice = jobDetails.UnitPrice,
        };
    }
}