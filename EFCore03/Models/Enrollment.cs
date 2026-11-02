using EFCore03.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore03.Models
{
    public class Enrollment
    { 
        public int Id { get; set; }

        public DateTime EnrollmentDate { get; set; }

        public decimal ProgressPercentage { get; set; }

        public EnrollmentStatus Status { get; set; }

        public decimal? FinalGrade { get; set; }
        public int StudentsId   { get; set; }
        public Student Students { get; set; }

        public int CoursesId { get; set; }
        public Course Courses { get; set; }


    }
}
