using CarTest.Context;
using CarTest.Mappings;
using CarTest.Mappings.Responses;

namespace CarTest.Services.Impl
{
    public class TruckServicesImpl : ITruckServices
    {
        private readonly VehicleContext _context;
        public TruckServicesImpl(VehicleContext context) => _context = context;

        public TruckResponseDto GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TruckResponseDto> GetAll()
        {
            throw new NotImplementedException();
        }

        public TruckResponseDto Create(TruckDto createCarDto)
        {
            throw new NotImplementedException();
        }

        public TruckResponseDto Update(int id, TruckDto dto)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }






    }
}
