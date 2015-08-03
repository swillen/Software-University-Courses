using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoviesDb.Models.Enums;

namespace MoviesDb.Models
{
    public class Movie
    {

        private ICollection<User> users;
        private ICollection<Rating> ratings;

        public Movie()
        {
            this.users = new HashSet<User>();
        }
        
        [Key]
        public int Id { get; set; }

        [Required]
        public string ISBN { get; set; }

        [Required]
        [MinLength(2)]
        [MaxLength(100)]
        public string Title { get; set; }

        public AgeRestriction AgeRestriction { get; set; }

        public virtual ICollection<User> Users { 
            get { return this.users; } 
            set { this.users = value; }
        }

        public virtual ICollection<Rating> Ratings
        {
            get { return this.ratings; }
            set { this.ratings = value; }
        }
    }
}
