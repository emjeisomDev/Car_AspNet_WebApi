namespace CarTest.Mappings
{
    public class TruckDto
    {
        public string Manufacturer { get; init; }
        public string Model { get; init; }
        public int Year { get; init; }
        public string Color { get; init; }
        public decimal LoadCapacity { get; init; }

        public TruckDto(string manufacturer, string model, int year, string color, decimal loadCapacity)
        {
            Manufacturer = manufacturer;
            Model = model;
            Year = year;
            Color = color;
            LoadCapacity = loadCapacity;
        }
    }
}
