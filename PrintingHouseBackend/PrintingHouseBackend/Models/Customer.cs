namespace PrintingHouseBackend.Models;

public class Customer
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public required string Surname { get; set; }
    public string? Company { get; set; }
    public required string PhoneNumber { get; set; }
}
