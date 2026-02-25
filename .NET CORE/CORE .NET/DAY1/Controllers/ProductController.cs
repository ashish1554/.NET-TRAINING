using AutoMapper;
using DAY1.DTO;
using DAY1.Interfaces;
using DAY1.Model;
using DAY1.Services;
using Microsoft.AspNetCore.Mvc;

namespace DAY1.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class ProductsController : Controller
    {
        private readonly IProductServices _services;

        public ProductsController(IProductServices services)
        {
            _services = services;
        }
        [HttpGet]
        public IActionResult GetAllProducts()
        {
            var product = _services.GetAllProducts();

            return Ok(product);
        }

        [HttpGet("category/{name}")]
        public IActionResult GetProductByCategory(string name)
        {
            var ans = _services.GetProductByCategory(name);
            return Ok(ans);
        }

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

        [HttpPost]
        public IActionResult AddProduct(CreateProduct product)
        {
            var ans = _services.AddProduct(product);
            return Created($"api/Product/{ans.Name}", ans);
        }

        [HttpDelete]

        public bool DeleteProduct(int id)
        {
            var ans = _services.DeleteProductById(id);
            return ans;
        }


        [HttpPut]
        public IActionResult UpdateProductById(int id,CreateProduct product)
        {
            var dto=_services.UpdateProductById(id, product);
            return Ok(dto);

        }

    }
}
