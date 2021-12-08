namespace BooleanLesson;

public class Weather
{
    public int TemperatureInCelcius;
    public int WindSpeedInKmh;
    public bool IsRaining;

    public Weather(int temperatureInCelcius, int windSpeedInKmh, bool isRaining)
    {
        TemperatureInCelcius = temperatureInCelcius;
        WindSpeedInKmh = windSpeedInKmh;
        IsRaining = isRaining;
    }
}