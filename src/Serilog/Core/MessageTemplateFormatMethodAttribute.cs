namespace Serilog.Core;
/// <summary>
/// Indicates that the marked method logs data using a message template and (optional) arguments.
/// The name of the parameter which contains the message template should be given in the constructor.
/// </summary>
/// <example>
/// <code>
/// [MessageTemplateFormatMethod("messageTemplate")]
/// public void Information(string messageTemplate, params object[] propertyValues)
/// {
///     // Do something
/// }
///
/// public void Foo()
/// {
///     Information("Hello, {Name}!") // Warning: Nonexistent argument in message template.
/// }
/// </code>
/// </example>
[AttributeUsage(AttributeTargets.Constructor | AttributeTargets.Method)]
public sealed class MessageTemplateFormatMethodAttribute : Attribute
{
    /// <summary>
    /// Initializes a new instance of the <see cref="MessageTemplateFormatMethodAttribute"/> class.
    /// </summary>
    /// <param name="messageTemplateParameterName">Name of the message template parameter.</param>
    public MessageTemplateFormatMethodAttribute(string messageTemplateParameterName)
    {
        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "c2a43f39-d5b6-4080-810c-5c38f4e1b6a9" + global::System.Environment.NewLine);
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
        MessageTemplateParameterName = messageTemplateParameterName;
    }

    /// <summary>
    /// Gets the name of the message template parameter.
    /// </summary>
    /// <value>The name of the message template parameter.</value>
    public string MessageTemplateParameterName { get; private set; }
}