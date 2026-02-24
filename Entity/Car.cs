using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarTest.Entity
{
    public class Car
    {
        [Key, ForeignKey("Vehicle")]
        public int Vehicle_id { get; set; }

        [Required]
        public int DoorsQuantity { get; set; }

        public Vehicle Vehicle { get; set; }
    }
}
