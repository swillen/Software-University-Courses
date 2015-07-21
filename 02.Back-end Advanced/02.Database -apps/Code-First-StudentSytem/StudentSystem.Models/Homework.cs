using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentSystem.Models.Enums;

namespace StudentSystem.Models
{
    public class Homework
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Content { get; set; }

        public Content ContentType { get; set; }
        public DateTime SubmissionDate { get; set; }

        public virtual Student Student{ get; set; }

        public virtual Course Course { get; set; }


    }
}
