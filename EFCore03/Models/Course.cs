using EFCore03.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore03.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string? Description { get; set; }
        public decimal Price { get; set; }
        public bool IsPublished { get; set; }
        public CourseLevel Level { get; set; }

        public DateTime? PublishedDate { get; set; }
        
        public int InstructorsId { get; set; }
        public Instructor Instructors { get; set; }

        public int CategorysId { get; set; }
        public Category Categorys { get; set; }

        public List<Enrollment> Enrollments   { get; set; }

       

    }
}
