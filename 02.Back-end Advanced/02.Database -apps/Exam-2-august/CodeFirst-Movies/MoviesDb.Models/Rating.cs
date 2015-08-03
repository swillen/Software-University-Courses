using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesDb.Models
{
    public class Rating
    {
        [Key]
        public int Id { get; set; }

        [Range(0,10)]
        public int Stars { get; set; }

        [Column("UserId")]
        public int UserId { get; set; }

        [Column("MovidId")]
        public int MovieId { get; set; }

        public virtual User User { get; set; }

        public virtual Movie Movie { get; set; }
    }
}
