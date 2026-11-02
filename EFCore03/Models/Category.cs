using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore03.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public int? categoryprantId { get; set; }
        public Category? categoryprant { get; set; }
        public List <Course> Courses { get; set; }
        public List<Category> Subcategory { get; set; }


    }
}
