namespace PrintingHouseBackend.Dtos.JobOrderDtos;

public record class JobOrderSummaryDto(
    int id,
    string CustomerName,
    string JobName,
    DateOnly OrderDate,
    string Status,
    string DeliveryMethod);
