using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCORE.Entities
{
    public class Batch
    {
        public int BatchId { get; set; }
        public DateOnly StartDate { get; set; }

        [ForeignKey("Course")]

        public int CourseId { get; set; }
        public virtual Course? Course { get; set; }
        [ForeignKey("Trainer")]
        public int TrainerId { get; set; }
        public virtual Trainer? Trainer { get; set; }
    }
}
