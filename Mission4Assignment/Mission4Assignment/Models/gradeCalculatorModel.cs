using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mission4Assignment.Models
{
    public class gradeCalculatorModel
    {
        [Range(0, 100)] //// validation
        public double assignments { get; set; }
        [Range(0, 100)]
        public double groupProject { get; set; }
        [Range(0, 100)]
        public double quizzes { get; set; }
        [Range(0, 100)]
        public double midterm { get; set; }
        [Range(0, 100)]
        public double final { get; set; }
        [Range(0, 100)]
        public double intex { get; set; }
    }
}
