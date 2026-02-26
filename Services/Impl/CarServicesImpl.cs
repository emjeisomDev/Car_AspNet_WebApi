using CarTest.Context;
using CarTest.Entity;
using CarTest.Mappings;
using CarTest.Mappings.Responses;
using Microsoft.EntityFrameworkCore;
using System.Globalization;
using System.Runtime.ConstrainedExecution;

namespace CarTest.Services.Impl
{
    public class CarServicesImpl : ICarServices
    {
        private readonly VehicleContext _context;
        public CarServicesImpl(VehicleContext context) => _context = context;


        public TruckResponseDto GetById(int id)
        {
            var car = _context.Cars
                .AsNoTracking()
                .Include(c => c.Vehicle)
                .FirstOrDefault(c => c.Vehicle_id == id);

            if (car == null)
                throw new KeyNotFoundException("Car not found.");

            return new TruckResponseDto(
                car.Vehicle.Id,
                car.Vehicle.Manufacturer,
                car.Vehicle.Model,
                car.Vehicle.Year,
                car.Vehicle.Color,
                car.Vehicle.VehicleType.ToString(),
                car.DoorsQuantity
            );
        }


        public IEnumerable<TruckResponseDto> GetAll()
            => _context.Cars
                .AsNoTracking()
                .Select(c => new TruckResponseDto(
                    c.Vehicle.Id,
                    c.Vehicle.Manufacturer,
                    c.Vehicle.Model,
                    c.Vehicle.Year,
                    c.Vehicle.Color,
                    c.Vehicle.VehicleType.ToString(),
                    c.DoorsQuantity
                ))
                .ToList();

        public TruckResponseDto Create(CarDto dto)
        {
            if (dto.Year < 1900)
                throw new ArgumentException("Invalid year");

            Vehicle car = new Vehicle
            {
                Manufacturer = dto.Manufacturer,
                Model = dto.Model,
                Year = dto.Year,
                Color = dto.Color,
                VehicleType = VehicleType.CAR,
                Car = new Car { DoorsQuantity = dto.DoorsQuantity }
            };

            _context.Vehicles.Add(car);
            _context.SaveChanges();

            return new TruckResponseDto
                (
                    car.Id,
                    car.Manufacturer,
                    car.Model,
                    car.Year,
                    car.Color,
                    car.VehicleType.ToString(),
                    car.Car.DoorsQuantity
                 );
        }

        public TruckResponseDto Update(int id, CarDto dto)
        {

            if (dto.Year < 1900)
                throw new ArgumentException("Invalid year");

            var car = _context.Cars
                .Include(c => c.Vehicle)
                .FirstOrDefault(c => c.Vehicle_id == id);

            if (car == null)
                throw new KeyNotFoundException("Car not found.");

            car.Vehicle.Manufacturer = dto.Manufacturer;
            car.Vehicle.Model = dto.Model;
            car.Vehicle.Year = dto.Year;
            car.Vehicle.Color = dto.Color;
            car.DoorsQuantity = dto.DoorsQuantity;

            _context.SaveChanges();

            return new TruckResponseDto(
                car.Vehicle.Id,
                car.Vehicle.Manufacturer,
                car.Vehicle.Model,
                car.Vehicle.Year,
                car.Vehicle.Color,
                car.Vehicle.VehicleType.ToString(),
                car.DoorsQuantity
            );
        }

        public void Delete(int id)
        {
            var car = _context.Cars
                .Include(c => c.Vehicle)
                .FirstOrDefault(c => c.Vehicle_id == id);

            if (car == null)
                throw new KeyNotFoundException("Car not found.");

            _context.Vehicles.Remove(car.Vehicle);
            _context.SaveChanges();
        }

        

    }
}
