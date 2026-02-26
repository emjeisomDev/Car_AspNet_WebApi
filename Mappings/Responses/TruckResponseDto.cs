namespace CarTest.Mappings.Responses
{
    public class TruckResponseDto
    {
        public int Id { get; init; }
        public string Manufacturer { get; init; }
        public string Model { get; init; }
        public int Year { get; init; }
        public string Color { get; init; }
        public decimal LoadCapacity { get; init; }

        public TruckResponseDto(int id, string manufacturer, string model, int year, string color, decimal loadCapacity)
        {
            Id = id;
            Manufacturer = manufacturer;
            Model = model;
            Year = year;
            Color = color;
            LoadCapacity = loadCapacity;
        }
    }
}
