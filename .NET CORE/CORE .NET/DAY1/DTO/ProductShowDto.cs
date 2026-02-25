using System.ComponentModel.DataAnnotations;

namespace DAY1.DTO
{
    public class ProductShowDto
    {

        public string Name { get; set; } = string.Empty;

        public string Category { get; set; } = string.Empty;

        public decimal SellPrice { get; set; }

        public int Stock { get; set; }

    }
}
