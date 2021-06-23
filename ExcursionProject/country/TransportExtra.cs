using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace country
{
    public class TransportExtra
    {
        [Required]
        public int TransportId { get; set; }
        [Required]
        public int ExtraId { get; set; }
        public Transport Transport { get; set; }
        public Extra Extra { get; set; }

    }
}
