using EFCore03.Enum;
using EFCore03.Models;

namespace EFCore03
{
    internal class Program
    {
        static void Main(string[] args)
        {

            using (var context = new AppDbcontext())
            {
                #region Seed Students

                if (!context.Students.Any())
                {
                    var students = new List<Student>
            {
                new Student
                {
                    FullName = "Ali Ahmed",
                    Email = "ali@gmail.com",
                    DateOfBirth = new DateTime(2000, 5, 10)
                },
                new Student
                {
                    FullName = "Omar Mohamed",
                    Email = "omar@gmail.com",
                    DateOfBirth = new DateTime(2001, 3, 15)
                },
                new Student
                {
                    FullName = "Sara Hassan",
                    Email = "sara@gmail.com",
                    DateOfBirth = new DateTime(1999, 8, 20)
                },
                new Student
                {
                    FullName = "Mona Ali",
                    Email = "mona@gmail.com",
                    DateOfBirth = new DateTime(2002, 1, 25)
                },
                new Student
                {
                    FullName = "Khaled Samir",
                    Email = "khaled@gmail.com",
                    DateOfBirth = new DateTime(2000, 11, 5)
                }
            };

                    context.Students.AddRange(students);

                    context.SaveChanges();

                }

            }
                #endregion
                #region Seed Enrollments

            using (var context = new AppDbcontext())
            {
                if (!context.Enrollments.Any())
                {
                    var enrollments = new List<Enrollment>
        {
            // Completed
            new Enrollment
            {
                Id = 1,
                CoursesId = 1,
                EnrollmentDate = new DateTime(2025, 6, 1),
                ProgressPercentage = 100,
                Status = EnrollmentStatus.Completed,
                FinalGrade = 95
            },

            // Active
            new Enrollment
            {
                Id = 2,
                CoursesId = 1,
                EnrollmentDate = new DateTime(2025, 6, 2),
                ProgressPercentage = 45,
                Status = EnrollmentStatus.Active,
                FinalGrade = null
            },

            // Completed
            new Enrollment
            {
               Id = 3,
                CoursesId = 2,
                EnrollmentDate = new DateTime(2025, 6, 3),
                ProgressPercentage = 100,
                Status = EnrollmentStatus.Completed,
                FinalGrade = 88
            },

            // Dropped
            new Enrollment
            {
                Id = 4,
                CoursesId = 2,
                EnrollmentDate = new DateTime(2025, 6, 4),
                ProgressPercentage = 30,
                Status = EnrollmentStatus.Dropped,
                FinalGrade = null
            },

            // Active
            new Enrollment
            {
               Id = 5,
                CoursesId = 3,
                EnrollmentDate = new DateTime(2025, 6, 5),
                ProgressPercentage = 60,
                Status = EnrollmentStatus.Active,
                FinalGrade = null
            },

            // Dropped
            new Enrollment
            {
               Id = 1,
                CoursesId = 4,
                EnrollmentDate = new DateTime(2025, 6, 6),
                ProgressPercentage = 20,
                Status = EnrollmentStatus.Dropped,
                FinalGrade = null
            },

            // Completed
            new Enrollment
            {Id = 2,
                CoursesId = 5,
                EnrollmentDate = new DateTime(2025, 6, 7),
                ProgressPercentage = 100,
                Status = EnrollmentStatus.Completed,
                FinalGrade = 91
            },

            // Active
            new Enrollment
            {
                Id = 3,
                CoursesId = 5,
                EnrollmentDate = new DateTime(2025, 6, 8),
                ProgressPercentage = 75,
                Status = EnrollmentStatus.Active,
                FinalGrade = null
            }
        };

                    context.Enrollments.AddRange(enrollments);

                    context.SaveChanges();
                }
            }




        }
            #endregion
            
            
            
            
            };


     
}
