namespace Sample.API.Processors;

public interface IWeatherForecastProcessor
{
	public Task<IEnumerable<WeatherForecast.Models.WeatherForecast>> GetForecasts();
}
