using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ControllerToView_April071024.Models
{
    public class student
    {
        [Display(Name ="Roll Number")]
        public int roll { get; set; }
        [Display(Name = "StudentName")]
        public string name { get; set; }
        public bool admission { get; set; }

    }
}