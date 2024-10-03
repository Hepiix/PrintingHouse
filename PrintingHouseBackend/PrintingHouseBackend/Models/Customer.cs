namespace PrintingHouseBackend.Models;

public class Customer
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public required string Surname { get; set; }
    public string? Company { get; set; }
    public required string PhoneNumber { get; set; }
    public string? Email { get; set; }
    public string? StreetAddress { get; set; }
    public string? City { get; set; }
    public string? State { get; set; }
    public string? PostalCode { get; set; }
    public string? Country { get; set; }
}
