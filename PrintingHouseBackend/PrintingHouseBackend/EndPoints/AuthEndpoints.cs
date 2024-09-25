using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using PrintingHouseBackend.Data;
using PrintingHouseBackend.Dtos;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace PrintingHouseBackend.EndPoints;

public static class AuthEndpoints
{
    public static RouteGroupBuilder MapAuthEndpoints(this WebApplication app)
    {
        var group = app.MapGroup("auth");

        // POST /auth/login
        group.MapPost("/login", async (LoginDto loginDto, PrintingHouseContext dbContext, IConfiguration config) =>
        {
            var user = await dbContext.UsersData.FirstOrDefaultAsync(u => u.Email == loginDto.Email);

            if (user == null || user.Password != loginDto.Password)
            {
                return Results.NotFound("User not found");
            }

            // jwt token
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(config["JwtSettings:Secret"]);

            var tokenDecriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new[]
                {
                    new Claim(ClaimTypes.Name, user.Id.ToString()),
                    new Claim(ClaimTypes.Email, user.Email)
                }),
                Expires = DateTime.UtcNow.AddHours(24),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature),
                Issuer = config["JwtSettings:Issuer"],
                Audience = config["JwtSettings:Audience"]
            };

            var token = tokenHandler.CreateToken(tokenDecriptor);
            var tokenString = tokenHandler.WriteToken(token);

            return Results.Ok(new { Token = tokenString });
        });

        return group;
    }
}
