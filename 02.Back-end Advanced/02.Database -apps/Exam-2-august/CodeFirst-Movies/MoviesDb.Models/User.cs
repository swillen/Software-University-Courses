﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesDb.Models
{
    public class User
    {
        private ICollection<Movie> movies;
        private ICollection<Rating> ratings; 

        public User()
        {
            this.movies = new HashSet<Movie>();
            this.ratings = new HashSet<Rating>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [MinLength(5)]
        public string UserName { get; set; }
        public string Email { get; set; }
        public int? Age { get; set; }


        [Column("CountryId")]
        public int CountryId;
        public virtual Country Country { get; set; }


        public virtual ICollection<Movie> Movies
        {
            get { return this.movies; }
            set { this.movies = value; }
        }

        public virtual ICollection<Rating> Ratings
        {
            get { return this.ratings; }
            set { this.ratings = value; }
        }
       
    }
}
