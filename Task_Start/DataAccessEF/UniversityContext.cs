using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Models.Models;

namespace DataAccessEF
{
    public class UniversityContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(
                @"Data Source=MAXVEL\SQLEXPRESS;Initial Catalog=AspDemoV3;Integrated Security=True");
            optionsBuilder.UseLazyLoadingProxies();
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<HomeTask> HomeTasks { get; set; }
    }
}
