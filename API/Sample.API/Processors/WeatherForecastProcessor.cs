namespace Sample.API.Processors;

public class WeatherForecastProcessor : BaseProcessor, IWeatherForecastProcessor
{
	private HttpClient _httpClient;

    public WeatherForecastProcessor(ILogger<WeatherForecastProcessor> logger) : base(logger)
	{
		//-- Unecessary in this processor but will be required in others that we actually
		//-- make outside calls.
		_httpClient = new HttpClient();
	}

	/// <summary>
	/// Get weather forecasts.
	/// 
	/// Note: This would be correctly awaited if it were an actual httpclient call.
	/// </summary>
	/// <returns></returns>
	public async Task<IEnumerable<WeatherForecast.Models.WeatherForecast>> GetForecasts()
	{
		return await Task.FromResult(Enumerable.Range(1, 5).Select(index => new WeatherForecast.Models.WeatherForecast
		{
			Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
			TemperatureC = Random.Shared.Next(-20, 55)
		})
		.ToArray());
	}

	
}
