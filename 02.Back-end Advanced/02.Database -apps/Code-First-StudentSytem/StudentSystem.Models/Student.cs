﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSystem.Models
{
    public class Student
    {

        private ICollection<Course> courses;
        private ICollection<Homework> homeworks; 

        public Student()
        {
            this.courses = new HashSet<Course>();
            this.homeworks = new HashSet<Homework>();
        }
            
        [Key]
        public int Id { get; set; }


        [Required]
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime RegistracionDate { get; set; }
        public DateTime? Birthday { get; set; }

        public virtual ICollection<Course> Courses
        {
            get { return this.courses; }
            set { this.courses = value; }
        }

        public virtual ICollection<Homework> Homeworks
        {
            get { return this.homeworks; } 
            set { this.homeworks = value; }
        }
        
    }
}
