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
    }
}
