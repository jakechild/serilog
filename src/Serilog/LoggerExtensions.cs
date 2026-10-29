namespace Serilog;
/// <summary>
/// Extends <see cref="ILogger" /> with additional methods.
/// </summary>
public static class LoggerExtensions
{
    /// <summary>
    /// Create a logger that enriches log events when the specified level is enabled.
    /// </summary>
    /// <typeparam name="TValue"> The type of the property value. </typeparam>
    /// <param name="logger">The logger.</param>
    /// <param name="level">The log event level used to determine if log is enriched with property.</param>
    /// <param name="propertyName">The name of the property. Must be non-empty.</param>
    /// <param name="value">The property value.</param>
    /// <param name="destructureObjects">If <see langword="true"/>, the value will be serialized as a structured
    /// object if possible; if <see langword="false"/>, the object will be recorded as a scalar or simple array.</param>
    /// <returns>A logger that will enrich log events as specified.</returns>
    /// <exception cref="ArgumentNullException">When <paramref name="logger"/> is <code>null</code></exception>
    public static ILogger ForContext<TValue>(this ILogger logger, LogEventLevel level, string propertyName, TValue value, bool destructureObjects = false)
    {
        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "b56df66d-e7c1-46ea-a3c8-9188628beafb" + global::System.Environment.NewLine);
                }
                catch
                {
                }
                finally
                {
                    m.ReleaseMutex();
                }
            }
        })();
        Guard.AgainstNull(logger);
        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "e72e6182-7e92-4748-8e44-66289b9a0a51" + global::System.Environment.NewLine);
                }
                catch
                {
                }
                finally
                {
                    m.ReleaseMutex();
                }
            }
        })();
        return logger.IsEnabled(level) ? logger.ForContext(propertyName, value, destructureObjects) : logger;
    }
}