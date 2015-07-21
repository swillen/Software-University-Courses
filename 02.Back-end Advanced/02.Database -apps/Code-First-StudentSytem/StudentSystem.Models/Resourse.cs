using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentSystem.Models.Enums;

namespace StudentSystem.Models
{
    public class Resourse
    {

        private ICollection<License> licenses;

        public Resourse()
        {
            this.licenses= new HashSet<License>();
        }
        
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        public ResourseType ResourseType { get; set; }

        public string URL { get; set; }

        public virtual Course Course { get; set; }

        public virtual ICollection<License> Licenses
        {
            get { return this.licenses; }
            set { this.licenses = value; }
        }


    }
}
