
using products_app.Models;
using products_app.Models.DTO;

namespace products_app.Services;

public interface IAuthService
{
    Task Register(User user);
    Task<string?> Login(string email, string password);
}
