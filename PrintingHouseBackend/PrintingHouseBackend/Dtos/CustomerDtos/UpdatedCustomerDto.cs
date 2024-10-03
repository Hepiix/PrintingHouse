namespace PrintingHouseBackend.Dtos.CustomerDtos;

public record class UpdatedCustomerDto(
    string Name,
    string Surname,
    string Company,
    string PhoneNumber,
    string Email,
    string StreetAddress,
    string City,
    string State,
    string PostalCode,
    string Country);
