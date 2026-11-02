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
    public class InstructorConfiguring : IEntityTypeConfiguration<Instructor>
    {
        public void Configure(EntityTypeBuilder<Instructor> builder)
        {
            builder.HasKey(i => i.Id);

            builder.Property(i => i.FullName)
                .IsRequired()
                .HasMaxLength(150);

            builder.Property(i => i.Email)
                .IsRequired()
                .HasMaxLength(256);

            builder.HasIndex(i => i.Email)
                .IsUnique();

            builder.Property(i => i.Bio)
                .HasMaxLength(500);

            builder.Property(i => i.JoinedDate)
                .IsRequired();



            builder.HasData(
            new Instructor
            {
            Id = 1,
            FullName = "Ahmed Mohamed",
            Email = "ahmed@example.com",
            Bio = "Backend Developer",
            JoinedDate = new DateTime(2024, 1, 10)},
            new Instructor
            {
            Id = 2,
            FullName = "Mohamed Ali",
            Email = "mohamed@example.com",
            Bio = "Frontend Developer",
            JoinedDate = new DateTime(2024, 3, 15)},
            new Instructor
            {
            Id = 3,
            FullName = "Sara Hassan",
            Email = "sara@example.com",
            Bio = "Software Engineer",
            JoinedDate = new DateTime(2024, 6, 20)});
        }
    }
}
