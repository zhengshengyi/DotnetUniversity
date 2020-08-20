using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Contoso.Models
{
    public class Instructor
    {
        [Display(Name = "教师ID")]
        public int ID { get; set; }

        [Required]
        [Display(Name = "姓氏")]
        [StringLength(50)]
        public string LastName { get; set; }

        [Required]
        [Column("FirstName")]
        [Display(Name = "名字")]
        [StringLength(50)]
        public string FirstMidName { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "聘请日期")]
        public DateTime HireDate { get; set; }

        [Display(Name = "姓名")]
        public string FullName
        {
            get { return LastName + ", " + FirstMidName; }
        }

        [Display(Name = "分配的课程")]
        public ICollection<CourseAssignment> CourseAssignments { get; set; }

        [Display(Name = "分配的办公室")]
        public OfficeAssignment OfficeAssignment { get; set; }
    }
}
