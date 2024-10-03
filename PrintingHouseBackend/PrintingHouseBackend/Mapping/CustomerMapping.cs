using PrintingHouseBackend.Dtos.CustomerDtos;
using PrintingHouseBackend.Models;

namespace PrintingHouseBackend.Mapping;

public static class CustomerMapping
{
    public static Customer ToEntity(this CreateCustomerDto customer)
    {
        return new Customer()
        {
            Name = customer.Name,
            Surname = customer.Surname,
            Company = customer.Company,
            PhoneNumber = customer.PhoneNumber,
            Email = customer.Email,
            StreetAddress = customer.StreetAddress,
            City = customer.City,
            State = customer.State,
            PostalCode = customer.PostalCode,
            Country = customer.Country
        };
    }

    public static Customer ToEntity(this UpdatedCustomerDto customer, int id)
    {
        return new Customer()
        {
            Id = id,
            Name = customer.Name,
            Surname = customer.Surname,
            Company = customer.Company,
            PhoneNumber = customer.PhoneNumber,
            Email = customer.Email,
            StreetAddress = customer.StreetAddress,
            City = customer.City,
            State = customer.State,
            PostalCode = customer.PostalCode,
            Country = customer.Country
        };
    }
}
