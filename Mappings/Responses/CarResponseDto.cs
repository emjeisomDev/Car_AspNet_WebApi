namespace CarTest.Mappings.Responses
{
    public record CarResponseDto
    {
        public int Id { get; init; }
        public string Manufacturer { get; init; }
        public string Model { get; init; }
        public int Year { get; init; }
        public string Color { get; init; }
        public string VehicleType { get; init; }
        public int DoorsQuantity { get; init; }

        public CarResponseDto(int id, string manufacturer, string model, int year, string color, string vehicleType, int doorsQuantity)
        {
            Id = id;
            Manufacturer = manufacturer;
            Model = model;
            Year = year;
            Color = color;
            VehicleType = vehicleType;
            DoorsQuantity = doorsQuantity;
        }
    }
}
