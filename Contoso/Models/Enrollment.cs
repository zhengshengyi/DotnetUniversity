using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Contoso.Models
{
    public enum Grade
    {
        A, B, C, D, F
    }

    public class Enrollment
    {
        [Display(Name = "注册ID")]
        public int EnrollmentID { get; set; }
        [Display(Name = "课程ID")]
        public int CourseID { get; set; }
        [Display(Name = "学生ID")]
        public int StudentID { get; set; }

        [Display(Name = "等级")]
        [DisplayFormat(NullDisplayText = "No grade")]
        public Grade? Grade { get; set; }

        [Display(Name = "课程")]
        public Course Course { get; set; }
        [Display(Name = "学生")]
        public Student Student { get; set; }
    }
}
