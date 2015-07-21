﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace StudentSystem.Models
{
    public class Course
    {
        private ICollection<Student> students;
        private ICollection<Resourse> resourses;
        private ICollection<Homework> homeworks;

        public Course()
        {
            this.students= new HashSet<Student>();
            this.resourses = new HashSet<Resourse>();
            this.homeworks = new HashSet<Homework>();
        }


        [Key]
        public int Id { get; set; }


        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal Price { get; set; }


        public virtual ICollection<Student> Students
        {
            get { return this.students; }
            set { this.students = value; }
        }

        public virtual ICollection<Resourse> Resourses
        {
            get { return this.resourses; }
            set { this.resourses = value; }
        }

        public virtual ICollection<Homework> Homeworks
        {
            get { return this.homeworks; }
            set { this.homeworks = value; }
        }

    }
}