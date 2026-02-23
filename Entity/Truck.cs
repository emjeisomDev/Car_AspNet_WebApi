using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarTest.Entity
{
    public class Truck
    {
        public int Id { get; set; }
        public double LoadCapacity { get; set; }
        public Vehicle Vehicle { get; set; }
    }
}
