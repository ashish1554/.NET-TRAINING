using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTMS.Models
{
    public class Enrollment
    {
        public int EmployeeId { get; set; }
        public int TrainingProgramId { get; set; }
        public DateOnly EnrollDate { get; set; }
        public int PerformanceScore { get; set; }

        public Employee? Employee { get; set; }
        public TrainingProgram? TrainingProgram { get; set; }
    }
}
