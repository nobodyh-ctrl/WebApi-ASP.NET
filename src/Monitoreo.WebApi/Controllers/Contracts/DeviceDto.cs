namespace Monitoreo.WebApi.Controllers.Contracts
{
    public class DeviceDto
    {
        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public string? Alias { get; set; }

        public string? Community { get; set; }

    }
}
