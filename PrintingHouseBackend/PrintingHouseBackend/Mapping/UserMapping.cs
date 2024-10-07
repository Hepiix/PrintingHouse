using PrintingHouseBackend.Dtos;
using PrintingHouseBackend.Dtos.CustomerDtos;
using PrintingHouseBackend.Models;

namespace PrintingHouseBackend.Mapping;

public static class UserMapping
{
    public static UserModel ToEntity(this RegisterDto user)
    {
        return new UserModel()
        {
            Email = user.Email,
            Password = user.Password,
            FirstName = user.FirstName,
            LastName = user.LastName
        };
    }
}