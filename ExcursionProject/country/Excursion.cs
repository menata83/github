
namespace country
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    public class Excursion
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Country { get; set; }
        [Required]
        public string City { get; set; }
        public int TransportId { get; set; }
        public Transport Transport { get; set; }
        public ICollection<TransportExtra> TransportExtras { get; set; }



    }
}
