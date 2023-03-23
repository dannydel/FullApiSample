using Microsoft.Extensions.Logging;
using Sample.Api.Tests.Mocks;
using Sample.API.Controllers;
using Sample.API.Processors;
using Sample.WeatherForecast.Models.Enums;

namespace Sample.Api.Tests
{
	[TestClass]
	public class WeatherForecastTests
	{
		private readonly ILogger _logger;
		private readonly IWeatherForecastProcessor _forecastProcessor;
        public WeatherForecastTests()
        {
			_logger = new MockLogger<WeatherForecastController>();
			_forecastProcessor = new MockWeatherForecastProcessor();
        }

        [TestMethod]
		public void GetAllForecasts_ShouldReturnOk()
		{
			//-- Arrange
			IWeatherForecastProcessor processor = new MockWeatherForecastProcessor();
			var controller = new WeatherForecastController(_forecastProcessor, (ILogger<WeatherForecastController>)_logger);

			//-- Act
			var forecasts = controller.Get();

			//-- Assert
			Assert.IsNotNull(forecasts);
		}

		[TestMethod]
		public void ForecastFarenheit_ShouldReturnTrue()
		{
			//-- Arrange & Act
			WeatherForecast.Models.WeatherForecast forecast = new()
			{
				Date = DateOnly.FromDateTime(DateTime.Now),
				TemperatureC = -20,
			};

			int tempExpected = 32 + (int)(-20 / 0.5556);

			//-- Assert
			Assert.AreEqual(forecast.TemperatureF, tempExpected);
		}

		[TestMethod]
		public void ForecastSummarizeValidation_ShouldReturnFreezing()
		{
			//-- Arrange
			string summaryExpected = WeatherDescriptor.Freezing.ToString();

			//-- Act
			WeatherForecast.Models.WeatherForecast forecast = new()
			{
				Date = DateOnly.FromDateTime(DateTime.Now),
				TemperatureC = -20,
			};

			Assert.AreEqual(forecast.Summary, summaryExpected);
		}

		[TestMethod]
		public void ForecastSummaryReallyLowTemp_ShouldReturnFreezing()
		{
			//-- Arrange
			string summaryExpected = WeatherDescriptor.Freezing.ToString();

			//-- Act
			WeatherForecast.Models.WeatherForecast forecast = new()
			{
				Date = DateOnly.FromDateTime(DateTime.Now),
				TemperatureC = -500,
			};

			Assert.AreEqual(forecast.Summary, summaryExpected);
		}

		[TestMethod]
		public void ForecastSummarizeValidation_ShouldReturnBracing()
		{
			//-- Arrange
			string summaryExpected = WeatherDescriptor.Bracing.ToString();

			//-- Act
			WeatherForecast.Models.WeatherForecast forecast = new()
			{
				Date = DateOnly.FromDateTime(DateTime.Now),
				TemperatureC = -4,
			};

			Assert.AreEqual(forecast.Summary, summaryExpected);
		}

		[TestMethod]
		public void ForecastSummarizeValidation_ShouldReturnChilly()
		{
			//-- Arrange
			string summaryExpected = WeatherDescriptor.Chilly.ToString();

			//-- Act
			WeatherForecast.Models.WeatherForecast forecast = new()
			{
				Date = DateOnly.FromDateTime(DateTime.Now),
				TemperatureC = 5,
			};

			Assert.AreEqual(forecast.Summary, summaryExpected);
		}

		[TestMethod]
		public void ForecastSummarizeValidation_ShouldReturnCool()
		{
			//-- Arrange
			string summaryExpected = WeatherDescriptor.Cool.ToString();

			//-- Act
			WeatherForecast.Models.WeatherForecast forecast = new()
			{
				Date = DateOnly.FromDateTime(DateTime.Now),
				TemperatureC = 10,
			};

			Assert.AreEqual(forecast.Summary, summaryExpected);
		}

		[TestMethod]
		public void ForecastSummarizeValidation_ShouldReturnMild()
		{
			//-- Arrange
			string summaryExpected = WeatherDescriptor.Mild.ToString();

			//-- Act
			WeatherForecast.Models.WeatherForecast forecast = new()
			{
				Date = DateOnly.FromDateTime(DateTime.Now),
				TemperatureC = 15,
			};

			Assert.AreEqual(forecast.Summary, summaryExpected);
		}

		[TestMethod]
		public void ForecastSummarizeValidation_ShouldReturnWarm()
		{
			//-- Arrange
			string summaryExpected = WeatherDescriptor.Warm.ToString();

			//-- Act
			WeatherForecast.Models.WeatherForecast forecast = new()
			{
				Date = DateOnly.FromDateTime(DateTime.Now),
				TemperatureC = 20,
			};

			Assert.AreEqual(forecast.Summary, summaryExpected);
		}

		[TestMethod]
		public void ForecastSummarizeValidation_ShouldReturnBalmy()
		{
			//-- Arrange
			string summaryExpected = WeatherDescriptor.Balmy.ToString();

			//-- Act
			WeatherForecast.Models.WeatherForecast forecast = new()
			{
				Date = DateOnly.FromDateTime(DateTime.Now),
				TemperatureC = 25,
			};

			Assert.AreEqual(forecast.Summary, summaryExpected);
		}

		[TestMethod]
		public void ForecastSummarizeValidation_ShouldReturnHot()
		{
			//-- Arrange
			string summaryExpected = WeatherDescriptor.Hot.ToString();

			//-- Act
			WeatherForecast.Models.WeatherForecast forecast = new()
			{
				Date = DateOnly.FromDateTime(DateTime.Now),
				TemperatureC = 30,
			};

			Assert.AreEqual(forecast.Summary, summaryExpected);
		}

		[TestMethod]
		public void ForecastSummarizeValidation_ShouldReturnSweltering()
		{
			//-- Arrange
			string summaryExpected = WeatherDescriptor.Sweltering.ToString();

			//-- Act
			WeatherForecast.Models.WeatherForecast forecast = new()
			{
				Date = DateOnly.FromDateTime(DateTime.Now),
				TemperatureC = 35,
			};

			Assert.AreEqual(forecast.Summary, summaryExpected);
		}

		[TestMethod]
		public void ForecastSummarizeValidation_ShouldReturnScorching()
		{
			//-- Arrange
			string summaryExpected = WeatherDescriptor.Scorching.ToString();

			//-- Act
			WeatherForecast.Models.WeatherForecast forecast = new()
			{
				Date = DateOnly.FromDateTime(DateTime.Now),
				TemperatureC = 44,
			};

			Assert.AreEqual(forecast.Summary, summaryExpected);
		}

		[TestMethod]
		public void ForecastSummaryReallyHighTemp_ShouldReturnScorching()
		{
			//-- Arrange
			string summaryExpected = WeatherDescriptor.Scorching.ToString();

			//-- Act
			WeatherForecast.Models.WeatherForecast forecast = new()
			{
				Date = DateOnly.FromDateTime(DateTime.Now),
				TemperatureC = 500,
			};

			Assert.AreEqual(forecast.Summary, summaryExpected);
		}
	}
}