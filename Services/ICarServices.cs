using CarTest.Mappings;
using CarTest.Mappings.Responses;

namespace CarTest.Services
{
    public interface ICarServices
    {
        public CarResponseDto Create(CreateCarDto createCarDto);

    }
}
