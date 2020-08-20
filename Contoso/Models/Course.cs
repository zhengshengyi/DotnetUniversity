using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Contoso.Models
{
    public class Course
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "课程ID")]
        public int CourseID { get; set; }

        [StringLength(50, MinimumLength = 3)]
        [Display(Name = "课程标题")]
        public string Title { get; set; }

        [Range(0, 5)]
        [Display(Name = "学分")]
        public int Credits { get; set; }

        [Display(Name = "部门ID")]
        public int DepartmentID { get; set; }

        [Display(Name = "部门")]
        public Department Department { get; set; }

        [Display(Name = "注册")]
        public ICollection<Enrollment> Enrollments { get; set; }
       

        [Display(Name = "分配的课程")]
        public ICollection<CourseAssignment> CourseAssignments { get; set; }
    }
}
