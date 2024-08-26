namespace PrintingHouseBackend.Dtos.CustomerDtos;

public record class CreateCustomerDto(
    string Name,
    string Surname,
    string Company,
    string PhoneNumber);
