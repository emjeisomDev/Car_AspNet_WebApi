using CarTest.Mappings;
using CarTest.Mappings.Responses;

namespace CarTest.Services
{
    public interface ICarServices
    {
        public IEnumerable<CarResponseDto> GetAll();
        public CarResponseDto GetById(int id);
        public CarResponseDto Create(CarDto createCarDto);
        public CarResponseDto Update(int id, CarDto dto);

        public void Delete(int id);
        
    }
}
