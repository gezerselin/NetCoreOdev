using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreOdev.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string CourseName { get; set; }
        public decimal Price { get; set; }
        public string Image { get; set; }
    }
}
