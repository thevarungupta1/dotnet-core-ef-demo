using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.Data
{
    public class Grade
    {
        public int GradeId { get; set; }
        public string GradeName { get; set; }
        public Student Student { get; set; }
    }
}
