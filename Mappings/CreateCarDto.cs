namespace CarTest.Mappings
{
    public record CreateCarDto
    {
        public string Manufacturer { get; init; }
        public string Model { get; init; }
        public int Year { get; init; }
        public string Color { get; init; }
        public int DoorsQuantity { get; init; }
    }
}

// JSON
//{
//    "manufacturer": null,
//      "model": null,
//      "year": 0,
//      "color": null,
//      "doorsQuantity": 0
//}
