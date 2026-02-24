using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarTest.Entity
{
    public class Motorcycle
    {
        [Key, ForeignKey("Vehicle")]
        public int Vehicle_id { get; set; }

        [Required]
        public bool HasElectricStart { get; set; }

        public Vehicle Vehicle { get; set; }
    }
}
