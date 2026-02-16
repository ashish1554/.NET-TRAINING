using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCORE.Entities
{
    public class Course
    {
        public int Id { get; set; }
        public string TItle { get; set; }
        public int Fees { get; set; }
        public int DurationInMonths { get; set; }
     

    }
}
