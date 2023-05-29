using System.Security.Claims;
using products_app.Models;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Cryptography;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using products_app.Types;
using products_app.Models.DTO;

namespace products_app.Services;

public class AuthService: IAuthService
{
    private IUserService _userService;

    private IConfiguration _config;

    public AuthService (IUserService userService, IConfiguration config)
    {
        _userService = userService;
        _config = config;
    }

    public async Task Register(User user)
    {
        var hashSalt = EncryptPassword(user.Password);

        user.Password = hashSalt.Hash;
        user.StoredSalt = hashSalt.Salt;

        await _userService.Create(user);
    }

    public async Task<string?> Login(string email, string password)
    {
        var userFound = await _userService.GetUserByUserNameAndPassword(email);
        
        if (userFound is  null) return null;
        
        var passwordMatched = VerifyPassword(password, userFound.StoredSalt, userFound.Password);
      
        if (!passwordMatched) return null;

        var token = GenerateToken((User)userFound);
        
        return token;
    }
    private string GenerateToken(User user)
    {
        var claims =  new[]
        {
            new Claim(ClaimTypes.Actor, user.FirstName + " " + user.LastName),
            new Claim(ClaimTypes.NameIdentifier, user.Email),
        };

        var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config.GetSection("JWT:secrect").Value));

        var credentials =  new SigningCredentials(key, SecurityAlgorithms.HmacSha512Signature);

        var securityTolen = new JwtSecurityToken( claims: claims, expires: DateTime.Now.AddMinutes(60), signingCredentials: credentials);

        var token = new JwtSecurityTokenHandler().WriteToken(securityTolen);

        return token;

    }

    private HashSalt EncryptPassword(string password)
    {
        byte[] salt = new byte[128 / 8]; // Generate a 128-bit salt using a secure PRNG
        using (var rng = RandomNumberGenerator.Create())
        {
            rng.GetBytes(salt);
        }
        string encryptedPassw = Convert.ToBase64String(KeyDerivation.Pbkdf2(
            password: password,
            salt: salt,
            prf: KeyDerivationPrf.HMACSHA1,
            iterationCount: 10000,
            numBytesRequested: 256 / 8
        ));
        return new HashSalt { Hash = encryptedPassw , Salt = salt };
    }
    private bool VerifyPassword(string enteredPassword, byte[] salt, string storedPassword)
    {
        string encryptedPassw = Convert.ToBase64String(KeyDerivation.Pbkdf2(
            password: enteredPassword,
            salt: salt,
            prf: KeyDerivationPrf.HMACSHA1,
            iterationCount: 10000,
            numBytesRequested: 256 / 8
        ));
        return encryptedPassw == storedPassword;
    }

}
