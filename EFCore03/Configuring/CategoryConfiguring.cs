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
    public class CategoryConfiguring : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {


            builder.HasKey(ca => ca.Id);

            builder.Property(ca => ca.Name)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(ca => ca.Description)
                .HasMaxLength(500);




            builder.HasMany(ca=>ca.Courses)
                   .WithOne(ca=>ca.Categorys)
                   .HasForeignKey(ca=>ca.CategorysId)
                   .IsRequired();

            builder.HasOne(cc=>cc.categoryprant)
                   .WithMany(cc=>cc.Subcategory)
                   .HasForeignKey(cc=>cc.categoryprantId)
                   .IsRequired().OnDelete(DeleteBehavior.NoAction); 

            builder.HasData(new Category { Id=1, 
                Name= "Programming",
                Description = "Programming Courses",
                categoryprantId = 1 },
                new Category { 
                    Id = 2, Name = "Backend",
                    Description = "Backend Development",
                    categoryprantId = 2 }, 
                new Category { 
                    Id = 3, 
                    Name = "Frontend",
                    Description = "Frontend Development",
                    categoryprantId = 3 }, 
                new Category {
                    Id = 4, Name = "ASP.NET", 
                    Description = "ASP.NET Core", 
                    categoryprantId = 4 }, 
                new Category {
                    Id = 5, Name = "EF Core", 
                    Description = "Entity Framework Core", 
                    categoryprantId = 5}
                );


        }
    }
}
