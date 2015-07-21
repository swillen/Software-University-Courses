using StudentSystem.Models;
using StudentSytem.Data.Migrations;

namespace StudentSytem.Data
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class StudentSytemContext : DbContext
    {
       
        public StudentSytemContext()
            : base("StudentSytemContext")
        {
            Database.SetInitializer
			(new MigrateDatabaseToLatestVersion<StudentSytemContext,Configuration>());
        }

        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<Resourse> Resourses { get; set; }
        public virtual DbSet<Homework> Homeworks { get; set; }
    }

}