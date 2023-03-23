using Microsoft.AspNetCore.Mvc;
using Sample.API.Processors;
using Sample.WeatherForecast.Models.Enums;

namespace Sample.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class WeatherForecastController : ControllerBase
{
	private readonly ILogger<WeatherForecastController> _logger;
	private readonly IWeatherForecastProcessor _forecastProcessor;

	public WeatherForecastController(IWeatherForecastProcessor processor, ILogger<WeatherForecastController> logger)
	{
		_logger = logger;
		_forecastProcessor = processor;
		
	}

	[HttpGet("get")]
	public async Task<ActionResult<IEnumerable<WeatherForecast.Models.WeatherForecast>>> Get() 
		=> Ok(await _forecastProcessor.GetForecasts());
}