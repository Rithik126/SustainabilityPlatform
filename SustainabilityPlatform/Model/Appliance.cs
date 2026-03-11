namespace SustainabilityPlatform.Model
{
    public class Appliance
    {
        public int Id { get; set; }

        public int HomeId { get; set; }

        public int ApplianceId { get; set; }

        public string Model { get; set; }

        public string Name { get; set; }

        public string DeviceIdentifier { get; set; }

        public DateTime InstalledAt { get; set; }

        public string Status { get; set; }

    }
}
