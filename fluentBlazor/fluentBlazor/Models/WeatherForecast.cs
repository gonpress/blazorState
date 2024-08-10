using System.ComponentModel.DataAnnotations;

namespace fluentBlazor.Models;

public class WeatherForecast
{
    public int Id { get; set; }
    public required string Name { get; set; } = string.Empty;
    public string? Description { get; set; }
    public DateTime Date { get; set; }
    public int TemperatureC { get; set; }
    [Required]
    public string? Summary { get; set; }
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
}
