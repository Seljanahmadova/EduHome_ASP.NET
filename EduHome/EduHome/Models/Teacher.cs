using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.Models
{
    public class Teacher
    {
        public int Id { get; set; }
        [Required, StringLength(100)]
        public string Fullname { get; set; }
        [Required, StringLength(255)]
        public string Profession { get; set; }
        [Required,MaxLength(500)]
        public string About { get; set; }
        [Required]
        public string Degree { get; set; }
        [Required]
        public string Experience { get; set; }
        [Required]
        public string  Email { get; set; }
        public string Skype { get; set; }
        [Required]
        public string Hobbies { get; set; }
        [Required]
        public string Faculty { get; set; }
        [Required]
        public string PhoneNumber { get; set; }
        [Required]
        public string Image { get; set; }
        public string Facebook { get; set; }
        public string Pinterest { get; set; }
        public string Vimeo { get; set; }
        public string Twitter { get; set; }
        public int SkillId { get; set; }
        public virtual Skill Skill { get; set; }

    }
}
