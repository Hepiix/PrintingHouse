namespace PrintingHouseBackend.Dtos.JobDetailsDtos;

public record class UpdatedJobDetailsDto(
    string Name,
    string Pattern,
    int Quantity,
    string PaperType,
    string Dimensions,
    string ColorMode,
    string PrintSides,
    decimal UnitPrice,
    decimal TotalPrice);

