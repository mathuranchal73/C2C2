using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using C2C2.Entities;

namespace C2C2.Models.QuestionViewModels
{
    public class QuestionViewModel
    {


        public IEnumerable<Question> Question { get; set; }
        public IEnumerable<Subject> Subject { get; set; }
    }
}
