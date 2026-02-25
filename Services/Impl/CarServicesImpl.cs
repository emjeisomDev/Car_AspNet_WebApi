using CarTest.Context;
using CarTest.Entity;
using CarTest.Mappings;
using CarTest.Mappings.Responses;
using System.Globalization;

namespace CarTest.Services.Impl
{
    public class CarServicesImpl : ICarServices
    {
        private readonly VehicleContext _context;
        public CarServicesImpl(VehicleContext context) => _context = context;
        

        public CarResponseDto Create(CreateCarDto dto)
        {
            Vehicle car = new Vehicle
            {
                Manufacturer = dto.Manufacturer,
                Model = dto.Model,
                Year = dto.Year,
                Color = dto.Color,
                VehicleType = VehicleType.CAR,
                Car = new Car { DoorsQuantity = dto.DoorsQuantity }
            };

            if (dto.Year < 1900)
                throw new ArgumentException("Invalid year");

            _context.Vehicles.Add(car);
            _context.SaveChanges();

            return new CarResponseDto
                (
                    car.Id,
                    car.Manufacturer,
                    car.Model,
                    car.Year,
                    car.Color,
                    confToTitleCase(car.VehicleType),
                    car.Car.DoorsQuantity
                 );
        }


        private string confToTitleCase(VehicleType vehicleType)
            => CultureInfo.CurrentCulture.TextInfo.ToTitleCase(vehicleType.ToString());

        

    }
}
