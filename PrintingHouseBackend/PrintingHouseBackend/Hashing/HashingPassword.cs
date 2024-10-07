using Microsoft.AspNetCore.Identity;
using PrintingHouseBackend.Models;
using System.Security.Cryptography;

namespace PrintingHouseBackend.Hashing;

public class HashingPassword
{
    private const int SaltSize = 16;
    private const int KeySize = 32;
    private const int Iterations = 10000;

    public static string HashPassword(string password)
    {
        using (var rng = RandomNumberGenerator.Create())
        {
            var salt = new byte[SaltSize];
            rng.GetBytes(salt); 
            using (var pbkdf2 = new Rfc2898DeriveBytes(password, salt, Iterations, HashAlgorithmName.SHA256))
            {
                var hash = pbkdf2.GetBytes(KeySize); 
                var hashBytes = new byte[SaltSize + KeySize];
                Array.Copy(salt, 0, hashBytes, 0, SaltSize);
                Array.Copy(hash, 0, hashBytes, SaltSize, KeySize);
           
                return Convert.ToBase64String(hashBytes);
            }
        }
    }

    public static bool VerifyPassword(string inputPassword, string storedHash)
    {
        
        byte[] hashBytes = Convert.FromBase64String(storedHash);
        var salt = new byte[SaltSize];
        Array.Copy(hashBytes, 0, salt, 0, SaltSize);
        using (var pbkdf2 = new Rfc2898DeriveBytes(inputPassword, salt, Iterations, HashAlgorithmName.SHA256))
        {
            var hash = pbkdf2.GetBytes(KeySize);
            for (int i = 0; i < KeySize; i++)
            {
                if (hashBytes[i + SaltSize] != hash[i])
                {
                    return false; 
                }
            }
        }
        return true; 
    }
    public static bool Login(string userPassword, string password)
    {
        bool isPasswordValid = VerifyPassword(password, userPassword);
        if (isPasswordValid)
        {
            return true;
        }
        return false;
    }
}