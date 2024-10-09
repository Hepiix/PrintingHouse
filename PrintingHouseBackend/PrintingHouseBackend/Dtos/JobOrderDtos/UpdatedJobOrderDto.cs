using PrintingHouseBackend.Models;

namespace PrintingHouseBackend.Dtos.JobOrderDtos;

public record class UpdatedJobOrderDto(
    int CustomerId,
    Customer Customer,
    int JobDetailsId,
    JobDetails JobDetails,
    DateOnly OrderDate,
    int Quantity,
    decimal TotalPrice,
    string Status,
    string DeliveryMethod,
    string CustomerNote
    );