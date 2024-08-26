namespace PrintingHouseBackend.Dtos.Customer;

public record class CreateCustomerDto(
    string Name,
    string Surname,
    string Company,
    string PhoneNumber);
