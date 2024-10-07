using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using PrintingHouseBackend.Data;
using PrintingHouseBackend.Dtos;
using PrintingHouseBackend.Dtos.CustomerDtos;
using PrintingHouseBackend.Mapping;
using PrintingHouseBackend.Models;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using PrintingHouseBackend.Hashing;

namespace PrintingHouseBackend.EndPoints;

public static class AuthEndpoints
{
    public static RouteGroupBuilder MapAuthEndpoints(this WebApplication app)
    {
        var group = app.MapGroup("auth");

        // POST /auth/login
        group.MapPost("/login", async (LoginDto loginDto, PrintingHouseContext dbContext, IConfiguration config) =>
        {
            var plainPassword = loginDto.Password;
            var user = await dbContext.UsersData.FirstOrDefaultAsync(u => u.Email == loginDto.Email);
            bool isValid;
            if (user == null)
            {
                return Results.NotFound("User not found");
            }
            else
            {
                isValid = HashingPassword.Login(user.Password, plainPassword);
            }
            if (!isValid)
            {
                return Results.NotFound("Password not correct");
            }
            // jwt token
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(config["JwtSettings:Secret"]);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new[]
                {
                    new Claim(ClaimTypes.Name, user.Id.ToString()),
                    new Claim(ClaimTypes.Email, user.Email)
                }),
                Expires = DateTime.UtcNow.AddHours(1),
                Issuer = config["JwtSettings:Issuer"],
                Audience = config["JwtSettings:Audience"],
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature),
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            var tokenString = tokenHandler.WriteToken(token);
            return Results.Ok(new { Token = tokenString, UserName = $"{user.FirstName} {user.LastName}" });
        });

        // POST auth/register
        group.MapPost("/register", async (RegisterDto newUser, PrintingHouseContext dbContext) =>
        {
            UserModel user = newUser.ToEntity();
            if(dbContext.UsersData.FirstOrDefault(u => u.Email == user.Email) is null)
            {
                user.Password = HashingPassword.HashPassword(user.Password);
                dbContext.UsersData.Add(user);
                await dbContext.SaveChangesAsync();
                return Results.Ok();
            }
            else
            {
                return Results.Conflict();
            }
        });
        return group;
    }
}