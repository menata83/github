using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace country
{
    using System.ComponentModel.DataAnnotations;
    public class Transport
    {
        [Key]
        public int Id { get; set;  }
        public string TransportType { get; set; }
        public string Description { get; set; }
        public ICollection<Excursion> Excursions { get; set; }


    }
}
