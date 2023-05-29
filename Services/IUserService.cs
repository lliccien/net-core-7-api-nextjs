using products_app.Models;
using products_app.Models.DTO;

namespace products_app.Services;

public interface IUserService
{
    Task Create(User user);
    Task<User?> GetUserByUserNameAndPassword(string email);
}
