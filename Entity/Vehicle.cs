using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarTest.Entity
{
    public class Vehicle
{
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Manufacturer { get; set; }

        [Required]
        [StringLength(50)]
        public string Model { get; set; }

        [Required]
        public int Year { get; set; }

        [Required]
        [StringLength(20)]
        public string Color { get; set; }

        [Required]
        public VehicleType VehicleType { get; set; }

        public Car Car { get; set; }
        public Motorcycle Motorcycle { get; set; }
        public Truck Truck { get; set; }

    }
}
