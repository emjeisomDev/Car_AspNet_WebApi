using CarTest.Mappings;
using CarTest.Mappings.Responses;

namespace CarTest.Services
{
    public interface ITruckServices
    {
        public IEnumerable<TruckResponseDto> GetAll();
        public TruckResponseDto GetById(int id);
        public TruckResponseDto Create(TruckDto createCarDto);
        public TruckResponseDto Update(int id, TruckDto dto);
        public void Delete(int id);
    }
}
