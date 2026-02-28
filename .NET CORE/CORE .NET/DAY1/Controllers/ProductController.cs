using AutoMapper;
using DAY1.DTO;
using DAY1.Interfaces;
using DAY1.Model;
using DAY1.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DAY1.Controllers
{
    [Authorize]
    [ApiController]
    [Route("/api/[controller]")]
    public class ProductsController : Controller
    {
        private readonly IProductServices _services;

        public ProductsController(IProductServices services)
        {
            _services = services;
        }
        [Authorize(Roles = "Admin,Customer")]
        [HttpGet]
        public IActionResult GetAllProducts()
        {
            var product = _services.GetAllProducts();

            return Ok(product);
        }

        [Authorize(Roles = "Admin,Customer")]
        [HttpGet("category/{name}")]
        public IActionResult GetProductByCategory(string name)
        {
            var ans = _services.GetProductByCategory(name);
            return Ok(ans);
        }

        [Authorize(Roles = "Admin,Customer")]
        [HttpGet("{id:int}")]
        public IActionResult GetProductById(int id)
        {
            var ans = _services.GetProductById(id);
            if (ans == null)
            {
                return NotFound();
            }
            return Ok(ans);

        }

        [Authorize(Roles = "Admin,Vendor")]
        [HttpPost]
        public IActionResult AddProduct(CreateProductDto product)
        {
            var ans = _services.AddProduct(product);
            return Created($"api/Product/{ans.Name}", ans);
        }

        [HttpDelete("{id:int}")]
        [Authorize(Roles = "Admin")]

        public bool DeleteProduct(int id)
        {
            var ans = _services.DeleteProductById(id);
            return ans;
        }

        [Authorize(Roles = "Admin,Vendor")]
        [HttpPut("{id:int}")]
        public IActionResult UpdateProductById(int id,CreateProductDto product)
        {
            var dto=_services.UpdateProductById(id, product);
            if (dto == null)
            {
                return NotFound();
            }
            return Ok(dto);
        }

    }
}
