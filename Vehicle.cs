namespace ParkingSystem
{
    public class Vehicle(string registrationNumber, string color, string type)
    {
        public string RegistrationNumber { get; } = registrationNumber;
        public string Color { get; } = color;
        public string Type { get; } = type;
    }
}