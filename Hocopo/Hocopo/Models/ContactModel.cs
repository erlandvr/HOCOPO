using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hocopo.Models
{
    public class ContactModel
    {
        public string Email { get; set; }
        public string Description { get; set; }
        public TimeSpan Duration { get; set; }
    }
}
