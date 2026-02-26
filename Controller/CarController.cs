using CarTest.Mappings;
using CarTest.Services;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace CarTest.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarController : ControllerBase
    {

        private readonly ICarServices _carServices;
        public CarController(ICarServices carServices) => _carServices = carServices;

        [HttpGet("{id}")]
        public IActionResult GetById([FromRoute] int id) => Ok(_carServices.GetById(id));

        [HttpGet]
        public IActionResult GetAll() => Ok(_carServices.GetAll());

        [HttpPost]
        public IActionResult CreateCar([FromBody] CarDto dto)
        {
            var result = _carServices.Create(dto);
            return CreatedAtAction(nameof(GetById),
                new { id = result.Id },
                result);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateCar([FromRoute] int id, [FromBody] CarDto dto)
            => Ok(_carServices.Update(id, dto));

        [HttpDelete("{id}")]
        public IActionResult DeleteCar([FromRoute] int id)
        {
            _carServices.Delete(id);
            return NoContent();
        }






    }
}
