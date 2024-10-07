namespace PrintingHouseBackend.Dtos;

public record class RegisterDto(
    string Email,
    string Password,
    string FirstName,
    string LastName);