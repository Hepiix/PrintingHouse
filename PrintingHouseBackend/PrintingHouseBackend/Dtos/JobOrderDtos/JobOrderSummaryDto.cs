namespace PrintingHouseBackend.Dtos.JobOrderDtos;

public record class JobOrderSummaryDto(
    int id,
    string CustomerName,
    string JobName,
    DateOnly OrderDate,
    int Quantity,
    decimal TotalPrice,
    string Status,
    string DeliveryMethod,
    string CustomerNote);