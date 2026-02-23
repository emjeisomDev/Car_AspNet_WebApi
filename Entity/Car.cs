using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarTest.Entity
{
    public class Car
    {
        public int Id { get; set; }
        public int DoorsQuantity { get; set; }
        public Vehicle Vehicle { get; set; }
    }
}
