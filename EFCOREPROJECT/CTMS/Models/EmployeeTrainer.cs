using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTMS.Models
{
    public class EmployeeTrainer
    {
        public int EmployeeId { get; set; }
        public string ExpertiseLevel { get; set; }=string.Empty;


        public Employee? Employee { get; set; }


        public List<TrainingProgram> TrainingPrograms { get; set; } = new List<TrainingProgram>();


    }
}
