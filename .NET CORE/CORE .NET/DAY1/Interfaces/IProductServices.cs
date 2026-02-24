using DAY1.Model;

namespace DAY1.Interfaces
{
    public interface IProductServices
    {
        List<Product> GetAllProducts();
        Product? GetProductById(int id);

        List<Product> GetProductByCategory(string name);

        bool DeleteProductById(int id);

        Product AddProduct(Product product);
    }
}
