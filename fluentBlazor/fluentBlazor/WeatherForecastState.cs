using fluentBlazor.Models;

namespace fluentBlazor;

public class WeatherForecastState
{
    private WeatherForecast _state = new() { Name = "" };
    public WeatherForecast State
    {
        get => _state;
        set
        {
            _state = value;
            NotifyStateChanged();
        }
    }

    public event Action? OnChange;
    private void NotifyStateChanged() => OnChange?.Invoke();
}
