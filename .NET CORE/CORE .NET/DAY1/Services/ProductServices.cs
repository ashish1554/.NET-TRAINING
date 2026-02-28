using AutoMapper;
using DAY1.Data;
using DAY1.DTO;
using DAY1.Interfaces;
using DAY1.Model;
using Microsoft.EntityFrameworkCore;

namespace DAY1.Services
{
    public class ProductServices : IProductServices
    {
        
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;
        public ProductServices(AppDbContext context,IMapper mapper)
        {
            _context= context;
            _mapper = mapper;
        }
        public ProductShowDto AddProduct(CreateProductDto product)
        {
            var products = _mapper.Map<Product>(product);
            _context.Products.Add(products);
            _context.SaveChanges();
            return _mapper.Map<ProductShowDto>(products);
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
            return false ;
        }

        public List<ProductShowDto> GetAllProducts()
        {
            var products = _context.Products.AsNoTracking().ToList();
            var finalDto = _mapper.Map<List<ProductShowDto>>(products);
            return finalDto;
        }

        public List<ProductShowDto> GetProductByCategory(string name)
        {
            var result = _context.Products.AsNoTracking().Where(x=>x.Category==name).ToList();
            var finalDto = _mapper.Map<List<ProductShowDto>>(result);
            return finalDto;
        }

        public ProductShowDto GetProductById(int id)
        {
            var product= _context.Products.Find(id);
            var finalDto = _mapper.Map<ProductShowDto>(product);
            return finalDto;

        }

       

        public ProductShowDto UpdateProductById(int id, CreateProductDto pro)
        {
            
            var product = _context.Products.Find(id);
            if (product == null)
            {
                return null;
            }
            product.Name = pro.Name;
            product.Category = pro.Category;
            product.SellPrice = pro.SellPrice;
            product.CostPrice = pro.CostPrice;
            product.Stock = pro.Stock;

            //_context.Products.Update(product);
            _context.SaveChanges();
            var finalDto = _mapper.Map<ProductShowDto>(product);
            return finalDto;
        }
    }
}
