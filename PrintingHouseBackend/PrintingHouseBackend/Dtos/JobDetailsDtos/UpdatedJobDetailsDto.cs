namespace PrintingHouseBackend.Dtos.JobDetailsDtos;

public record class UpdatedJobDetailsDto(
    string Name,
    string Pattern,
    string PaperType,
    string Dimensions,
    string ColorMode,
    string PrintSides,
    decimal UnitPrice);