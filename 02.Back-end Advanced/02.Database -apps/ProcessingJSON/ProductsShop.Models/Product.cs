using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ProductsShop.Models
{
    public class Product
    {

        private ICollection<Categorie> categories;

        public Product()
        {
            this.categories = new HashSet<Categorie>();
        }
            
        [Key]
        public int Id { get; set; }

        [MinLength(3)]
        public string Name { get; set; }

        public decimal Price { get; set; }
        
        [Column("SellerId")]
        public int SellerId { get; set; }
        [Column("BuyerId")]
        public int? BuyerId { get; set; }

        public virtual User Buyer { get; set; }
        public virtual User Seller { get; set; }

        public virtual ICollection<Categorie> Categories
        {
            get { return this.categories; }
            set { this.categories = value; }
        }

        
    }
}
