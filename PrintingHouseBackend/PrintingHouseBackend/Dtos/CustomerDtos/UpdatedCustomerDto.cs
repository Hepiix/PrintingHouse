namespace PrintingHouseBackend.Dtos.CustomerDtos;

public record class UpdatedCustomerDto(
    string Name,
    string Surname,
    string Company,
    string PhoneNumber);
