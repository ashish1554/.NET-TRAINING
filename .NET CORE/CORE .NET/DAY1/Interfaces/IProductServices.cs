using DAY1.DTO;
using DAY1.Model;

namespace DAY1.Interfaces
{
    public interface IProductServices
    {
        List<ProductShowDto> GetAllProducts();
        ProductShowDto? GetProductById(int id);

        List<ProductShowDto> GetProductByCategory(string name);

        bool DeleteProductById(int id);

        ProductShowDto AddProduct(CreateProduct product);

        //ProductShowDto UpdateProductById (int id, Product product);
        ProductShowDto UpdateProductById (int id, CreateProduct product);


    }
}
