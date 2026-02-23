using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarTest.Entity
{
    public class Motorcycle
    {
        public int Id { get; set; }
        public bool HasEletricStart { get; set; }
        public Vehicle Vehicle { get; set; }
    }
}
