using PrintingHouseBackend.Models;

namespace PrintingHouseBackend.Dtos.JobOrderDtos;

public record class UpdatedJobOrderDto(
    int CustomerId,
    Customer Customer,
    int JobDetailsId,
    JobDetails JobDetails,
    DateOnly OrderDate,
    bool Status
    );
