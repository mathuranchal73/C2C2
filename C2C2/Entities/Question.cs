using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace C2C2.Entities
{
    public class Question
    {
        [HiddenInput(DisplayValue = false)]
        public int QuestionId { get; set; }

        [DataType(DataType.MultilineText)]
        [Required(ErrorMessage = "Please enter a question")]
        public string QuestionText { get; set; }
        
        [Required(ErrorMessage = "Please enter answer option 1")]
        public string ans1 { get; set; }
        [Required(ErrorMessage = "Please enter answer option 2")]
        public string ans2 { get; set; }

        [Required(ErrorMessage = "Please enter answer option 3")]
        public string ans3 { get; set; }

        [Required(ErrorMessage = "Please enter answer option 4")]
        public string ans4 { get; set; }

        [Required(ErrorMessage = "Please enter the correct option")]
        public string cans { get; set; }
    }
}

