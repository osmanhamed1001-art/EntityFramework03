using EFCore03.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore03.Configuring
{
    public class EnrollmentConfiguring : IEntityTypeConfiguration<Enrollment>
    {
        public void Configure(EntityTypeBuilder<Enrollment> builder)
        {
            builder.HasOne(e=>e.Courses)
                   .WithMany(e=>e.Enrollments)
                   .HasForeignKey(e=> e.CoursesId)
                   .IsRequired();
            builder.HasOne(s=>s.Students)
                   .WithMany(s=>s.Enrollments)
                   .HasForeignKey(s=>s.StudentsId)
                   .IsRequired();
            builder.HasIndex(e=>new { e.CoursesId, e.StudentsId})
                   .IsUnique();


            builder.Property(e => e.FinalGrade)
                   .HasPrecision(5, 2);

            builder.Property(e => e.ProgressPercentage)
                   .HasPrecision(5, 2);
        }
    }
}
