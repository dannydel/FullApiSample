using Sample.WeatherForecast.Models.Enums;

namespace Sample.WeatherForecast.Models;

public class WeatherForecast
{
    public DateOnly Date { get; set; }

    public int TemperatureC { get; set; }

    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

    public string? Summary { get => SummarizeTemperature(); }

	public string SummarizeTemperature()
	{
		switch (TemperatureC)
		{
			case < -5:
				return WeatherDescriptor.Freezing.ToString();
			case < 0:
				return WeatherDescriptor.Bracing.ToString();
			case < 10:
				return WeatherDescriptor.Chilly.ToString();
			case < 15:
				return WeatherDescriptor.Cool.ToString();
			case < 20:
				return WeatherDescriptor.Mild.ToString();
			case < 25:
				return WeatherDescriptor.Warm.ToString();
			case < 30:
				return WeatherDescriptor.Balmy.ToString();
			case < 35:
				return WeatherDescriptor.Hot.ToString();
			case < 40:
				return WeatherDescriptor.Sweltering.ToString();
			case < 45:
				return WeatherDescriptor.Scorching.ToString();
			default:
				return WeatherDescriptor.Scorching.ToString();
		}
	}
}
