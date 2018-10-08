using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hocopo.Models
{
    public class ContactModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [MinLength(50)]
        [MaxLength(1000)]
        public string Description { get; set; }
        [Required]     
        public int Duration { get; set; }
    }
}
