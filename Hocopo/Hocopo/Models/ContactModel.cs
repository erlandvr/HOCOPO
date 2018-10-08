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
        [MaxLength(1000, ErrorMessage = "your discription is too long")]
        public string Description { get; set; }
        [Required]      
        public TimeSpan Duration { get; set; }
    }
}
