using Microsoft.EntityFrameworkCore;
using products_app.Models;


namespace products_app.Services;

public class UserService: IUserService
{
    private ProductsContext productsContext;

    public UserService (ProductsContext dbContext)
    {
        productsContext = dbContext;
    }

    public async Task Create(User user)
    {
        user.Id =  Guid.NewGuid();

        productsContext.Users.Add(user);
        await productsContext.SaveChangesAsync();
    }

    public async Task<User?> GetUserByUserNameAndPassword(string email)
    {
        var userFound = await productsContext.Users.FirstOrDefaultAsync(p => p.Email == email);
        
        if (userFound == null) return null;

        return userFound;
    } 
}
