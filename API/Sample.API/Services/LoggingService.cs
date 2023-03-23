namespace Sample.API.Services;

public class LoggingService
{
	private readonly ILogger _logger;
    public LoggingService(ILogger logger)
    {
		_logger = logger;
    }

	public void LogError(string message, string? stackTrace = null) =>
		_logger.LogError("{Event} {StackTrace}", message, stackTrace);

	public void LogException(Exception exception) =>
		_logger.LogError("{Event} {StackTrace} {InnerException}", exception.Message, exception.StackTrace, exception.InnerException);

	public void LogInformation(string message, string? userEmail = null) =>
		_logger.LogInformation("{Event} {UserEmail}", message, userEmail);

	public void LogWarning(string message) =>
		_logger.LogWarning("{Event} {LoanId}", message);
}
