using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.Models
{
    public class Event
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Time { get; set; }
        public string Full_Address { get; set; }
        public string Venue { get; set; }
        public string About { get; set; }
        public string Speaker_Name { get; set; }
        public string Speaker_Profession { get; set; }
        public string Image { get; set; }
    }
}
