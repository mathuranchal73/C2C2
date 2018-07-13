using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace C2C2.Entities
{
    public class Subject
    {
        public int SubjectId { get; set; }

        [DataType(DataType.MultilineText)]
        [Required(ErrorMessage = "Please enter a Subject")]
        public string SubjectName { get; set; }
       
        public DateTime CreatedDate { get; set; }
        
        public DateTime UpdatedDate { get; set; }
        public String CreatedBy { get; set; }


    }
}
