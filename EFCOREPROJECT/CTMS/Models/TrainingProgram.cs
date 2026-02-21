using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTMS.Models
{
    public class TrainingProgram
    {
        public int TrainingProgramId { get; set; }
        public string Title { get; set; } = string.Empty;
        public int Duration {  get; set; }
        public DateOnly StartDate { get; set; }


        public int TrainerId { get; set; }
        public EmployeeTrainer? Trainer { get; set; }
        public List<Enrollment> Enrollments { get; set; }=new List<Enrollment>();

    }
}
