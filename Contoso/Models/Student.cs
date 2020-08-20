using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Contoso.Models
{
    public class Student
    {
        [Display(Name = "学生ID")]
        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "姓氏")]
        public string LastName { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "名字不能超过50个字符.")]
        [Display(Name = "名字")]
        [Column("FirstName")]
        public string FirstMidName { get; set; }


        [Display(Name = "注册日期")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime EnrollmentDate { get; set; }

        [Display(Name = "姓名")]
        public string FullName
        {
            get
            {
                return LastName + ", " + FirstMidName;
            }
        }

        [Display(Name = "注册")]
        public ICollection<Enrollment> Enrollments { get; set; }
    }
}
