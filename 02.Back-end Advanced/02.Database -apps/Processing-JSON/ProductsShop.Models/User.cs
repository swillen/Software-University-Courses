﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductsShop.Models
{
    public class User
    {
        private ICollection<Product> productsSold;
        private ICollection<Product> productsBought;
        private ICollection<User> friends;

        public User()
        {
            this.productsSold = new HashSet<Product>();
            this.productsBought = new HashSet<Product>();
            this.friends= new HashSet<User>();
        }
        [Key]
        public int Id { get; set; }
            
        public string FirstName { get; set; }

        [Required]
        [MinLength(3)]
        public string LastName { get; set; }
        public int? Age { get; set; }

        [InverseProperty("Seller")]
        public virtual ICollection<Product> ProductsSold
        {
            get { return this.productsSold; }
            set { this.productsSold = value; }
        }
        [InverseProperty("Buyer")]
        public virtual ICollection<Product> ProductsBought
        {
            get { return this.productsBought; }
            set { this.productsBought = value; }
        }

        public ICollection<User> Friends
        {
            get { return this.friends; }
            set { this.friends = value; }
        }

        public override string ToString()
        {
            return this.FirstName == null
                ? " "
                : this.FirstName + " " + this.LastName == null ? "null" : this.LastName + " ";
        }
    }
}
