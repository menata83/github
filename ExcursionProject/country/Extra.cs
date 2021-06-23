using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace country
{
    public class Extra
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string TransportType { get; set; }
        public string Description { get; set; }
        public ICollection<TransportExtra> TransportExtras { get; set; }
    }
}
