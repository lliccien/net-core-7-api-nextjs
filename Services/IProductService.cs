using products_app.Models;

namespace products_app.Services;

public interface IProductService
{
    IEnumerable<Product> GetAll();
    Product? GetById(Guid id);
    void Create(Product product);
    Product? Update(Guid id, Product product);
    void Delete(Guid id);
}
