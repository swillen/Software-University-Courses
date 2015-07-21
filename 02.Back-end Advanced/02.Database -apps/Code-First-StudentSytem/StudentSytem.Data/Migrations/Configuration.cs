using System.Collections.Generic;
using System.Text.RegularExpressions;
using StudentSystem.Models;
using StudentSystem.Models.Enums;

namespace StudentSytem.Data.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<StudentSytem.Data.StudentSytemContext>
    {
        public Configuration()
        {
            //AutomaticMigrationDataLossAllowed = true;
            AutomaticMigrationsEnabled = true;
            ContextKey = "StudentSytem.Data.StudentSytemContext";
        }

        protected override void Seed(StudentSytem.Data.StudentSytemContext context)
        {
            context.Students.AddOrUpdate(s => s.Name,
                new Student()
                {
                    Name = "Aleks",
                    RegistracionDate = Convert.ToDateTime("2013-03-02").Date
                });
            context.Students.AddOrUpdate(s => s.Name,
                new Student()
                {
                    Name = "Hyorin",
                    RegistracionDate = Convert.ToDateTime("2012-05-10").Date
                });
            
            context.Students.AddOrUpdate(s => s.Name,
                new Student()
                {
                    Name = "Peshko",
                    RegistracionDate = Convert.ToDateTime("2014-10-10").Date
                });
            context.Students.AddOrUpdate(s => s.Name,
                new Student()
                {
                    Name = "Max",
                    RegistracionDate = Convert.ToDateTime("2015-01-01").Date
                });
            context.Students.AddOrUpdate(s => s.Name,
                new Student()
                {
                    Name = "Lucy",
                    RegistracionDate = Convert.ToDateTime("2015-07-21").Date,
                });
            context.SaveChanges();
            context.Courses.AddOrUpdate(c => c.Name,
                new Course()
                {
                    Students = new List<Student>() { context.Students.ToList()[3], context.Students.ToList()[4]},
                    Name = "Mathematic",
                    StartDate = Convert.ToDateTime("2014-01-01"),
                    EndDate = Convert.ToDateTime("2014-02-01"),
                    Price = 300
                });
            context.Courses.AddOrUpdate(c => c.Name,
               new Course()
               {
                   Students = new List<Student>() { context.Students.ToList()[1], context.Students.ToList()[2], context.Students.ToList()[0] },
                   Name = "Computer Science",
                   StartDate = Convert.ToDateTime("2014-02-01"),
                   EndDate = Convert.ToDateTime("2014-05-01"),
                   Price = 500,
               });
            context.SaveChanges();
            context.Resourses.AddOrUpdate(r => r.Name,
               new Resourse()
               {
                   Name = "Learn programming",
                   ResourseType = ResourseType.other,
                   Course = context.Courses.ToList()[1]
               });
            
            context.Resourses.AddOrUpdate(r => r.Name,
               new Resourse()
               {
                   Name = "Learn to math",
                   ResourseType = ResourseType.document,
                   Course = context.Courses.ToList()[0]
               });
            context.Resourses.AddOrUpdate(r => r.Name,
               new Resourse()
               {
                   Name = "Learn Regullar expressions",
                   ResourseType = ResourseType.presentation,
                   Course = context.Courses.ToList()[1]
               });
            context.SaveChanges();
            context.Homeworks.AddOrUpdate(h => h.Content,
               new Homework()
               {
                   Content = "EF code-firs",
                   ContentType = Content.pdf,
                   SubmissionDate = Convert.ToDateTime("2015-07-05"),
                   Course = context.Courses.ToList()[1],
                   Student = context.Students.ToList()[0]
               });
            context.Homeworks.AddOrUpdate(h => h.Content,
               new Homework()
               {
                   Content = "EF Performance",
                   ContentType = Content.zip,
                   SubmissionDate = Convert.ToDateTime("2015-07-10"),
                   Course = context.Courses.ToList()[1],
                   Student = context.Students.ToList()[1]
               });
            context.Homeworks.AddOrUpdate(h => h.Content,
               new Homework()
               {
                   Content = "EF Transactions",
                   ContentType = Content.pdf,
                   SubmissionDate = Convert.ToDateTime("2015-07-15"),
                   Student = context.Students.ToList()[2],
                   Course = context.Courses.ToList()[1]
               });
            context.Homeworks.AddOrUpdate(h => h.Content,
               new Homework()
               {
                   Content = "Math for begginers",
                   ContentType = Content.zip,
                   SubmissionDate = Convert.ToDateTime("2015-07-20"),
                   Student = context.Students.ToList()[3],
                   Course = context.Courses.ToList()[0]
               });
            context.Homeworks.AddOrUpdate(h => h.Content,
               new Homework()
               {
                   Content = "Calculate N factorial",
                   ContentType = Content.zip,
                   SubmissionDate = Convert.ToDateTime("2015-07-25"),
                   Course = context.Courses.ToList()[0],
                   Student = context.Students.ToList()[4]
               });
          

            context.SaveChanges();

            context.Resourses.AddOrUpdate(r => r.Name,
               new Resourse()
               {
                   Name = "Programming for dummies-book",
                   ResourseType = ResourseType.document,
                   Course = context.Courses.ToList()[1]
               });
            context.Resourses.AddOrUpdate(r => r.Name,
               new Resourse()
               {
                   Name = "Algorithms and fackts",
                   ResourseType = ResourseType.document,
                   Course = context.Courses.ToList()[0]
               });
            context.Resourses.AddOrUpdate(r => r.Name,
               new Resourse()
               {
                   Name = "Java in the beginning",
                   ResourseType = ResourseType.other,
                   Course = context.Courses.ToList()[1]
               });
            context.Resourses.AddOrUpdate(r => r.Name,
               new Resourse()
               {
                   Name = "How not  to love JavaScript",
                   ResourseType = ResourseType.document,
                   Course = context.Courses.ToList()[1]
               });
            context.Courses.AddOrUpdate(c => c.Name,
               new Course()
               {
                   Students = new List<Student>() { context.Students.ToList()[2], context.Students.ToList()[1], context.Students.ToList()[0] },
                   Name = "History",
                   StartDate = Convert.ToDateTime("2015-02-01"),
                   EndDate = Convert.ToDateTime("2015-05-11"),
                   Price = 100,
               });
            context.Courses.AddOrUpdate(c => c.Name,
              new Course()
              {
                  Students = new List<Student>() { context.Students.ToList()[2], context.Students.ToList()[1], context.Students.ToList()[0] },
                  Name = "Art",
                  StartDate = Convert.ToDateTime("2011-02-11"),
                  EndDate = Convert.ToDateTime("2011-03-01"),
                  Price = 300,
              });
            context.Courses.AddOrUpdate(c => c.Name,
              new Course()
              {
                  Students = new List<Student>() { context.Students.ToList()[4], context.Students.ToList()[3], context.Students.ToList()[0] },
                  Name = "Graphic Design",
                  StartDate = Convert.ToDateTime("2012-07-11"),
                  EndDate = Convert.ToDateTime("2012-08-01"),
                  Price = 300,
              });
            context.Homeworks.AddOrUpdate(h => h.Content,
               new Homework()
               {
                   Content = "Use photoshop",
                   ContentType = Content.zip,
                   SubmissionDate = Convert.ToDateTime("2015-07-20"),
                   Student = context.Students.ToList()[3],
                   Course = context.Courses.ToList()[4]
               });
            context.Homeworks.AddOrUpdate(h => h.Content,
               new Homework()
               {
                   Content = "Draw a portrait",
                   ContentType = Content.zip,
                   SubmissionDate = Convert.ToDateTime("2015-06-20"),
                   Student = context.Students.ToList()[2],
                   Course = context.Courses.ToList()[3]
               });
            context.Homeworks.AddOrUpdate(h => h.Content,
               new Homework()
               {
                   Content = "Write some historical events",
                   ContentType = Content.zip,
                   SubmissionDate = Convert.ToDateTime("2015-07-21"),
                   Student = context.Students.ToList()[4],
                   Course = context.Courses.ToList()[2]
               });
            context.SaveChanges();

        }
    }
}
