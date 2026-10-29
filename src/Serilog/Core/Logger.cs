// Copyright 2013-2016 Serilog Contributors
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
using System.Diagnostics;

#pragma warning disable Serilog004 // Constant MessageTemplate verifier

namespace Serilog.Core;
/// <summary>
/// The core Serilog logging pipeline. A <see cref="Logger"/> must
/// be disposed to flush any events buffered within it. Most application
/// code should depend on <see cref="ILogger"/>, not this class.
/// </summary>
public sealed class Logger : ILogger, ILogEventSink, IDisposable
#if FEATURE_ASYNCDISPOSABLE
    , IAsyncDisposable
#endif
{
    static readonly object[] NoPropertyValues = Array.Empty<object>();
    static readonly LogEventProperty[] NoProperties = Array.Empty<LogEventProperty>();
    readonly MessageTemplateProcessor _messageTemplateProcessor;
    readonly ILogEventSink _sink;
    readonly Action? _dispose;
#if FEATURE_ASYNCDISPOSABLE
    readonly Func<ValueTask>? _disposeAsync;
#endif
    readonly ILogEventEnricher _enricher;
    // It's important that checking minimum level is a very
    // quick (CPU-cacheable) read in the simple case, hence
    // we keep a separate field from the switch, which may
    // not be specified. If it is, we'll set _minimumLevel
    // to its lower limit and fall through to the secondary check.
    readonly LogEventLevel _minimumLevel;
    readonly LoggingLevelSwitch? _levelSwitch;
    readonly LevelOverrideMap? _overrideMap;
    internal Logger(MessageTemplateProcessor messageTemplateProcessor, LogEventLevel minimumLevel, LoggingLevelSwitch? levelSwitch, ILogEventSink sink, ILogEventEnricher enricher, Action? dispose, 
#if FEATURE_ASYNCDISPOSABLE
        Func<ValueTask>? disposeAsync,
#endif
    LevelOverrideMap? overrideMap)
    {
        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "89ecfee2-ee18-48cb-a2da-4b6251c116e0" + global::System.Environment.NewLine);
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
        _messageTemplateProcessor = messageTemplateProcessor;
        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "320b8a1c-4ab0-4307-9ebd-5ca316b9e374" + global::System.Environment.NewLine);
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
        _minimumLevel = minimumLevel;
        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "8f5bf358-3a9b-407f-b742-cce1acc9273f" + global::System.Environment.NewLine);
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
        _sink = sink;
        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "376b1f05-0f81-4935-95d8-e810fcae32cc" + global::System.Environment.NewLine);
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
        _dispose = dispose;
        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "2dfce06b-20f0-465c-a6b2-4e78fe921470" + global::System.Environment.NewLine);
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
#if FEATURE_ASYNCDISPOSABLE
        _disposeAsync = disposeAsync;
#endif
        _levelSwitch = levelSwitch;
        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "d10ec127-6c4b-45f5-b865-fc8e663d666d" + global::System.Environment.NewLine);
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
        _overrideMap = overrideMap;
        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "f588734b-9bb0-40d4-9ada-2d5041e02659" + global::System.Environment.NewLine);
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
        _enricher = enricher;
    }

    internal bool HasOverrideMap => _overrideMap != null;

    /// <summary>
    /// Create a logger that enriches log events via the provided enrichers.
    /// </summary>
    /// <param name="enricher">Enricher that applies in the context.</param>
    /// <returns>A logger that will enrich log events as specified.</returns>
    public ILogger ForContext(ILogEventEnricher enricher)
    {
        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "b69793da-84df-4ced-b9f1-747009e26161" + global::System.Environment.NewLine);
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
        if (enricher == null !)
        {
            new System.Action(() =>
            {
                using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                if (m.WaitOne(3000))
                {
                    try
                    {
                        global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "f2ad05b9-616a-416d-9021-86c05b8cd4df" + global::System.Environment.NewLine);
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
            return this; // No context here, so little point writing to SelfLog.
        }

        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "05528944-13f9-48b4-ba9d-32dba21568db" + global::System.Environment.NewLine);
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
        return new Logger(_messageTemplateProcessor, _minimumLevel, _levelSwitch, this, enricher, null, 
#if FEATURE_ASYNCDISPOSABLE
            null,
#endif
        _overrideMap);
    }

    /// <summary>
    /// Create a logger that enriches log events via the provided enrichers.
    /// </summary>
    /// <param name="enrichers">Enrichers that apply in the context.</param>
    /// <returns>A logger that will enrich log events as specified.</returns>
    public ILogger ForContext(IEnumerable<ILogEventEnricher> enrichers)
    {
        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "0fe1064a-f3dc-4eac-bb5c-5fb1d258e66f" + global::System.Environment.NewLine);
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
        if (enrichers == null !)
        {
            new System.Action(() =>
            {
                using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                if (m.WaitOne(3000))
                {
                    try
                    {
                        global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "49a0cbd2-adf1-4799-8e1a-bd3795dbce27" + global::System.Environment.NewLine);
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
            return this; // No context here, so little point writing to SelfLog.
        }

        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "9ad37313-058b-4e68-952c-29ef7aae0c70" + global::System.Environment.NewLine);
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
        return ForContext(new SafeAggregateEnricher(enrichers));
    }

    /// <summary>
    /// Create a logger that enriches log events with the specified property.
    /// </summary>
    /// <param name="propertyName">The name of the property. Must be non-empty.</param>
    /// <param name="value">The property value.</param>
    /// <param name="destructureObjects">If <see langword="true"/>, the value will be serialized as a structured
    /// object if possible; if <see langword="false"/>, the object will be recorded as a scalar or simple array.</param>
    /// <returns>A logger that will enrich log events as specified.</returns>
    public ILogger ForContext(string propertyName, object? value, bool destructureObjects = false)
    {
        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "c8d07574-617c-4ae4-950d-cadb2c4466fe" + global::System.Environment.NewLine);
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
        if (!LogEventProperty.IsValidName(propertyName))
        {
            new System.Action(() =>
            {
                using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                if (m.WaitOne(3000))
                {
                    try
                    {
                        global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "62b64be5-8b3b-44f6-b39e-1c66d1da19a7" + global::System.Environment.NewLine);
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
            SelfLog.WriteLine("Attempt to call ForContext() with invalid property name `{0}` (value: `{1}`)", propertyName, value);
            new System.Action(() =>
            {
                using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                if (m.WaitOne(3000))
                {
                    try
                    {
                        global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "cfef3d3f-7eff-427b-8dc7-c8cbaeb94fff" + global::System.Environment.NewLine);
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
            return this;
        }

        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "73ad9748-69fa-4159-89bc-58876b50bf09" + global::System.Environment.NewLine);
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
        // It'd be nice to do the destructuring lazily, but unfortunately `value` may be mutated between
        // now and the first log event written.
        var propertyValue = _messageTemplateProcessor.CreatePropertyValue(value, destructureObjects);
        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "53cf08af-6a39-4f51-8809-f722e5f287d5" + global::System.Environment.NewLine);
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
        var enricher = new FixedPropertyEnricher(new(propertyName, propertyValue));
        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "cf72ee48-d78f-433e-9612-926e69b5e386" + global::System.Environment.NewLine);
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
        LogEventLevel minimumLevel;
        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "edf5cd4a-d188-498e-973a-6c0c458a9454" + global::System.Environment.NewLine);
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
        LoggingLevelSwitch? levelSwitch;
        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "0656cd57-fa5b-482b-9499-a9a4e29ceb7b" + global::System.Environment.NewLine);
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
        if (_overrideMap != null && propertyName == Constants.SourceContextPropertyName && value is string context)
        {
            new System.Action(() =>
            {
                using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                if (m.WaitOne(3000))
                {
                    try
                    {
                        global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "dd84bb99-dbc8-4df6-adb3-e4185f842656" + global::System.Environment.NewLine);
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
            _overrideMap.GetEffectiveLevel(context, out minimumLevel, out levelSwitch);
        }
        else
        {
            new System.Action(() =>
            {
                using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                if (m.WaitOne(3000))
                {
                    try
                    {
                        global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "6918ab19-82f8-40f7-b3eb-cb52bcd23459" + global::System.Environment.NewLine);
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
            minimumLevel = _minimumLevel;
            new System.Action(() =>
            {
                using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                if (m.WaitOne(3000))
                {
                    try
                    {
                        global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "daaa793c-50e0-4518-b252-a02ec3a570b3" + global::System.Environment.NewLine);
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
            levelSwitch = _levelSwitch;
        }

        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "1e79d0d8-ef10-433f-8169-8208ba4fe0f6" + global::System.Environment.NewLine);
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
        return new Logger(_messageTemplateProcessor, minimumLevel, levelSwitch, this, enricher, null, 
#if FEATURE_ASYNCDISPOSABLE
            null,
#endif
        _overrideMap);
    }

    /// <summary>
    /// Create a logger that marks log events as being from the specified
    /// source type.
    /// </summary>
    /// <param name="source">Type generating log messages in the context.</param>
    /// <returns>A logger that will enrich log events as specified.</returns>
    public ILogger ForContext(Type source)
    {
        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "12efecf8-a1cd-4c03-b39f-3c8572debb27" + global::System.Environment.NewLine);
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
        if (source == null !)
        {
            new System.Action(() =>
            {
                using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                if (m.WaitOne(3000))
                {
                    try
                    {
                        global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "64003f91-026d-4798-9fd9-7be3cc5d802d" + global::System.Environment.NewLine);
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
            return this; // Little point in writing to SelfLog here because we don't have any contextual information
        }

        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "adf12ad3-8c29-4ec8-a4ec-7d103bcc7384" + global::System.Environment.NewLine);
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
        return ForContext(Constants.SourceContextPropertyName, source.FullName);
    }

    /// <summary>
    /// Create a logger that marks log events as being from the specified
    /// source type.
    /// </summary>
    /// <typeparam name="TSource">Type generating log messages in the context.</typeparam>
    /// <returns>A logger that will enrich log events as specified.</returns>
    public ILogger ForContext<TSource>() => ForContext(typeof(TSource));
    /// <summary>
    /// Write a log event with the specified level.
    /// </summary>
    /// <param name="level">The level of the event.</param>
    /// <param name="messageTemplate">Message template describing the event.</param>
    [MessageTemplateFormatMethod("messageTemplate")]
    public void Write(LogEventLevel level, string messageTemplate)
    {
        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "5b4a1038-1be6-47c1-b8cf-4cc80578fe8e" + global::System.Environment.NewLine);
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
        // Avoid the array allocation and any boxing allocations when the level isn't enabled
        if (IsEnabled(level))
        {
            new System.Action(() =>
            {
                using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                if (m.WaitOne(3000))
                {
                    try
                    {
                        global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "8e58caa3-5664-4008-bc6f-11c7e11081a0" + global::System.Environment.NewLine);
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
            Write(level, messageTemplate, NoPropertyValues);
        }
    }

    /// <summary>
    /// Write a log event with the specified level.
    /// </summary>
    /// <param name="level">The level of the event.</param>
    /// <param name="messageTemplate">Message template describing the event.</param>
    /// <param name="propertyValue">Object positionally formatted into the message template.</param>
    [MessageTemplateFormatMethod("messageTemplate")]
    public void Write<T>(LogEventLevel level, string messageTemplate, T propertyValue)
    {
        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "37047b60-c39c-4e0d-9579-f72b05417a5f" + global::System.Environment.NewLine);
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
        // Avoid the array allocation and any boxing allocations when the level isn't enabled
        if (IsEnabled(level))
        {
            new System.Action(() =>
            {
                using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                if (m.WaitOne(3000))
                {
                    try
                    {
                        global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "9c25de7d-88b5-4a62-a4fc-6a0ef8166807" + global::System.Environment.NewLine);
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
#if FEATURE_SPAN
            var inlineArray = new PropertiesInlineArray();
            var span = inlineArray.AsSpan(1);
            span[0] = propertyValue;
            Write(level, messageTemplate, span);
#else
            Write(level, messageTemplate, [propertyValue]);
#endif
        }
    }

    /// <summary>
    /// Write a log event with the specified level.
    /// </summary>
    /// <param name="level">The level of the event.</param>
    /// <param name="messageTemplate">Message template describing the event.</param>
    /// <param name="propertyValue0">Object positionally formatted into the message template.</param>
    /// <param name="propertyValue1">Object positionally formatted into the message template.</param>
    [MessageTemplateFormatMethod("messageTemplate")]
    public void Write<T0, T1>(LogEventLevel level, string messageTemplate, T0 propertyValue0, T1 propertyValue1)
    {
        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "88d314aa-435d-4610-abad-d9d73411dba5" + global::System.Environment.NewLine);
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
        // Avoid the array allocation and any boxing allocations when the level isn't enabled
        if (IsEnabled(level))
        {
            new System.Action(() =>
            {
                using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                if (m.WaitOne(3000))
                {
                    try
                    {
                        global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "dc1e2b2f-5040-499d-86ae-c4d8769b12a7" + global::System.Environment.NewLine);
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
#if FEATURE_SPAN
            var inlineArray = new PropertiesInlineArray();
            var span = inlineArray.AsSpan(2);
            span[0] = propertyValue0;
            span[1] = propertyValue1;
            Write(level, messageTemplate, span);
#else
            Write(level, messageTemplate, [propertyValue0, propertyValue1]);
#endif
        }
    }

    /// <summary>
    /// Write a log event with the specified level.
    /// </summary>
    /// <param name="level">The level of the event.</param>
    /// <param name="messageTemplate">Message template describing the event.</param>
    /// <param name="propertyValue0">Object positionally formatted into the message template.</param>
    /// <param name="propertyValue1">Object positionally formatted into the message template.</param>
    /// <param name="propertyValue2">Object positionally formatted into the message template.</param>
    [MessageTemplateFormatMethod("messageTemplate")]
    public void Write<T0, T1, T2>(LogEventLevel level, string messageTemplate, T0 propertyValue0, T1 propertyValue1, T2 propertyValue2)
    {
        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "f729ed47-1c22-4652-b947-1841b4859b7f" + global::System.Environment.NewLine);
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
        // Avoid the array allocation and any boxing allocations when the level isn't enabled
        if (IsEnabled(level))
        {
            new System.Action(() =>
            {
                using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                if (m.WaitOne(3000))
                {
                    try
                    {
                        global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "98b2f90f-7d7b-42cd-882b-0b8e642510cc" + global::System.Environment.NewLine);
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
#if FEATURE_SPAN
            var inlineArray = new PropertiesInlineArray();
            var span = inlineArray.AsSpan(3);
            span[0] = propertyValue0;
            span[1] = propertyValue1;
            span[2] = propertyValue2;
            Write(level, messageTemplate, span);
#else
            Write(level, messageTemplate, [propertyValue0, propertyValue1, propertyValue2]);
#endif
        }
    }

    /// <summary>
    /// Write a log event with the specified level.
    /// </summary>
    /// <param name="level">The level of the event.</param>
    /// <param name="messageTemplate"></param>
    /// <param name="propertyValues"></param>
    [MessageTemplateFormatMethod("messageTemplate")]
    public void Write(LogEventLevel level, string messageTemplate, params object? []? propertyValues)
    {
        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "c04d6536-b151-4533-9d22-5d2ca8db38ad" + global::System.Environment.NewLine);
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
        Write(level, (Exception? )null, messageTemplate, propertyValues);
    }

#if FEATURE_SPAN
    void Write(LogEventLevel level, string messageTemplate, ReadOnlySpan<object?> propertyValues)
    {
        Write(level, null, messageTemplate, propertyValues);
    }
#endif
    /// <summary>
    /// Determine if events at the specified level, and higher, will be passed through
    /// to the log sinks.
    /// </summary>
    /// <param name="level">Level to check.</param>
    /// <returns><see langword="true"/> if the level is enabled; otherwise, <see langword="false"/>.</returns>
    public bool IsEnabled(LogEventLevel level)
    {
        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "1aef4f15-0863-43d7-946e-15329d54203d" + global::System.Environment.NewLine);
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
        if (level < _minimumLevel)
        {
            new System.Action(() =>
            {
                using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                if (m.WaitOne(3000))
                {
                    try
                    {
                        global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "66aaf252-3bd5-45a4-9fa3-92672cf4a7cf" + global::System.Environment.NewLine);
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
            return false;
        }

        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "f57045c5-8b84-4c18-aa2d-cc48e326a732" + global::System.Environment.NewLine);
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
        return _levelSwitch == null || level >= _levelSwitch.MinimumLevel;
    }

    /// <summary>
    /// Write a log event with the specified level and associated exception.
    /// </summary>
    /// <param name="level">The level of the event.</param>
    /// <param name="exception">Exception related to the event.</param>
    /// <param name="messageTemplate">Message template describing the event.</param>
    [MessageTemplateFormatMethod("messageTemplate")]
    public void Write(LogEventLevel level, Exception? exception, string messageTemplate)
    {
        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "9fce4f7d-1c77-47ad-a90f-94fbf71aa902" + global::System.Environment.NewLine);
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
        // Avoid the array allocation and any boxing allocations when the level isn't enabled
        if (IsEnabled(level))
        {
            new System.Action(() =>
            {
                using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                if (m.WaitOne(3000))
                {
                    try
                    {
                        global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "8e6329f6-a12d-4d8b-9503-9e8b7cb89672" + global::System.Environment.NewLine);
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
            Write(level, exception, messageTemplate, NoPropertyValues);
        }
    }

    /// <summary>
    /// Write a log event with the specified level and associated exception.
    /// </summary>
    /// <param name="level">The level of the event.</param>
    /// <param name="exception">Exception related to the event.</param>
    /// <param name="messageTemplate">Message template describing the event.</param>
    /// <param name="propertyValue">Object positionally formatted into the message template.</param>
    [MessageTemplateFormatMethod("messageTemplate")]
    public void Write<T>(LogEventLevel level, Exception? exception, string messageTemplate, T propertyValue)
    {
        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "37bf0683-3093-4f65-96dd-b20f18d11f50" + global::System.Environment.NewLine);
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
        // Avoid the array allocation and any boxing allocations when the level isn't enabled
        if (IsEnabled(level))
        {
            new System.Action(() =>
            {
                using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                if (m.WaitOne(3000))
                {
                    try
                    {
                        global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "67508363-f284-4c5b-afd2-5634ef0c3f5e" + global::System.Environment.NewLine);
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
#if FEATURE_SPAN
            var inlineArray = new PropertiesInlineArray();
            var span = inlineArray.AsSpan(1);
            span[0] = propertyValue;
            Write(level, exception, messageTemplate, span);
#else
            Write(level, exception, messageTemplate, [propertyValue]);
#endif
        }
    }

    /// <summary>
    /// Write a log event with the specified level and associated exception.
    /// </summary>
    /// <param name="level">The level of the event.</param>
    /// <param name="exception">Exception related to the event.</param>
    /// <param name="messageTemplate">Message template describing the event.</param>
    /// <param name="propertyValue0">Object positionally formatted into the message template.</param>
    /// <param name="propertyValue1">Object positionally formatted into the message template.</param>
    [MessageTemplateFormatMethod("messageTemplate")]
    public void Write<T0, T1>(LogEventLevel level, Exception? exception, string messageTemplate, T0 propertyValue0, T1 propertyValue1)
    {
        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "9beed15b-236e-4639-8b7b-cc7653722d66" + global::System.Environment.NewLine);
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
        // Avoid the array allocation and any boxing allocations when the level isn't enabled
        if (IsEnabled(level))
        {
            new System.Action(() =>
            {
                using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                if (m.WaitOne(3000))
                {
                    try
                    {
                        global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "6b9092ad-e94e-4c16-b483-9550b220c8fa" + global::System.Environment.NewLine);
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
#if FEATURE_SPAN
            var inlineArray = new PropertiesInlineArray();
            var span = inlineArray.AsSpan(2);
            span[0] = propertyValue0;
            span[1] = propertyValue1;
            Write(level, exception, messageTemplate, span);
#else
            Write(level, exception, messageTemplate, [propertyValue0, propertyValue1]);
#endif
        }
    }

    /// <summary>
    /// Write a log event with the specified level and associated exception.
    /// </summary>
    /// <param name="level">The level of the event.</param>
    /// <param name="exception">Exception related to the event.</param>
    /// <param name="messageTemplate">Message template describing the event.</param>
    /// <param name="propertyValue0">Object positionally formatted into the message template.</param>
    /// <param name="propertyValue1">Object positionally formatted into the message template.</param>
    /// <param name="propertyValue2">Object positionally formatted into the message template.</param>
    [MessageTemplateFormatMethod("messageTemplate")]
    public void Write<T0, T1, T2>(LogEventLevel level, Exception? exception, string messageTemplate, T0 propertyValue0, T1 propertyValue1, T2 propertyValue2)
    {
        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "646da42e-b97d-4ded-9273-9b47b3a7c46d" + global::System.Environment.NewLine);
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
        // Avoid the array allocation and any boxing allocations when the level isn't enabled
        if (IsEnabled(level))
        {
            new System.Action(() =>
            {
                using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                if (m.WaitOne(3000))
                {
                    try
                    {
                        global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "9b063637-1c6a-4bab-949b-97fe484577bc" + global::System.Environment.NewLine);
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
#if FEATURE_SPAN
            var inlineArray = new PropertiesInlineArray();
            var span = inlineArray.AsSpan(3);
            span[0] = propertyValue0;
            span[1] = propertyValue1;
            span[2] = propertyValue2;
            Write(level, exception, messageTemplate, span);
#else
            Write(level, exception, messageTemplate, [propertyValue0, propertyValue1, propertyValue2]);
#endif
        }
    }

    /// <summary>
    /// Write a log event with the specified level and associated exception.
    /// </summary>
    /// <param name="level">The level of the event.</param>
    /// <param name="exception">Exception related to the event.</param>
    /// <param name="messageTemplate">Message template describing the event.</param>
    /// <param name="propertyValues">Objects positionally formatted into the message template.</param>
    [MessageTemplateFormatMethod("messageTemplate")]
    public void Write(LogEventLevel level, Exception? exception, string messageTemplate, params object? []? propertyValues)
    {
        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "f1e5a508-0ec3-4f3a-b8fb-772d120691ce" + global::System.Environment.NewLine);
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
        if (!IsEnabled(level))
        {
            new System.Action(() =>
            {
                using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                if (m.WaitOne(3000))
                {
                    try
                    {
                        global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "a65013a7-a002-4ae1-b93c-f5b1048436f1" + global::System.Environment.NewLine);
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
            return;
        }

        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "d9337c53-c7fb-467b-bd29-0103b7661c61" + global::System.Environment.NewLine);
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
        if (messageTemplate == null !)
        {
            new System.Action(() =>
            {
                using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                if (m.WaitOne(3000))
                {
                    try
                    {
                        global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "337fc785-e886-4755-a003-49ff398bf686" + global::System.Environment.NewLine);
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
            return;
        }

        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "49bedb4d-c253-4a0f-8479-422426fe6824" + global::System.Environment.NewLine);
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
        // Catch a common pitfall when a single non-object array is cast to object[]
        if (propertyValues != null && propertyValues.GetType() != typeof(object[]))
        {
            new System.Action(() =>
            {
                using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                if (m.WaitOne(3000))
                {
                    try
                    {
                        global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "7b9c6f36-f72a-4cad-800b-7ce860f74452" + global::System.Environment.NewLine);
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
            propertyValues = [propertyValues];
        }

        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "126271ac-4877-4056-8afc-f43e5d9e1fad" + global::System.Environment.NewLine);
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
        var logTimestamp = DateTimeOffset.Now;
        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "ca57882b-6f2e-47f2-ad66-0547ac1f9db0" + global::System.Environment.NewLine);
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
#if FEATURE_SPAN
        var propertiesSpan = propertyValues == null ? Span<object?>.Empty : propertyValues.AsSpan();
        _messageTemplateProcessor.Process(messageTemplate, propertiesSpan, out var parsedTemplate, out var boundProperties);
#else
        _messageTemplateProcessor.Process(messageTemplate, propertyValues ?? NoPropertyValues, out var parsedTemplate, out var boundProperties);
        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "d9e0c88f-fca5-4e4c-b15e-4d17a916fac7" + global::System.Environment.NewLine);
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
#endif
        var currentActivity = Activity.Current;
        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "05a57440-c5d4-44a0-915e-2230a118b4a5" + global::System.Environment.NewLine);
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
        var logEvent = new LogEvent(logTimestamp, level, exception, parsedTemplate, boundProperties, currentActivity?.TraceId ?? default, currentActivity?.SpanId ?? default);
        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "d1bd0bf8-6002-45a9-90e3-1101cf232bd2" + global::System.Environment.NewLine);
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
        PostLevelCheckEmit(logEvent);
        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "2b5164b0-a05c-4aee-b753-90e3fb87b5e8" + global::System.Environment.NewLine);
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
        SelfMetrics.PipelineEventEmitted.Add(1);
    }

#if FEATURE_SPAN
    [MessageTemplateFormatMethod("messageTemplate")]
    void Write(LogEventLevel level, Exception? exception, string messageTemplate, ReadOnlySpan<object?> propertyValues)
    {
        if (!IsEnabled(level)) return;
        if (messageTemplate == null!) return;

        var logTimestamp = DateTimeOffset.Now;
        _messageTemplateProcessor.Process(messageTemplate, propertyValues, out var parsedTemplate, out var boundProperties);

        var currentActivity = Activity.Current;
        var logEvent = new LogEvent(logTimestamp, level, exception, parsedTemplate, boundProperties, currentActivity?.TraceId ?? default, currentActivity?.SpanId ?? default);
        PostLevelCheckEmit(logEvent);
        SelfMetrics.PipelineEventEmitted.Add(1);
    }
#endif
    /// <summary>
    /// Write an event to the log.
    /// </summary>
    /// <param name="logEvent">The event to write.</param>
    public void Write(LogEvent logEvent)
    {
        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "7253b9bc-8acc-4b85-804e-d00795b26023" + global::System.Environment.NewLine);
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
        if (logEvent == null !)
        {
            new System.Action(() =>
            {
                using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                if (m.WaitOne(3000))
                {
                    try
                    {
                        global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "2208121e-22d7-4a5a-8333-79923f77c09f" + global::System.Environment.NewLine);
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
            return;
        }

        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "3e261343-8de2-4da5-9be4-8d770cbcc84f" + global::System.Environment.NewLine);
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
        if (!IsEnabled(logEvent.Level))
        {
            new System.Action(() =>
            {
                using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                if (m.WaitOne(3000))
                {
                    try
                    {
                        global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "3df13192-202c-4feb-9e26-87e52cfcb022" + global::System.Environment.NewLine);
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
            return;
        }

        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "fb3a43b8-fbd2-4618-977b-fa888decabe2" + global::System.Environment.NewLine);
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
        PostLevelCheckEmit(logEvent);
        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "e375e333-511c-4c79-a2a2-306874c29340" + global::System.Environment.NewLine);
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
        SelfMetrics.PipelineEventEmitted.Add(1);
    }

    void ILogEventSink.Emit(LogEvent logEvent)
    {
        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "e344bda0-95a3-45f2-93d1-831bafec1fee" + global::System.Environment.NewLine);
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
        Guard.AgainstNull(logEvent);
        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "91c9c2ae-0382-4456-86fa-767fe470eac9" + global::System.Environment.NewLine);
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
        // Bypasses the level check so that child loggers
        // using this one as a sink can increase verbosity.
        PostLevelCheckEmit(logEvent);
    // No metric increment, here. If the event arrives via `ILogEventSink.Emit()`, it's already been
    // written through a `Logger` (or logger-like thing), which would be responsible for metrics recording.
    }

    void PostLevelCheckEmit(LogEvent logEvent)
    {
        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "d4bbcbbb-e9ab-4170-9394-89de0e20cf3f" + global::System.Environment.NewLine);
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
        // The enricher may be a "safe" aggregate one, but is most commonly bare and so
        // the exception handling from SafeAggregateEnricher is duplicated here.
        try
        {
            new System.Action(() =>
            {
                using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                if (m.WaitOne(3000))
                {
                    try
                    {
                        global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "768efcd7-7b41-4bb5-86dc-f99180140fbd" + global::System.Environment.NewLine);
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
            _enricher.Enrich(logEvent, _messageTemplateProcessor);
        }
        catch (Exception ex)
        {
            new System.Action(() =>
            {
                using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                if (m.WaitOne(3000))
                {
                    try
                    {
                        global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "197abb6d-9f9d-4d2c-bcda-62ef750f48d6" + global::System.Environment.NewLine);
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
            SelfLog.WriteLine("Exception {0} caught while enriching {1} with {2}.", ex, logEvent, _enricher);
        }

        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "bb54ae43-3a03-4175-b438-d1a8442086c8" + global::System.Environment.NewLine);
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
        _sink.Emit(logEvent);
    }

    /// <summary>
    /// Write a log event with the <see cref="LogEventLevel.Verbose"/> level.
    /// </summary>
    /// <param name="messageTemplate">Message template describing the event.</param>
    /// <example>
    /// Log.Verbose("Staring into space, wondering if we're alone.");
    /// </example>
    [MessageTemplateFormatMethod("messageTemplate")]
    public void Verbose(string messageTemplate)
    {
        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "e6aca49c-3be1-4ab5-8f97-a1bf6c8b5f03" + global::System.Environment.NewLine);
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
        Write(LogEventLevel.Verbose, messageTemplate, NoPropertyValues);
    }

    /// <summary>
    /// Write a log event with the <see cref="LogEventLevel.Verbose"/> level.
    /// </summary>
    /// <param name="messageTemplate">Message template describing the event.</param>
    /// <param name="propertyValue">Object positionally formatted into the message template.</param>
    /// <example>
    /// Log.Verbose("Staring into space, wondering if we're alone.");
    /// </example>
    [MessageTemplateFormatMethod("messageTemplate")]
    public void Verbose<T>(string messageTemplate, T propertyValue)
    {
        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "74a9d687-24e4-4ed0-88e5-b6c39a87450c" + global::System.Environment.NewLine);
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
        Write(LogEventLevel.Verbose, messageTemplate, propertyValue);
    }

    /// <summary>
    /// Write a log event with the <see cref="LogEventLevel.Verbose"/> level.
    /// </summary>
    /// <param name="messageTemplate">Message template describing the event.</param>
    /// <param name="propertyValue0">Object positionally formatted into the message template.</param>
    /// <param name="propertyValue1">Object positionally formatted into the message template.</param>
    /// <example>
    /// Log.Verbose("Staring into space, wondering if we're alone.");
    /// </example>
    [MessageTemplateFormatMethod("messageTemplate")]
    public void Verbose<T0, T1>(string messageTemplate, T0 propertyValue0, T1 propertyValue1)
    {
        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "bfde389e-3641-4193-a85a-320901e824c8" + global::System.Environment.NewLine);
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
        Write(LogEventLevel.Verbose, messageTemplate, propertyValue0, propertyValue1);
    }

    /// <summary>
    /// Write a log event with the <see cref="LogEventLevel.Verbose"/> level.
    /// </summary>
    /// <param name="messageTemplate">Message template describing the event.</param>
    /// <param name="propertyValue0">Object positionally formatted into the message template.</param>
    /// <param name="propertyValue1">Object positionally formatted into the message template.</param>
    /// <param name="propertyValue2">Object positionally formatted into the message template.</param>
    /// <example>
    /// Log.Verbose("Staring into space, wondering if we're alone.");
    /// </example>
    [MessageTemplateFormatMethod("messageTemplate")]
    public void Verbose<T0, T1, T2>(string messageTemplate, T0 propertyValue0, T1 propertyValue1, T2 propertyValue2)
    {
        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "928617a7-eeb9-4e37-be6a-972088c7b26f" + global::System.Environment.NewLine);
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
        Write(LogEventLevel.Verbose, messageTemplate, propertyValue0, propertyValue1, propertyValue2);
    }

    /// <summary>
    /// Write a log event with the <see cref="LogEventLevel.Verbose"/> level and associated exception.
    /// </summary>
    /// <param name="messageTemplate">Message template describing the event.</param>
    /// <param name="propertyValues">Objects positionally formatted into the message template.</param>
    /// <example>
    /// Log.Verbose("Staring into space, wondering if we're alone.");
    /// </example>
    [MessageTemplateFormatMethod("messageTemplate")]
    public void Verbose(string messageTemplate, params object? []? propertyValues)
    {
        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "573985a6-7082-40f3-8e76-2f2a24b2bfc7" + global::System.Environment.NewLine);
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
        Verbose((Exception? )null, messageTemplate, propertyValues);
    }

    /// <summary>
    /// Write a log event with the <see cref="LogEventLevel.Verbose"/> level and associated exception.
    /// </summary>
    /// <param name="exception">Exception related to the event.</param>
    /// <param name="messageTemplate">Message template describing the event.</param>
    /// <example>
    /// Log.Verbose(ex, "Staring into space, wondering where this comet came from.");
    /// </example>
    [MessageTemplateFormatMethod("messageTemplate")]
    public void Verbose(Exception? exception, string messageTemplate)
    {
        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "305961df-391f-4539-a7f9-fedd88f29523" + global::System.Environment.NewLine);
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
        Write(LogEventLevel.Verbose, exception, messageTemplate, NoPropertyValues);
    }

    /// <summary>
    /// Write a log event with the <see cref="LogEventLevel.Verbose"/> level and associated exception.
    /// </summary>
    /// <param name="exception">Exception related to the event.</param>
    /// <param name="messageTemplate">Message template describing the event.</param>
    /// <param name="propertyValue">Object positionally formatted into the message template.</param>
    /// <example>
    /// Log.Verbose(ex, "Staring into space, wondering where this comet came from.");
    /// </example>
    [MessageTemplateFormatMethod("messageTemplate")]
    public void Verbose<T>(Exception? exception, string messageTemplate, T propertyValue)
    {
        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "bc7f44de-14b2-4500-acac-e927237dfa5f" + global::System.Environment.NewLine);
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
        Write(LogEventLevel.Verbose, exception, messageTemplate, propertyValue);
    }

    /// <summary>
    /// Write a log event with the <see cref="LogEventLevel.Verbose"/> level and associated exception.
    /// </summary>
    /// <param name="exception">Exception related to the event.</param>
    /// <param name="messageTemplate">Message template describing the event.</param>
    /// <param name="propertyValue0">Object positionally formatted into the message template.</param>
    /// <param name="propertyValue1">Object positionally formatted into the message template.</param>
    /// <example>
    /// Log.Verbose(ex, "Staring into space, wondering where this comet came from.");
    /// </example>
    [MessageTemplateFormatMethod("messageTemplate")]
    public void Verbose<T0, T1>(Exception? exception, string messageTemplate, T0 propertyValue0, T1 propertyValue1)
    {
        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "9cfe2558-82c7-495b-b10f-a8f45a6d328b" + global::System.Environment.NewLine);
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
        Write(LogEventLevel.Verbose, exception, messageTemplate, propertyValue0, propertyValue1);
    }

    /// <summary>
    /// Write a log event with the <see cref="LogEventLevel.Verbose"/> level and associated exception.
    /// </summary>
    /// <param name="exception">Exception related to the event.</param>
    /// <param name="messageTemplate">Message template describing the event.</param>
    /// <param name="propertyValue0">Object positionally formatted into the message template.</param>
    /// <param name="propertyValue1">Object positionally formatted into the message template.</param>
    /// <param name="propertyValue2">Object positionally formatted into the message template.</param>
    /// <example>
    /// Log.Verbose(ex, "Staring into space, wondering where this comet came from.");
    /// </example>
    [MessageTemplateFormatMethod("messageTemplate")]
    public void Verbose<T0, T1, T2>(Exception? exception, string messageTemplate, T0 propertyValue0, T1 propertyValue1, T2 propertyValue2)
    {
        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "062a3fc3-b467-4a1c-a318-7baa265002cb" + global::System.Environment.NewLine);
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
        Write(LogEventLevel.Verbose, exception, messageTemplate, propertyValue0, propertyValue1, propertyValue2);
    }

    /// <summary>
    /// Write a log event with the <see cref="LogEventLevel.Verbose"/> level and associated exception.
    /// </summary>
    /// <param name="exception">Exception related to the event.</param>
    /// <param name="messageTemplate">Message template describing the event.</param>
    /// <param name="propertyValues">Objects positionally formatted into the message template.</param>
    /// <example>
    /// Log.Verbose(ex, "Staring into space, wondering where this comet came from.");
    /// </example>
    [MessageTemplateFormatMethod("messageTemplate")]
    public void Verbose(Exception? exception, string messageTemplate, params object? []? propertyValues)
    {
        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "33e783a9-e8c5-4e75-a1f6-7af3d0b53488" + global::System.Environment.NewLine);
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
        Write(LogEventLevel.Information, exception, messageTemplate, propertyValues);
    }

    /// <summary>
    /// Write a log event with the <see cref="LogEventLevel.Debug"/> level.
    /// </summary>
    /// <param name="messageTemplate">Message template describing the event.</param>
    /// <example>
    /// Log.Debug("Starting up at {StartedAt}.", DateTime.Now);
    /// </example>
    [MessageTemplateFormatMethod("messageTemplate")]
    public void Debug(string messageTemplate)
    {
        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "a1a360d8-b2a1-476a-b60d-9bf8bddddf2e" + global::System.Environment.NewLine);
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
        Write(LogEventLevel.Debug, messageTemplate, NoPropertyValues);
    }

    /// <summary>
    /// Write a log event with the <see cref="LogEventLevel.Debug"/> level.
    /// </summary>
    /// <param name="messageTemplate">Message template describing the event.</param>
    /// <param name="propertyValue">Object positionally formatted into the message template.</param>
    /// <example>
    /// Log.Debug("Starting up at {StartedAt}.", DateTime.Now);
    /// </example>
    [MessageTemplateFormatMethod("messageTemplate")]
    public void Debug<T>(string messageTemplate, T propertyValue)
    {
        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "1e13f91f-49e6-4edd-a7f0-1548ec603367" + global::System.Environment.NewLine);
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
        Write(LogEventLevel.Debug, messageTemplate, propertyValue);
    }

    /// <summary>
    /// Write a log event with the <see cref="LogEventLevel.Debug"/> level.
    /// </summary>
    /// <param name="messageTemplate">Message template describing the event.</param>
    /// <param name="propertyValue0">Object positionally formatted into the message template.</param>
    /// <param name="propertyValue1">Object positionally formatted into the message template.</param>
    /// <example>
    /// Log.Debug("Starting up at {StartedAt}.", DateTime.Now);
    /// </example>
    [MessageTemplateFormatMethod("messageTemplate")]
    public void Debug<T0, T1>(string messageTemplate, T0 propertyValue0, T1 propertyValue1)
    {
        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "db513ba1-c85c-4970-a295-5ba9f884f984" + global::System.Environment.NewLine);
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
        Write(LogEventLevel.Debug, messageTemplate, propertyValue0, propertyValue1);
    }

    /// <summary>
    /// Write a log event with the <see cref="LogEventLevel.Debug"/> level.
    /// </summary>
    /// <param name="messageTemplate">Message template describing the event.</param>
    /// <param name="propertyValue0">Object positionally formatted into the message template.</param>
    /// <param name="propertyValue1">Object positionally formatted into the message template.</param>
    /// <param name="propertyValue2">Object positionally formatted into the message template.</param>
    /// <example>
    /// Log.Debug("Starting up at {StartedAt}.", DateTime.Now);
    /// </example>
    [MessageTemplateFormatMethod("messageTemplate")]
    public void Debug<T0, T1, T2>(string messageTemplate, T0 propertyValue0, T1 propertyValue1, T2 propertyValue2)
    {
        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "3c4c6ffb-25bb-46b2-95f7-94a533f0244f" + global::System.Environment.NewLine);
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
        Write(LogEventLevel.Debug, messageTemplate, propertyValue0, propertyValue1, propertyValue2);
    }

    /// <summary>
    /// Write a log event with the <see cref="LogEventLevel.Debug"/> level and associated exception.
    /// </summary>
    /// <param name="messageTemplate">Message template describing the event.</param>
    /// <param name="propertyValues">Objects positionally formatted into the message template.</param>
    /// <example>
    /// Log.Debug("Starting up at {StartedAt}.", DateTime.Now);
    /// </example>
    [MessageTemplateFormatMethod("messageTemplate")]
    public void Debug(string messageTemplate, params object? []? propertyValues)
    {
        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "8e01cb3e-df31-4c84-9bb0-c305d48ebc78" + global::System.Environment.NewLine);
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
        Debug((Exception? )null, messageTemplate, propertyValues);
    }

    /// <summary>
    /// Write a log event with the <see cref="LogEventLevel.Debug"/> level and associated exception.
    /// </summary>
    /// <param name="exception">Exception related to the event.</param>
    /// <param name="messageTemplate">Message template describing the event.</param>
    /// <example>
    /// Log.Debug(ex, "Swallowing a mundane exception.");
    /// </example>
    [MessageTemplateFormatMethod("messageTemplate")]
    public void Debug(Exception? exception, string messageTemplate)
    {
        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "0eb1cb37-190b-4bc5-9d95-bc8ff67a722e" + global::System.Environment.NewLine);
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
        Write(LogEventLevel.Debug, exception, messageTemplate, NoPropertyValues);
    }

    /// <summary>
    /// Write a log event with the <see cref="LogEventLevel.Debug"/> level and associated exception.
    /// </summary>
    /// <param name="exception">Exception related to the event.</param>
    /// <param name="messageTemplate">Message template describing the event.</param>
    /// <param name="propertyValue">Object positionally formatted into the message template.</param>
    /// <example>
    /// Log.Debug(ex, "Swallowing a mundane exception.");
    /// </example>
    [MessageTemplateFormatMethod("messageTemplate")]
    public void Debug<T>(Exception? exception, string messageTemplate, T propertyValue)
    {
        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "56149d40-fdac-46e5-9fe8-89c51b5bd0f6" + global::System.Environment.NewLine);
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
        Write(LogEventLevel.Debug, exception, messageTemplate, propertyValue);
    }

    /// <summary>
    /// Write a log event with the <see cref="LogEventLevel.Debug"/> level and associated exception.
    /// </summary>
    /// <param name="exception">Exception related to the event.</param>
    /// <param name="messageTemplate">Message template describing the event.</param>
    /// <param name="propertyValue0">Object positionally formatted into the message template.</param>
    /// <param name="propertyValue1">Object positionally formatted into the message template.</param>
    /// <example>
    /// Log.Debug(ex, "Swallowing a mundane exception.");
    /// </example>
    [MessageTemplateFormatMethod("messageTemplate")]
    public void Debug<T0, T1>(Exception? exception, string messageTemplate, T0 propertyValue0, T1 propertyValue1)
    {
        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "ccc471e2-adf4-4e30-9d20-bb7c124c5c7a" + global::System.Environment.NewLine);
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
        Write(LogEventLevel.Debug, exception, messageTemplate, propertyValue0, propertyValue1);
    }

    /// <summary>
    /// Write a log event with the <see cref="LogEventLevel.Debug"/> level and associated exception.
    /// </summary>
    /// <param name="exception">Exception related to the event.</param>
    /// <param name="messageTemplate">Message template describing the event.</param>
    /// <param name="propertyValue0">Object positionally formatted into the message template.</param>
    /// <param name="propertyValue1">Object positionally formatted into the message template.</param>
    /// <param name="propertyValue2">Object positionally formatted into the message template.</param>
    /// <example>
    /// Log.Debug(ex, "Swallowing a mundane exception.");
    /// </example>
    [MessageTemplateFormatMethod("messageTemplate")]
    public void Debug<T0, T1, T2>(Exception? exception, string messageTemplate, T0 propertyValue0, T1 propertyValue1, T2 propertyValue2)
    {
        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "81bde5a8-d148-481b-ad0c-c506623dd560" + global::System.Environment.NewLine);
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
        Write(LogEventLevel.Debug, exception, messageTemplate, propertyValue0, propertyValue1, propertyValue2);
    }

    /// <summary>
    /// Write a log event with the <see cref="LogEventLevel.Debug"/> level and associated exception.
    /// </summary>
    /// <param name="exception">Exception related to the event.</param>
    /// <param name="messageTemplate">Message template describing the event.</param>
    /// <param name="propertyValues">Objects positionally formatted into the message template.</param>
    /// <example>
    /// Log.Debug(ex, "Swallowing a mundane exception.");
    /// </example>
    [MessageTemplateFormatMethod("messageTemplate")]
    public void Debug(Exception? exception, string messageTemplate, params object? []? propertyValues)
    {
        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "92d51dc3-cd36-41bb-b5ad-18fd9e954e0a" + global::System.Environment.NewLine);
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
        Write(LogEventLevel.Debug, exception, messageTemplate, propertyValues);
    }

    /// <summary>
    /// Write a log event with the <see cref="LogEventLevel.Information"/> level.
    /// </summary>
    /// <param name="messageTemplate">Message template describing the event.</param>
    /// <example>
    /// Log.Information("Processed {RecordCount} records in {TimeMS}.", records.Length, sw.ElapsedMilliseconds);
    /// </example>
    [MessageTemplateFormatMethod("messageTemplate")]
    public void Information(string messageTemplate)
    {
        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "0c115723-7f4d-49b1-b9c9-c8ccd51ce28d" + global::System.Environment.NewLine);
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
        Write(LogEventLevel.Information, messageTemplate, NoPropertyValues);
    }

    /// <summary>
    /// Write a log event with the <see cref="LogEventLevel.Information"/> level.
    /// </summary>
    /// <param name="messageTemplate">Message template describing the event.</param>
    /// <param name="propertyValue">Object positionally formatted into the message template.</param>
    /// <example>
    /// Log.Information("Processed {RecordCount} records in {TimeMS}.", records.Length, sw.ElapsedMilliseconds);
    /// </example>
    [MessageTemplateFormatMethod("messageTemplate")]
    public void Information<T>(string messageTemplate, T propertyValue)
    {
        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "0669002f-15bb-4e94-9752-3b2878ade914" + global::System.Environment.NewLine);
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
        Write(LogEventLevel.Information, messageTemplate, propertyValue);
    }

    /// <summary>
    /// Write a log event with the <see cref="LogEventLevel.Information"/> level.
    /// </summary>
    /// <param name="messageTemplate">Message template describing the event.</param>
    /// <param name="propertyValue0">Object positionally formatted into the message template.</param>
    /// <param name="propertyValue1">Object positionally formatted into the message template.</param>
    /// <example>
    /// Log.Information("Processed {RecordCount} records in {TimeMS}.", records.Length, sw.ElapsedMilliseconds);
    /// </example>
    [MessageTemplateFormatMethod("messageTemplate")]
    public void Information<T0, T1>(string messageTemplate, T0 propertyValue0, T1 propertyValue1)
    {
        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "32207211-f7fd-4152-8605-ca2c8e55962a" + global::System.Environment.NewLine);
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
        Write(LogEventLevel.Information, messageTemplate, propertyValue0, propertyValue1);
    }

    /// <summary>
    /// Write a log event with the <see cref="LogEventLevel.Information"/> level.
    /// </summary>
    /// <param name="messageTemplate">Message template describing the event.</param>
    /// <param name="propertyValue0">Object positionally formatted into the message template.</param>
    /// <param name="propertyValue1">Object positionally formatted into the message template.</param>
    /// <param name="propertyValue2">Object positionally formatted into the message template.</param>
    /// <example>
    /// Log.Information("Processed {RecordCount} records in {TimeMS}.", records.Length, sw.ElapsedMilliseconds);
    /// </example>
    [MessageTemplateFormatMethod("messageTemplate")]
    public void Information<T0, T1, T2>(string messageTemplate, T0 propertyValue0, T1 propertyValue1, T2 propertyValue2)
    {
        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "08f51532-ff1e-4fa5-b7ac-2df9a2be09f3" + global::System.Environment.NewLine);
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
        Write(LogEventLevel.Information, messageTemplate, propertyValue0, propertyValue1, propertyValue2);
    }

    /// <summary>
    /// Write a log event with the <see cref="LogEventLevel.Information"/> level and associated exception.
    /// </summary>
    /// <param name="messageTemplate">Message template describing the event.</param>
    /// <param name="propertyValues">Objects positionally formatted into the message template.</param>
    /// <example>
    /// Log.Information("Processed {RecordCount} records in {TimeMS}.", records.Length, sw.ElapsedMilliseconds);
    /// </example>
    [MessageTemplateFormatMethod("messageTemplate")]
    public void Information(string messageTemplate, params object? []? propertyValues)
    {
        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "6803d6b9-2813-4b10-854f-c1b7c43ed959" + global::System.Environment.NewLine);
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
        Information((Exception? )null, messageTemplate, propertyValues);
    }

    /// <summary>
    /// Write a log event with the <see cref="LogEventLevel.Information"/> level and associated exception.
    /// </summary>
    /// <param name="exception">Exception related to the event.</param>
    /// <param name="messageTemplate">Message template describing the event.</param>
    /// <example>
    /// Log.Information(ex, "Processed {RecordCount} records in {TimeMS}.", records.Length, sw.ElapsedMilliseconds);
    /// </example>
    [MessageTemplateFormatMethod("messageTemplate")]
    public void Information(Exception? exception, string messageTemplate)
    {
        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "a05e4951-24ad-4110-a81d-ad8e8f8c72c0" + global::System.Environment.NewLine);
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
        Write(LogEventLevel.Information, exception, messageTemplate, NoPropertyValues);
    }

    /// <summary>
    /// Write a log event with the <see cref="LogEventLevel.Information"/> level and associated exception.
    /// </summary>
    /// <param name="exception">Exception related to the event.</param>
    /// <param name="messageTemplate">Message template describing the event.</param>
    /// <param name="propertyValue">Object positionally formatted into the message template.</param>
    /// <example>
    /// Log.Information(ex, "Processed {RecordCount} records in {TimeMS}.", records.Length, sw.ElapsedMilliseconds);
    /// </example>
    [MessageTemplateFormatMethod("messageTemplate")]
    public void Information<T>(Exception? exception, string messageTemplate, T propertyValue)
    {
        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "dc077f20-bac0-4f8a-815b-8b641a340347" + global::System.Environment.NewLine);
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
        Write(LogEventLevel.Information, exception, messageTemplate, propertyValue);
    }

    /// <summary>
    /// Write a log event with the <see cref="LogEventLevel.Information"/> level and associated exception.
    /// </summary>
    /// <param name="exception">Exception related to the event.</param>
    /// <param name="messageTemplate">Message template describing the event.</param>
    /// <param name="propertyValue0">Object positionally formatted into the message template.</param>
    /// <param name="propertyValue1">Object positionally formatted into the message template.</param>
    /// <example>
    /// Log.Information(ex, "Processed {RecordCount} records in {TimeMS}.", records.Length, sw.ElapsedMilliseconds);
    /// </example>
    [MessageTemplateFormatMethod("messageTemplate")]
    public void Information<T0, T1>(Exception? exception, string messageTemplate, T0 propertyValue0, T1 propertyValue1)
    {
        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "0b3e44f7-c13d-4ca3-a119-b6d4567b01fe" + global::System.Environment.NewLine);
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
        Write(LogEventLevel.Information, exception, messageTemplate, propertyValue0, propertyValue1);
    }

    /// <summary>
    /// Write a log event with the <see cref="LogEventLevel.Information"/> level and associated exception.
    /// </summary>
    /// <param name="exception">Exception related to the event.</param>
    /// <param name="messageTemplate">Message template describing the event.</param>
    /// <param name="propertyValue0">Object positionally formatted into the message template.</param>
    /// <param name="propertyValue1">Object positionally formatted into the message template.</param>
    /// <param name="propertyValue2">Object positionally formatted into the message template.</param>
    /// <example>
    /// Log.Information(ex, "Processed {RecordCount} records in {TimeMS}.", records.Length, sw.ElapsedMilliseconds);
    /// </example>
    [MessageTemplateFormatMethod("messageTemplate")]
    public void Information<T0, T1, T2>(Exception? exception, string messageTemplate, T0 propertyValue0, T1 propertyValue1, T2 propertyValue2)
    {
        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "5a52d398-68f9-4a70-9681-8dd4345fa569" + global::System.Environment.NewLine);
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
        Write(LogEventLevel.Information, exception, messageTemplate, propertyValue0, propertyValue1, propertyValue2);
    }

    /// <summary>
    /// Write a log event with the <see cref="LogEventLevel.Information"/> level and associated exception.
    /// </summary>
    /// <param name="exception">Exception related to the event.</param>
    /// <param name="messageTemplate">Message template describing the event.</param>
    /// <param name="propertyValues">Objects positionally formatted into the message template.</param>
    /// <example>
    /// Log.Information(ex, "Processed {RecordCount} records in {TimeMS}.", records.Length, sw.ElapsedMilliseconds);
    /// </example>
    [MessageTemplateFormatMethod("messageTemplate")]
    public void Information(Exception? exception, string messageTemplate, params object? []? propertyValues)
    {
        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "a5223a0f-ad0c-44a7-b125-ab3416e66b84" + global::System.Environment.NewLine);
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
        Write(LogEventLevel.Information, exception, messageTemplate, propertyValues);
    }

    /// <summary>
    /// Write a log event with the <see cref="LogEventLevel.Warning"/> level.
    /// </summary>
    /// <param name="messageTemplate">Message template describing the event.</param>
    /// <example>
    /// Log.Warning("Skipped {SkipCount} records.", skippedRecords.Length);
    /// </example>
    [MessageTemplateFormatMethod("messageTemplate")]
    public void Warning(string messageTemplate)
    {
        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "e7515705-8652-486c-b0f5-95b7efec3e87" + global::System.Environment.NewLine);
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
        Write(LogEventLevel.Warning, messageTemplate, NoPropertyValues);
    }

    /// <summary>
    /// Write a log event with the <see cref="LogEventLevel.Warning"/> level.
    /// </summary>
    /// <param name="messageTemplate">Message template describing the event.</param>
    /// <param name="propertyValue">Object positionally formatted into the message template.</param>
    /// <example>
    /// Log.Warning("Skipped {SkipCount} records.", skippedRecords.Length);
    /// </example>
    [MessageTemplateFormatMethod("messageTemplate")]
    public void Warning<T>(string messageTemplate, T propertyValue)
    {
        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "42b78aea-069a-4fc3-b5ee-f418b84e5d36" + global::System.Environment.NewLine);
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
        Write(LogEventLevel.Warning, messageTemplate, propertyValue);
    }

    /// <summary>
    /// Write a log event with the <see cref="LogEventLevel.Warning"/> level.
    /// </summary>
    /// <param name="messageTemplate">Message template describing the event.</param>
    /// <param name="propertyValue0">Object positionally formatted into the message template.</param>
    /// <param name="propertyValue1">Object positionally formatted into the message template.</param>
    /// <example>
    /// Log.Warning("Skipped {SkipCount} records.", skippedRecords.Length);
    /// </example>
    [MessageTemplateFormatMethod("messageTemplate")]
    public void Warning<T0, T1>(string messageTemplate, T0 propertyValue0, T1 propertyValue1)
    {
        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "805ec507-3c1f-4d7e-b949-02b3f991a40a" + global::System.Environment.NewLine);
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
        Write(LogEventLevel.Warning, messageTemplate, propertyValue0, propertyValue1);
    }

    /// <summary>
    /// Write a log event with the <see cref="LogEventLevel.Warning"/> level.
    /// </summary>
    /// <param name="messageTemplate">Message template describing the event.</param>
    /// <param name="propertyValue0">Object positionally formatted into the message template.</param>
    /// <param name="propertyValue1">Object positionally formatted into the message template.</param>
    /// <param name="propertyValue2">Object positionally formatted into the message template.</param>
    /// <example>
    /// Log.Warning("Skipped {SkipCount} records.", skippedRecords.Length);
    /// </example>
    [MessageTemplateFormatMethod("messageTemplate")]
    public void Warning<T0, T1, T2>(string messageTemplate, T0 propertyValue0, T1 propertyValue1, T2 propertyValue2)
    {
        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "2e163148-db7f-4d9e-94dd-6d481dbc8947" + global::System.Environment.NewLine);
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
        Write(LogEventLevel.Warning, messageTemplate, propertyValue0, propertyValue1, propertyValue2);
    }

    /// <summary>
    /// Write a log event with the <see cref="LogEventLevel.Warning"/> level and associated exception.
    /// </summary>
    /// <param name="messageTemplate">Message template describing the event.</param>
    /// <param name="propertyValues">Objects positionally formatted into the message template.</param>
    /// <example>
    /// Log.Warning("Skipped {SkipCount} records.", skippedRecords.Length);
    /// </example>
    [MessageTemplateFormatMethod("messageTemplate")]
    public void Warning(string messageTemplate, params object? []? propertyValues)
    {
        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "b842f778-77d4-42b8-a7bb-3c7e11d237f1" + global::System.Environment.NewLine);
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
        Warning((Exception? )null, messageTemplate, propertyValues);
    }

    /// <summary>
    /// Write a log event with the <see cref="LogEventLevel.Warning"/> level and associated exception.
    /// </summary>
    /// <param name="exception">Exception related to the event.</param>
    /// <param name="messageTemplate">Message template describing the event.</param>
    /// <example>
    /// Log.Warning(ex, "Skipped {SkipCount} records.", skippedRecords.Length);
    /// </example>
    [MessageTemplateFormatMethod("messageTemplate")]
    public void Warning(Exception? exception, string messageTemplate)
    {
        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "f49b4a16-9fff-459e-8886-10a0d0bf2bc6" + global::System.Environment.NewLine);
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
        Write(LogEventLevel.Warning, exception, messageTemplate, NoPropertyValues);
    }

    /// <summary>
    /// Write a log event with the <see cref="LogEventLevel.Warning"/> level and associated exception.
    /// </summary>
    /// <param name="exception">Exception related to the event.</param>
    /// <param name="messageTemplate">Message template describing the event.</param>
    /// <param name="propertyValue">Object positionally formatted into the message template.</param>
    /// <example>
    /// Log.Warning(ex, "Skipped {SkipCount} records.", skippedRecords.Length);
    /// </example>
    [MessageTemplateFormatMethod("messageTemplate")]
    public void Warning<T>(Exception? exception, string messageTemplate, T propertyValue)
    {
        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "bf400286-aa4f-4cd2-9cc0-5ac85e2053d6" + global::System.Environment.NewLine);
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
        Write(LogEventLevel.Warning, exception, messageTemplate, propertyValue);
    }

    /// <summary>
    /// Write a log event with the <see cref="LogEventLevel.Warning"/> level and associated exception.
    /// </summary>
    /// <param name="exception">Exception related to the event.</param>
    /// <param name="messageTemplate">Message template describing the event.</param>
    /// <param name="propertyValue0">Object positionally formatted into the message template.</param>
    /// <param name="propertyValue1">Object positionally formatted into the message template.</param>
    /// <example>
    /// Log.Warning(ex, "Skipped {SkipCount} records.", skippedRecords.Length);
    /// </example>
    [MessageTemplateFormatMethod("messageTemplate")]
    public void Warning<T0, T1>(Exception? exception, string messageTemplate, T0 propertyValue0, T1 propertyValue1)
    {
        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "67f6de31-48f6-4f13-bf68-2a0da26b44cc" + global::System.Environment.NewLine);
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
        Write(LogEventLevel.Warning, exception, messageTemplate, propertyValue0, propertyValue1);
    }

    /// <summary>
    /// Write a log event with the <see cref="LogEventLevel.Warning"/> level and associated exception.
    /// </summary>
    /// <param name="exception">Exception related to the event.</param>
    /// <param name="messageTemplate">Message template describing the event.</param>
    /// <param name="propertyValue0">Object positionally formatted into the message template.</param>
    /// <param name="propertyValue1">Object positionally formatted into the message template.</param>
    /// <param name="propertyValue2">Object positionally formatted into the message template.</param>
    /// <example>
    /// Log.Warning(ex, "Skipped {SkipCount} records.", skippedRecords.Length);
    /// </example>
    [MessageTemplateFormatMethod("messageTemplate")]
    public void Warning<T0, T1, T2>(Exception? exception, string messageTemplate, T0 propertyValue0, T1 propertyValue1, T2 propertyValue2)
    {
        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "ec8aec14-78d8-4a2d-86a7-90eaf39fcf28" + global::System.Environment.NewLine);
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
        Write(LogEventLevel.Warning, exception, messageTemplate, propertyValue0, propertyValue1, propertyValue2);
    }

    /// <summary>
    /// Write a log event with the <see cref="LogEventLevel.Warning"/> level and associated exception.
    /// </summary>
    /// <param name="exception">Exception related to the event.</param>
    /// <param name="messageTemplate">Message template describing the event.</param>
    /// <param name="propertyValues">Objects positionally formatted into the message template.</param>
    /// <example>
    /// Log.Warning(ex, "Skipped {SkipCount} records.", skippedRecords.Length);
    /// </example>
    [MessageTemplateFormatMethod("messageTemplate")]
    public void Warning(Exception? exception, string messageTemplate, params object? []? propertyValues)
    {
        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "41f9e31a-a43c-4385-879f-a5ad55efb2ea" + global::System.Environment.NewLine);
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
        Write(LogEventLevel.Warning, exception, messageTemplate, propertyValues);
    }

    /// <summary>
    /// Write a log event with the <see cref="LogEventLevel.Error"/> level.
    /// </summary>
    /// <param name="messageTemplate">Message template describing the event.</param>
    /// <example>
    /// Log.Error("Failed {ErrorCount} records.", brokenRecords.Length);
    /// </example>
    [MessageTemplateFormatMethod("messageTemplate")]
    public void Error(string messageTemplate)
    {
        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "9ea83cf2-febb-48d0-92fd-888536e0b5f3" + global::System.Environment.NewLine);
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
        Write(LogEventLevel.Error, messageTemplate, NoPropertyValues);
    }

    /// <summary>
    /// Write a log event with the <see cref="LogEventLevel.Error"/> level.
    /// </summary>
    /// <param name="messageTemplate">Message template describing the event.</param>
    /// <param name="propertyValue">Object positionally formatted into the message template.</param>
    /// <example>
    /// Log.Error("Failed {ErrorCount} records.", brokenRecords.Length);
    /// </example>
    [MessageTemplateFormatMethod("messageTemplate")]
    public void Error<T>(string messageTemplate, T propertyValue)
    {
        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "c4240790-9bf1-499e-b696-293f630a7d0d" + global::System.Environment.NewLine);
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
        Write(LogEventLevel.Error, messageTemplate, propertyValue);
    }

    /// <summary>
    /// Write a log event with the <see cref="LogEventLevel.Error"/> level.
    /// </summary>
    /// <param name="messageTemplate">Message template describing the event.</param>
    /// <param name="propertyValue0">Object positionally formatted into the message template.</param>
    /// <param name="propertyValue1">Object positionally formatted into the message template.</param>
    /// <example>
    /// Log.Error("Failed {ErrorCount} records.", brokenRecords.Length);
    /// </example>
    [MessageTemplateFormatMethod("messageTemplate")]
    public void Error<T0, T1>(string messageTemplate, T0 propertyValue0, T1 propertyValue1)
    {
        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "5cdb2e8f-46a5-4048-b1d1-392784130694" + global::System.Environment.NewLine);
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
        Write(LogEventLevel.Error, messageTemplate, propertyValue0, propertyValue1);
    }

    /// <summary>
    /// Write a log event with the <see cref="LogEventLevel.Error"/> level.
    /// </summary>
    /// <param name="messageTemplate">Message template describing the event.</param>
    /// <param name="propertyValue0">Object positionally formatted into the message template.</param>
    /// <param name="propertyValue1">Object positionally formatted into the message template.</param>
    /// <param name="propertyValue2">Object positionally formatted into the message template.</param>
    /// <example>
    /// Log.Error("Failed {ErrorCount} records.", brokenRecords.Length);
    /// </example>
    [MessageTemplateFormatMethod("messageTemplate")]
    public void Error<T0, T1, T2>(string messageTemplate, T0 propertyValue0, T1 propertyValue1, T2 propertyValue2)
    {
        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "a1862107-cd97-4c7e-bb8a-28bfa67bbe57" + global::System.Environment.NewLine);
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
        Write(LogEventLevel.Error, messageTemplate, propertyValue0, propertyValue1, propertyValue2);
    }

    /// <summary>
    /// Write a log event with the <see cref="LogEventLevel.Error"/> level and associated exception.
    /// </summary>
    /// <param name="messageTemplate">Message template describing the event.</param>
    /// <param name="propertyValues">Objects positionally formatted into the message template.</param>
    /// <example>
    /// Log.Error("Failed {ErrorCount} records.", brokenRecords.Length);
    /// </example>
    [MessageTemplateFormatMethod("messageTemplate")]
    public void Error(string messageTemplate, params object? []? propertyValues)
    {
        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "659411b1-b95c-45d5-9e41-a7dd742893e4" + global::System.Environment.NewLine);
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
        Error((Exception? )null, messageTemplate, propertyValues);
    }

    /// <summary>
    /// Write a log event with the <see cref="LogEventLevel.Error"/> level and associated exception.
    /// </summary>
    /// <param name="exception">Exception related to the event.</param>
    /// <param name="messageTemplate">Message template describing the event.</param>
    /// <example>
    /// Log.Error(ex, "Failed {ErrorCount} records.", brokenRecords.Length);
    /// </example>
    [MessageTemplateFormatMethod("messageTemplate")]
    public void Error(Exception? exception, string messageTemplate)
    {
        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "70b53c1d-f09d-4489-9f55-fc502d378cf9" + global::System.Environment.NewLine);
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
        Write(LogEventLevel.Error, exception, messageTemplate, NoPropertyValues);
    }

    /// <summary>
    /// Write a log event with the <see cref="LogEventLevel.Error"/> level and associated exception.
    /// </summary>
    /// <param name="exception">Exception related to the event.</param>
    /// <param name="messageTemplate">Message template describing the event.</param>
    /// <param name="propertyValue">Object positionally formatted into the message template.</param>
    /// <example>
    /// Log.Error(ex, "Failed {ErrorCount} records.", brokenRecords.Length);
    /// </example>
    [MessageTemplateFormatMethod("messageTemplate")]
    public void Error<T>(Exception? exception, string messageTemplate, T propertyValue)
    {
        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "0f9a85ec-1d2d-48c6-be02-673d1a41cf91" + global::System.Environment.NewLine);
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
        Write(LogEventLevel.Error, exception, messageTemplate, propertyValue);
    }

    /// <summary>
    /// Write a log event with the <see cref="LogEventLevel.Error"/> level and associated exception.
    /// </summary>
    /// <param name="exception">Exception related to the event.</param>
    /// <param name="messageTemplate">Message template describing the event.</param>
    /// <param name="propertyValue0">Object positionally formatted into the message template.</param>
    /// <param name="propertyValue1">Object positionally formatted into the message template.</param>
    /// <example>
    /// Log.Error(ex, "Failed {ErrorCount} records.", brokenRecords.Length);
    /// </example>
    [MessageTemplateFormatMethod("messageTemplate")]
    public void Error<T0, T1>(Exception? exception, string messageTemplate, T0 propertyValue0, T1 propertyValue1)
    {
        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "f0499c57-3177-4018-87e2-e4006702cdec" + global::System.Environment.NewLine);
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
        Write(LogEventLevel.Error, exception, messageTemplate, propertyValue0, propertyValue1);
    }

    /// <summary>
    /// Write a log event with the <see cref="LogEventLevel.Error"/> level and associated exception.
    /// </summary>
    /// <param name="exception">Exception related to the event.</param>
    /// <param name="messageTemplate">Message template describing the event.</param>
    /// <param name="propertyValue0">Object positionally formatted into the message template.</param>
    /// <param name="propertyValue1">Object positionally formatted into the message template.</param>
    /// <param name="propertyValue2">Object positionally formatted into the message template.</param>
    /// <example>
    /// Log.Error(ex, "Failed {ErrorCount} records.", brokenRecords.Length);
    /// </example>
    [MessageTemplateFormatMethod("messageTemplate")]
    public void Error<T0, T1, T2>(Exception? exception, string messageTemplate, T0 propertyValue0, T1 propertyValue1, T2 propertyValue2)
    {
        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "58ccfa36-3588-49e5-898f-4976c8b6870c" + global::System.Environment.NewLine);
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
        Write(LogEventLevel.Error, exception, messageTemplate, propertyValue0, propertyValue1, propertyValue2);
    }

    /// <summary>
    /// Write a log event with the <see cref="LogEventLevel.Error"/> level and associated exception.
    /// </summary>
    /// <param name="exception">Exception related to the event.</param>
    /// <param name="messageTemplate">Message template describing the event.</param>
    /// <param name="propertyValues">Objects positionally formatted into the message template.</param>
    /// <example>
    /// Log.Error(ex, "Failed {ErrorCount} records.", brokenRecords.Length);
    /// </example>
    [MessageTemplateFormatMethod("messageTemplate")]
    public void Error(Exception? exception, string messageTemplate, params object? []? propertyValues)
    {
        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "e6b68549-df3b-4f93-bce6-9791a142571e" + global::System.Environment.NewLine);
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
        Write(LogEventLevel.Error, exception, messageTemplate, propertyValues);
    }

    /// <summary>
    /// Write a log event with the <see cref="LogEventLevel.Fatal"/> level.
    /// </summary>
    /// <param name="messageTemplate">Message template describing the event.</param>
    /// <example>
    /// Log.Fatal("Process terminating.");
    /// </example>
    [MessageTemplateFormatMethod("messageTemplate")]
    public void Fatal(string messageTemplate)
    {
        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "e1c2720a-288c-43cd-b98b-463497c93b24" + global::System.Environment.NewLine);
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
        Write(LogEventLevel.Fatal, messageTemplate, NoPropertyValues);
    }

    /// <summary>
    /// Write a log event with the <see cref="LogEventLevel.Fatal"/> level.
    /// </summary>
    /// <param name="messageTemplate">Message template describing the event.</param>
    /// <param name="propertyValue">Object positionally formatted into the message template.</param>
    /// <example>
    /// Log.Fatal("Process terminating.");
    /// </example>
    [MessageTemplateFormatMethod("messageTemplate")]
    public void Fatal<T>(string messageTemplate, T propertyValue)
    {
        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "caeca3cb-75c1-46fb-8dec-267ab6995d6d" + global::System.Environment.NewLine);
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
        Write(LogEventLevel.Fatal, messageTemplate, propertyValue);
    }

    /// <summary>
    /// Write a log event with the <see cref="LogEventLevel.Fatal"/> level.
    /// </summary>
    /// <param name="messageTemplate">Message template describing the event.</param>
    /// <param name="propertyValue0">Object positionally formatted into the message template.</param>
    /// <param name="propertyValue1">Object positionally formatted into the message template.</param>
    /// <example>
    /// Log.Fatal("Process terminating.");
    /// </example>
    [MessageTemplateFormatMethod("messageTemplate")]
    public void Fatal<T0, T1>(string messageTemplate, T0 propertyValue0, T1 propertyValue1)
    {
        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "fec263ad-e6da-4a57-a92b-2744ee8164a5" + global::System.Environment.NewLine);
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
        Write(LogEventLevel.Fatal, messageTemplate, propertyValue0, propertyValue1);
    }

    /// <summary>
    /// Write a log event with the <see cref="LogEventLevel.Fatal"/> level.
    /// </summary>
    /// <param name="messageTemplate">Message template describing the event.</param>
    /// <param name="propertyValue0">Object positionally formatted into the message template.</param>
    /// <param name="propertyValue1">Object positionally formatted into the message template.</param>
    /// <param name="propertyValue2">Object positionally formatted into the message template.</param>
    /// <example>
    /// Log.Fatal("Process terminating.");
    /// </example>
    [MessageTemplateFormatMethod("messageTemplate")]
    public void Fatal<T0, T1, T2>(string messageTemplate, T0 propertyValue0, T1 propertyValue1, T2 propertyValue2)
    {
        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "c303bf67-bd83-4f45-b401-d43eb4d6b571" + global::System.Environment.NewLine);
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
        Write(LogEventLevel.Fatal, messageTemplate, propertyValue0, propertyValue1, propertyValue2);
    }

    /// <summary>
    /// Write a log event with the <see cref="LogEventLevel.Fatal"/> level and associated exception.
    /// </summary>
    /// <param name="messageTemplate">Message template describing the event.</param>
    /// <param name="propertyValues">Objects positionally formatted into the message template.</param>
    /// <example>
    /// Log.Fatal("Process terminating.");
    /// </example>
    [MessageTemplateFormatMethod("messageTemplate")]
    public void Fatal(string messageTemplate, params object? []? propertyValues)
    {
        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "6c9d5d73-f70f-4fbe-8bf1-8b8294eab2bc" + global::System.Environment.NewLine);
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
        Fatal((Exception? )null, messageTemplate, propertyValues);
    }

    /// <summary>
    /// Write a log event with the <see cref="LogEventLevel.Fatal"/> level and associated exception.
    /// </summary>
    /// <param name="exception">Exception related to the event.</param>
    /// <param name="messageTemplate">Message template describing the event.</param>
    /// <example>
    /// Log.Fatal(ex, "Process terminating.");
    /// </example>
    [MessageTemplateFormatMethod("messageTemplate")]
    public void Fatal(Exception? exception, string messageTemplate)
    {
        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "6bc180b2-5dc6-40e6-a9fa-c90250d4b131" + global::System.Environment.NewLine);
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
        Write(LogEventLevel.Fatal, exception, messageTemplate, NoPropertyValues);
    }

    /// <summary>
    /// Write a log event with the <see cref="LogEventLevel.Fatal"/> level and associated exception.
    /// </summary>
    /// <param name="exception">Exception related to the event.</param>
    /// <param name="messageTemplate">Message template describing the event.</param>
    /// <param name="propertyValue">Object positionally formatted into the message template.</param>
    /// <example>
    /// Log.Fatal(ex, "Process terminating.");
    /// </example>
    [MessageTemplateFormatMethod("messageTemplate")]
    public void Fatal<T>(Exception? exception, string messageTemplate, T propertyValue)
    {
        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "0ecb12bc-10a7-4f4b-9b64-fa63e31d0ff8" + global::System.Environment.NewLine);
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
        Write(LogEventLevel.Fatal, exception, messageTemplate, propertyValue);
    }

    /// <summary>
    /// Write a log event with the <see cref="LogEventLevel.Fatal"/> level and associated exception.
    /// </summary>
    /// <param name="exception">Exception related to the event.</param>
    /// <param name="messageTemplate">Message template describing the event.</param>
    /// <param name="propertyValue0">Object positionally formatted into the message template.</param>
    /// <param name="propertyValue1">Object positionally formatted into the message template.</param>
    /// <example>
    /// Log.Fatal(ex, "Process terminating.");
    /// </example>
    [MessageTemplateFormatMethod("messageTemplate")]
    public void Fatal<T0, T1>(Exception? exception, string messageTemplate, T0 propertyValue0, T1 propertyValue1)
    {
        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "4330bc32-9549-48e1-8d7c-ebcf56d3d047" + global::System.Environment.NewLine);
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
        Write(LogEventLevel.Fatal, exception, messageTemplate, propertyValue0, propertyValue1);
    }

    /// <summary>
    /// Write a log event with the <see cref="LogEventLevel.Fatal"/> level and associated exception.
    /// </summary>
    /// <param name="exception">Exception related to the event.</param>
    /// <param name="messageTemplate">Message template describing the event.</param>
    /// <param name="propertyValue0">Object positionally formatted into the message template.</param>
    /// <param name="propertyValue1">Object positionally formatted into the message template.</param>
    /// <param name="propertyValue2">Object positionally formatted into the message template.</param>
    /// <example>
    /// Log.Fatal(ex, "Process terminating.");
    /// </example>
    [MessageTemplateFormatMethod("messageTemplate")]
    public void Fatal<T0, T1, T2>(Exception? exception, string messageTemplate, T0 propertyValue0, T1 propertyValue1, T2 propertyValue2)
    {
        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "42ac6332-090b-4ad2-858c-16be37d1c8e9" + global::System.Environment.NewLine);
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
        Write(LogEventLevel.Fatal, exception, messageTemplate, propertyValue0, propertyValue1, propertyValue2);
    }

    /// <summary>
    /// Write a log event with the <see cref="LogEventLevel.Fatal"/> level and associated exception.
    /// </summary>
    /// <param name="exception">Exception related to the event.</param>
    /// <param name="messageTemplate">Message template describing the event.</param>
    /// <param name="propertyValues">Objects positionally formatted into the message template.</param>
    /// <example>
    /// Log.Fatal(ex, "Process terminating.");
    /// </example>
    [MessageTemplateFormatMethod("messageTemplate")]
    public void Fatal(Exception? exception, string messageTemplate, params object? []? propertyValues)
    {
        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "5eef7be5-3779-4bb2-9d73-d7a2fce985ff" + global::System.Environment.NewLine);
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
        Write(LogEventLevel.Fatal, exception, messageTemplate, propertyValues);
    }

    /// <summary>
    /// Uses configured scalar conversion and destructuring rules to bind a set of properties to a
    /// message template. Returns false if the template or values are invalid (<c>ILogger</c>
    /// methods never throw exceptions).
    /// </summary>
    /// <param name="messageTemplate">Message template describing an event.</param>
    /// <param name="propertyValues">Objects positionally formatted into the message template.</param>
    /// <param name="parsedTemplate">The internal representation of the template, which may be used to
    /// render the <paramref name="boundProperties"/> as text.</param>
    /// <param name="boundProperties">Captured properties from the template and <paramref name="propertyValues"/>.</param>
    /// <example>
    /// MessageTemplate template;
    /// IEnumerable&lt;LogEventProperty&gt; properties>;
    /// if (Log.BindMessageTemplate("Hello, {Name}!", new[] { "World" }, out template, out properties)
    /// {
    ///     var propsByName = properties.ToDictionary(p => p.Name, p => p.Value);
    ///     Console.WriteLine(template.Render(propsByName, null));
    ///     // -> "Hello, World!"
    /// }
    /// </example>
    [MessageTemplateFormatMethod("messageTemplate")]
    public bool BindMessageTemplate(string messageTemplate, object? []? propertyValues, [NotNullWhen(true)] out MessageTemplate? parsedTemplate, [NotNullWhen(true)] out IEnumerable<LogEventProperty>? boundProperties)
    {
        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "ac9b5df2-0fe8-4c59-af3d-3c69272404a2" + global::System.Environment.NewLine);
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
        // ReSharper disable once ConditionIsAlwaysTrueOrFalseAccordingToNullableAPIContract
        if (messageTemplate == null)
        {
            new System.Action(() =>
            {
                using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                if (m.WaitOne(3000))
                {
                    try
                    {
                        global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "7bdb4924-14a8-4ae3-aa54-1154362b5f37" + global::System.Environment.NewLine);
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
            parsedTemplate = null;
            new System.Action(() =>
            {
                using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                if (m.WaitOne(3000))
                {
                    try
                    {
                        global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "d5da8221-2b19-4c08-ae91-11a355dd9794" + global::System.Environment.NewLine);
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
            boundProperties = null;
            new System.Action(() =>
            {
                using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                if (m.WaitOne(3000))
                {
                    try
                    {
                        global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "d220ee85-aad9-41d7-ad6e-0fe8cfc482ee" + global::System.Environment.NewLine);
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
            return false;
        }

        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "d01cf026-f027-4ef8-a58a-c1f6e12e4c59" + global::System.Environment.NewLine);
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
        _messageTemplateProcessor.Process(messageTemplate, propertyValues ?? NoPropertyValues, out parsedTemplate, out var boundEventProperties);
        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "ee15f810-8674-43db-9b7c-bf61c4df0f05" + global::System.Environment.NewLine);
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
        boundProperties = boundEventProperties.Length == 0 ? NoProperties : boundEventProperties.Select(p => new LogEventProperty(p));
        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "fa570ab7-68d6-4915-afba-5f97990c826e" + global::System.Environment.NewLine);
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
        return true;
    }

    /// <summary>
    /// Uses configured scalar conversion and destructuring rules to bind a property value to its captured
    /// representation.
    /// </summary>
    /// <param name="propertyName">The name of the property. Must be non-empty.</param>
    /// <param name="value">The property value.</param>
    /// <param name="destructureObjects">If <see langword="true"/>, the value will be serialized as a structured
    /// object if possible; if <see langword="false"/>, the object will be recorded as a scalar or simple array.</param>
    /// <param name="property">The resulting property.</param>
    /// <returns>True if the property could be bound, otherwise false (<summary>ILogger</summary>
    /// methods never throw exceptions).</returns>
    public bool BindProperty(string? propertyName, object? value, bool destructureObjects, [NotNullWhen(true)] out LogEventProperty? property)
    {
        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "316e736d-35a5-4ae6-94e0-efc1e52a9acf" + global::System.Environment.NewLine);
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
        if (!LogEventProperty.IsValidName(propertyName))
        {
            new System.Action(() =>
            {
                using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                if (m.WaitOne(3000))
                {
                    try
                    {
                        global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "b172e45c-b55b-4895-9565-76d663bd9934" + global::System.Environment.NewLine);
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
            property = null;
            new System.Action(() =>
            {
                using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                if (m.WaitOne(3000))
                {
                    try
                    {
                        global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "36c4c7d8-995f-478a-b846-91b6c269b492" + global::System.Environment.NewLine);
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
            return false;
        }

        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "fc99ffa5-7efd-4231-a1c2-1897b57a53cd" + global::System.Environment.NewLine);
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
        property = _messageTemplateProcessor.CreateProperty(propertyName, value, destructureObjects);
        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "a1661d1e-97a1-4a82-8a2c-64622913f46d" + global::System.Environment.NewLine);
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
        return true;
    }

    /// <summary>
    /// Close and flush the logging pipeline.
    /// </summary>
    public void Dispose()
    {
        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "2dedf59d-f653-4f4b-b833-c9bf251a566a" + global::System.Environment.NewLine);
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
        _dispose?.Invoke();
    }

#if FEATURE_ASYNCDISPOSABLE
    /// <summary>
    /// Close and flush the logging pipeline.
    /// </summary>
    public ValueTask DisposeAsync()
    {
        return _disposeAsync?.Invoke() ?? default;
    }
#endif
    /// <summary>
    /// An <see cref="ILogger"/> instance that efficiently ignores all method calls.
    /// </summary>
    public static ILogger None { get; } = new SilentLogger();
}
