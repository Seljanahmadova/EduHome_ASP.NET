using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.Models
{
    public class CourseContent
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string NameAbout { get; set; }
        [Required]
        public string About { get; set; }
        [Required]
        public string HowToApply { get; set; }
        [Required]
        public string Certification { get; set; }
    }
}
