using products_app.Models;

namespace products_app.Services;

public class ProductService: IProductService
{
    ProductsContext productContext;

    ILogger<ProductService> _logger;

    public ProductService(ProductsContext dbContext, ILogger<ProductService> logger)
    {
        productContext = dbContext;
        _logger = logger;
    }

    public IEnumerable<Product> GetAll()
    {
        return productContext.Products;   
    }

    public Product? GetById(Guid id)
    {
        var productFound =  productContext.Products.Find(id);

        return productFound != null ? productFound : null;
    }
   
    public void Create(Product product)
    {
        product.Id = Guid.NewGuid();
        product.CreatedAt = DateTime.Now;
        product.UpdatedAt = DateTime.Now;

        productContext.Add(product);
        productContext.SaveChanges();
    }

    public Product? Update(Guid id, Product product)
    {

        var productFound =  productContext.Products.Find(id);

        if(productFound is null) return null;

        productFound.Name = product.Name != null ? product.Name : productFound.Name;

        productFound.Price = product.Price != 0 ? product.Price : productFound.Price;

        productFound.Stock = product.Stock != 0 ? product.Stock : productFound.Stock;

        productFound.Image = product.Image != null ? product.Image : productFound.Image;
     
        product.UpdatedAt = DateTime.Now;

        productContext.SaveChanges();

        return productFound;
    }

        public void Delete(Guid id)
    {
        var productFound =  productContext.Products.Find(id);

        if(productFound != null)
        {
            productContext.Remove(productFound);

            productContext.SaveChanges();
        } 
        

    }


}
