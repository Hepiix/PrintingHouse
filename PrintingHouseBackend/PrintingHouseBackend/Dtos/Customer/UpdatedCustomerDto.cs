namespace PrintingHouseBackend.Dtos.Customer;

public record class UpdatedCustomerDto(
    string Name,
    string Surname,
    string Company,
    string PhoneNumber);
