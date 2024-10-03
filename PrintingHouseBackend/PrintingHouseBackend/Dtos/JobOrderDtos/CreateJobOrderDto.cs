using PrintingHouseBackend.Models;

namespace PrintingHouseBackend.Dtos.JobOrderDtos;

public record class CreateJobOrderDto(
    int CustomerId,
    Customer Customer,
    int JobDetailsId,
    JobDetails JobDetails,
    DateOnly OrderDate,
    string Status,
    string DeliveryMethod
    );