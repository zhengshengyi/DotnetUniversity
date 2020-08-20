using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Contoso.Models
{
    public class Department
    {
        [Display(Name = "部门ID")]
        public int DepartmentID { get; set; }

        [StringLength(50, MinimumLength = 3)]
        [Display(Name = "部门名称")]
        public string Name { get; set; }

        [DataType(DataType.Currency)]
        [Display(Name = "预算")]
        [Column(TypeName = "money")]
        public decimal Budget { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "起始日期")]
        public DateTime StartDate { get; set; }

        [Display(Name = "教师ID")]
        public int? InstructorID { get; set; }

        [Display(Name = "管理员")]
        public Instructor Administrator { get; set; }

        [Display(Name = "课程")]
        public ICollection<Course> Courses { get; set; }
    }
}
