namespace PrintingHouseBackend.Dtos;

public record class LoginDto(
    string Email,
    string Password,
    string FirstName,
    string LastName);