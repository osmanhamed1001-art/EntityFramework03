using EFCore03.Enum;
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
    public class CourseConfiguring : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {


            builder.HasKey(c => c.Id);

            builder.Property(c => c.Title)
                .IsRequired()
                .HasMaxLength(200);

            builder.Property(c => c.Description)
                .HasMaxLength(2000);

            builder.Property(c => c.Price)
                .HasPrecision(18, 2)
                .IsRequired();

            builder.Property(c => c.Level)
                .IsRequired();

            builder.Property(c => c.IsPublished)
                .IsRequired();

            builder.Property(c => c.PublishedDate);



            builder.HasOne(c => c.Instructors)
                   .WithMany(c => c.Courses)
                   .HasForeignKey(c => c.InstructorsId)
                   .IsRequired();


            builder.HasData(
    new Course
    {
        Id = 1,
        Title = "C# Fundamentals",
        Description = "Learn C# Basics",
        Price = 500,
        Level = CourseLevel.Beginner,
        IsPublished = true,
        PublishedDate = new DateTime(2025, 1, 10),
        InstructorsId = 1,
        CategorysId = 2

    },
    new Course
    {
        Id = 2,
        Title = "ASP.NET Core",
        Description = "Learn Web API Development",
        Price = 1200,
        Level = CourseLevel.Intermediate,
        IsPublished = true,
        PublishedDate = new DateTime(2025, 2, 10),
        InstructorsId = 1,
        CategorysId = 4

    },
    new Course
    {
        Id = 3,
        Title = "Entity Framework Core",
        Description = "Learn EF Core",
        Price = 900,
        Level = CourseLevel.Advanced,
        IsPublished = true,
        PublishedDate = new DateTime(2025, 3, 10),
        InstructorsId = 1,
        CategorysId = 4

    },
    new Course
    {
        Id = 4,
        Title = "Frontend Development",
        Description = "HTML CSS JavaScript",
        Price = 700,
        Level = CourseLevel.Beginner,
        IsPublished = true,
        PublishedDate = new DateTime(2025, 4, 10),
        InstructorsId = 1,
        CategorysId = 4

    },
    new Course
    {
        Id = 5,
        Title = "Advanced SQL Server",
        Description = "Advanced Database Concepts",
        Price = 1500,
        Level = CourseLevel.Advanced,
        IsPublished = true,
        PublishedDate = new DateTime(2025, 5, 10),
        InstructorsId = 1,
        CategorysId = 4

    },
    new Course
    {
        Id = 6,
        Title = "Docker Fundamentals",
        Description = "Introduction to Docker",
        Price = 800,
        Level = CourseLevel.Intermediate,
        IsPublished = false,
        PublishedDate = null,
        InstructorsId = 1,
        CategorysId = 4

    }
);


        }
    }
}
