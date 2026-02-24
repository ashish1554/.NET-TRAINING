using DAY1.Data;
using DAY1.Interfaces;
using DAY1.Model;
using Microsoft.EntityFrameworkCore;

namespace DAY1.Services
{
    public class ProductServices : IProductServices
    {
        private readonly AppDbContext _context;
        public ProductServices(AppDbContext context)
        {
            _context= context;
        }
        public Product AddProduct(Product product)
        {
           _context.Products.Add(product);
            _context.SaveChanges();
            return product;
        }

        public bool DeleteProductById(int id)
        {
            var product = _context.Products.Find(id);
            if(product!=null)
            {
                _context.Products.Remove(product);
                _context.SaveChanges();
                return true;
            }
            return false;
        }

        public List<Product> GetAllProducts()
        {
            return _context.Products.AsNoTracking().ToList();
        }

        public List<Product> GetProductByCategory(string name)
        {
            var result = _context.Products.AsNoTracking().Where(x=>x.Category==name).ToList();
            return result;
        }

        public Product? GetProductById(int id)
        {
           return _context.Products.Find(id);

        }
    }
}
