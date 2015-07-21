using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentSystem.Models;
using StudentSytem.Data;

namespace StudentSystem.ConsoleClient
{
    class Program
    {
        static void Main(string[] args)
        {
            var db = new StudentSytemContext();

            //1.	Lists all students and their homework submissions. Select only their names and for each homework - content and content-type.

            //2.	List all courses with their corresponding resources. Select the course name and description and everything for each resource. Order the courses by start date (ascending), then by end date (descending).

            //3.	List all courses with more than 5 resources. Order them by resources count (descending), then by start date (descending). Select only the course name and the resource count.

            //4.	List all courses which were active on a given date (choose the date depending on the data seeded to ensure there are results), and for each course count the number of students enrolled. Select the course name, start and end date, course duration (difference between end and start date) and number of students enrolled. Order the results by the number of students enrolled (in descending order), then by duration (descending).

            //5.	For each student, calculate the number of courses she’s enrolled in, the total price of these courses and the average price per course for the student. Select the student name, number of courses, total price and average price. Order the results by total price (descending), then by number of courses (descending) and then by the student’s name (ascending).

            Console.WriteLine("Please select a task /1,2,3,4 or 5/ :");
            int task = int.Parse(Console.ReadLine());
            var date = Convert.ToDateTime("2014-01-01");
            switch (task)
            {
                case 1 : StudentsWithTheirHomework(db);
                    break;
                case 2:CoursesWithResources(db);
                    break;
                case 3:CoursesWithMoreTHan5Resourses(db);
                    break;
                case 4:ListsActiveCourses(db,date);
                    break;
                case 5:StudentsWithCoursesAndTheyrPrice(db);
                    break;
                default:
                    Console.WriteLine("Invalid task");
                    break;
            }

        }

        private static void StudentsWithCoursesAndTheyrPrice(StudentSytemContext db)
        {
            var students = db.Students
                .Select(s => new
                {
                    s.Name,
                    s.Courses.Count,
                    TotalPrice = s.Courses.Sum(c => c.Price),
                    AveragePrice = s.Courses.Average(c => c.Price),
                    Courses = s.Courses.Select(c => new {c.Name, c.Price})
                }).OrderByDescending(c => c.TotalPrice).ThenByDescending(c => c.Count).ThenBy(c => c.Name);
            foreach (var student in students)
            {
                Console.WriteLine(student.Name + ", " + "Number of courses:" + student.Count + " ,Total price : " +
                                  student.TotalPrice + " ,Avg price: " + student.AveragePrice);
                var courses = student.Courses;
                foreach (var course in courses)
                {
                    Console.WriteLine("         " + course.Name + " " + course.Price);
                }
            }
        }

        private static void ListsActiveCourses(StudentSytemContext db, DateTime date)
        {
            var courses = db.Courses
                .Where(c => c.StartDate > date)
                .Select(c => new
                {
                    CourseName = c.Name,
                    StartDate = c.StartDate,
                    EndDate = c.EndDate,
                    CourseDurotation = DbFunctions.DiffDays(c.StartDate, c.EndDate).Value,
                    StudentsCount = c.Students.Count
                }).OrderByDescending(c => c.StudentsCount).ThenByDescending(c => c.CourseDurotation);
            foreach (var course in courses)
            {
                Console.WriteLine(course.CourseName + " " + course.StartDate + " " + " " + course.EndDate + " " +
                                  course.CourseDurotation + " " + course.StudentsCount);
            }
        }

        private static void CoursesWithMoreTHan5Resourses(StudentSytemContext db)
        {
            var courses = db.Courses
                .Where(c => c.Resourses.Count >= 5)
                .OrderByDescending(c => c.Resourses.Count).ThenByDescending(c => c.StartDate)
                .Select(c => new
                {
                    c.Name,
                    c.Resourses.Count
                });
            foreach (var course in courses)
            {
                Console.WriteLine(course.Name + " " + course.Count);
            }
        }

        private static void CoursesWithResources(StudentSytemContext db)
        {
            var courses = db.Courses
                .OrderBy(c => c.StartDate).ThenByDescending(c => c.EndDate)
                .Select(c => new
                {
                    c.Name,
                    c.Description,
                    c.Resourses
                });
            foreach (var course in courses)
            {
                Console.WriteLine(course.Name + " " + course.Description);
                var resourses = course.Resourses;
                foreach (var resourse in resourses)
                {
                    Console.WriteLine("     Resourse: " + resourse.Name + " ---> Resourse type: " + resourse.ResourseType + " " +
                                      resourse.URL);
                }
            }
        }

        private static void StudentsWithTheirHomework(StudentSytemContext db)
        {
            var students = db.Students
                .Select(s => new
                {
                    s.Name,
                    Homework = s.Homeworks.Select(h => new {h.Content, h.ContentType})
                });
            foreach (var student in students)
            {
                Console.WriteLine(student.Name);
                var homeworks = student.Homework;
                foreach (var homework in homeworks)
                {
                    Console.WriteLine("     " + homework.Content + " " + homework.ContentType);
                }
            }
        }
    }
}
