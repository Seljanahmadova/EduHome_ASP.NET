using EduHome.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace EduHome.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Teacher> Teacher{get; set;}
        public DbSet<Skill> Skill { get; set; }
        public DbSet<Course> Course { get; set; }
        public DbSet<CourseCategory> CourseCategory { get; set; }
        public DbSet<CourseContent> CourseContent { get; set; }
        public DbSet<Reply> Reply { get; set; }
        public DbSet<Event> Event { get; set; }
        public DbSet<Subscribe> Subscribe { get; set; }
        public DbSet<User> User { get; set; }
    }
}
