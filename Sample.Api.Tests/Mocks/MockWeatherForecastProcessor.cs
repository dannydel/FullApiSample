using Sample.API.Processors;

namespace Sample.Api.Tests.Mocks
{
	public class MockWeatherForecastProcessor : IWeatherForecastProcessor
	{
		public async Task<IEnumerable<WeatherForecast.Models.WeatherForecast>> GetForecasts()
		{
			return await Task.FromResult(new List<WeatherForecast.Models.WeatherForecast>());
		}
	}
}
