﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Contoso.Models
{
    public class OfficeAssignment
    {
        [Key]
        [Display(Name = "教师ID")]
        public int InstructorID { get; set; }

        [StringLength(50)]
        [Display(Name = "办公地点")]
        public string Location { get; set; }

        [Required]
        [Display(Name = "教师")]
        public Instructor Instructor { get; set; }
    }
}
