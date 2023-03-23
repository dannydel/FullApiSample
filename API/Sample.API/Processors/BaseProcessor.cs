using Sample.API.Services;

namespace Sample.API.Processors;

/// <summary>
/// Using a base processor for setting the logger at base level for ease of use.
/// </summary>
public class BaseProcessor
{
	protected readonly LoggingService Logger;
	public BaseProcessor(ILogger logger)
	{
		Logger = new LoggingService(logger);
	}
}
