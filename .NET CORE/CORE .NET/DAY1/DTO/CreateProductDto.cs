using System.ComponentModel.DataAnnotations;

namespace DAY1.DTO
{
    public class CreateProductDto
    {
        //[Required(ErrorMessage = "Name field is required")]   
        [Required] //[ApiController] automatically valid this for me if even i dont use error message

        public string Name { get; set; } = string.Empty;
        [Required(ErrorMessage = "Category field is required")]
        public string Category { get; set; } = string.Empty;
        [Required(ErrorMessage = "SellPrice field is required")]
        [Range(1000, 200000, ErrorMessage = "SellPrice must be between 1000 and 200000")]
        public decimal SellPrice { get; set; }

        [Required]
        [Range(0, 10000, ErrorMessage = "Stock must be between 0 to 10000")]
        public int Stock { get; set; }

        [Required]
        [Range(100, 100000, ErrorMessage = "CostPrice must be between 0 to 10000")]

        public decimal CostPrice { get; set; }
    }
}
