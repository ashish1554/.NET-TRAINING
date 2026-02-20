using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCORE.Entities
{
    public class Trainer
    {
        public int TrainerId { get; set; }
        [Column(TypeName = "nvarchar(20)")]
        public string Name { get; set; } = string.Empty;
        public int Experience { get; set; }

        public virtual List<Batch> Batches { get; set; }=new List<Batch>();

    }
}
