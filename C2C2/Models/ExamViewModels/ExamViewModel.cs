using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using C2C2.Entities;

namespace C2C2.Models.ExamViewModels
{
    public class ExamViewModel
    {

        public IEnumerable<Exam> Question { get; set; }
    }
}
