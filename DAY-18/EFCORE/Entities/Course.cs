using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCORE.Entities
{
    public class Course
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Column("Title")] 
        public string TItle { get; set; } = string.Empty;
        [Column(TypeName="decimal(10,2)")]
        public double Fees { get; set; }
        public int DurationInMonths { get; set; }
     
        public virtual List<Batch>?Batches { get; set; }

        public virtual List<Student> Students { get; set; } = new List<Student>();

    }
}
