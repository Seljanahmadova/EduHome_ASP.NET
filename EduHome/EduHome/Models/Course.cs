using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.Models
{
    public class Course
    {
        public int Id { get; set; }
        [Required]
        public string StartTime { get; set; }
        [Required]
        public string Duration { get; set; }
        [Required]
        public string ClassDuration { get; set; }
        [Required]
        public string SkillLevel { get; set; }
        [Required]
        public string Language { get; set; }
        [Required]
        public int StudentCount { get; set; }
        [Required]
        public string Assessment { get; set; }
        [Required]
        public decimal Fee { get; set; }
        public string Image { get; set; }
        public int CourseContentId { get; set; }
        public virtual CourseContent CourseContent { get; set; }
        public int CourseCategoryId { get; set; }
        public virtual CourseCategory CourseCategory { get; set; }
    }
}
