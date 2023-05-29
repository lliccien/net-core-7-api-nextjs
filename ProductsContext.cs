using Microsoft.EntityFrameworkCore;
using products_app.Models;

namespace products_app;

public class ProductsContext: DbContext
{
    public DbSet<Product> Products {get;set;}
    public DbSet<User> Users {get;set;}
    public ProductsContext(DbContextOptions<ProductsContext> options) :base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder) 
    {
        List<Product> productsInit =  new List<Product>();
        productsInit.Add(new Product() { 
            Id = Guid.NewGuid(),
            Name = " Producto 1",
            Price = 10.5f,
            Stock = 10,
            Image = "peoduct.png",
            CreatedAt = DateTime.Now,
            UpdatedAt =  DateTime.Now
        });
        productsInit.Add(new Product() { 
            Id = Guid.NewGuid(),
            Name = " Producto 2",
            Price = 20.5f,
            Stock = 20,
            Image = "peoduct.png",
            CreatedAt = DateTime.Now,
            UpdatedAt =  DateTime.Now
        });
        productsInit.Add(new Product() { 
            Id = Guid.NewGuid(),
            Name = " Producto 3",
            Price = 30.5f,
            Stock = 30,
            Image = "peoduct.png",
            CreatedAt = DateTime.Now,
            UpdatedAt =  DateTime.Now
        });
        productsInit.Add(new Product() { 
            Id = Guid.NewGuid(),
            Name = " Producto 4",
            Price = 40.5f,
            Stock = 40,
            Image = "peoduct.png",
            CreatedAt = DateTime.Now,
            UpdatedAt =  DateTime.Now
        });                
        productsInit.Add(new Product() { 
            Id = Guid.NewGuid(),
            Name = " Producto 5",
            Price = 50.5f,
            Stock = 50,
            Image = "peoduct.png",
            CreatedAt = DateTime.Now,
            UpdatedAt =  DateTime.Now
        });

        modelBuilder.Entity<Product>(product => {
            product.ToTable("Products");
            product.HasKey(p => p.Id);

            product.Property(p => p.Name).IsRequired();
            
            product.Property(p => p.Price);

            product.Property(p => p.Stock);

            product.Property(p => p.Image);

            product.Property(p => p.CreatedAt).HasDefaultValue(DateTime.Now);

            product.Property(p => p.UpdatedAt).HasDefaultValue(DateTime.Now);

            product.HasData(productsInit);

        });

        modelBuilder.Entity<User>(user => {

            user.ToTable("Users");
            user.HasKey(p => p.Id);

            user.Property(p => p.FirstName);

            user.Property(p => p.LastName);

            user.Property(p => p.Email).IsRequired();

            user.Property(p => p.Password);

            user.Property(p => p.StoredSalt).IsRequired(false);

            user.Property(p => p.CreatedAt).HasDefaultValue(DateTime.Now);

            user.Property(p => p.UpdatedAt).HasDefaultValue(DateTime.Now);

        });
    }
}
