using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarTest.Entity
{
    public class Truck
    {
        [Key, ForeignKey("Vehicle")]
        public int Vehicle_id { get; set; }

        [Required]
        [Column(TypeName = "decimal(10,2)")]
        public decimal LoadCapacity { get; set; }

        public Vehicle Vehicle { get; set; }
    }
}
