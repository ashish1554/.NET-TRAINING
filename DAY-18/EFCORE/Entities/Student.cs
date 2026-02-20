using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCORE.Entities
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string? Name { get; set; }
        [Required]
        public string? Email { get; set; }

        public int Marks { get; set; }
  
        public DateTime CreatedAt { get; set; }

        public virtual List<Course> Courses { get; set; } = new List<Course>();
    }
}
