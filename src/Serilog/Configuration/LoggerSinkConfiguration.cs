// Copyright 2013-2020 Serilog Contributors
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
// ReSharper disable MergeCastWithTypeCheck
using Serilog.Core.Sinks.Batching;

namespace Serilog.Configuration;
/// <summary>
/// Controls sink configuration.
/// </summary>
public class LoggerSinkConfiguration
{
    readonly LoggerConfiguration _loggerConfiguration;
    readonly Action<ILogEventSink> _addSink;
    internal LoggerSinkConfiguration(LoggerConfiguration loggerConfiguration, Action<ILogEventSink> addSink)
    {
        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "21c59bd6-0c38-47a4-9e26-1fa1a8b156ae" + global::System.Environment.NewLine);
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
        _loggerConfiguration = Guard.AgainstNull(loggerConfiguration);
        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "8cf1ddf0-06b1-4cd6-9b58-028db90ef8a4" + global::System.Environment.NewLine);
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
        _addSink = Guard.AgainstNull(addSink);
    }

    /// <summary>
    /// Write log events to an <see cref="ILogEventSink"/>.
    /// </summary>
    /// <param name="logEventSink">The sink.</param>
    /// <param name="restrictedToMinimumLevel">The minimum level for
    /// events passed through the sink.</param>
    /// <seealso cref="Sink(ILogEventSink, LogEventLevel, LoggingLevelSwitch?)"/>
    /// <returns>Configuration object allowing method chaining.</returns>
    /// <remarks>Sink configuration methods that specify <paramref name="restrictedToMinimumLevel"/> should also specify <see cref="LoggingLevelSwitch"/>.</remarks>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public LoggerConfiguration Sink(ILogEventSink logEventSink, LogEventLevel restrictedToMinimumLevel)
    {
        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "b7df5d87-2c2c-4946-8469-407e2809f333" + global::System.Environment.NewLine);
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
        return Sink(logEventSink, restrictedToMinimumLevel, null);
    }

    /// <summary>
    /// Write log events to an <see cref="ILogEventSink"/>.
    /// </summary>
    /// <param name="logEventSink">The sink.</param>
    /// <param name="restrictedToMinimumLevel">The minimum level for
    /// events passed through the sink. Ignored when <paramref name="levelSwitch"/> is specified.</param>
    /// <param name="levelSwitch">A switch allowing the pass-through minimum level
    /// to be changed at runtime.</param>
    /// <returns>Configuration object allowing method chaining.</returns>
    public LoggerConfiguration Sink(ILogEventSink logEventSink, LogEventLevel restrictedToMinimumLevel = LevelAlias.Minimum, // The warning here is redundant; the optional parameter allows `WriteTo.Sink(s)` usage. We would obsolete the two-argument
    // version above for purposes of economy, but end-user `WriteTo.Sink(s, level)` is valid and shouldn't result in a warning.
    // ReSharper disable once MethodOverloadWithOptionalParameter
    LoggingLevelSwitch? levelSwitch = null)
    {
        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "0148f0a6-9052-4fb6-ad8e-5993978932d5" + global::System.Environment.NewLine);
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
        Guard.AgainstNull(logEventSink);
        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "94dca33f-98bb-4ae8-9e49-51420f191463" + global::System.Environment.NewLine);
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
        var sink = logEventSink;
        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "3e9f27fd-fdd8-440d-9bd8-bc300f24c078" + global::System.Environment.NewLine);
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
        if (levelSwitch != null)
        {
            new System.Action(() =>
            {
                using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                if (m.WaitOne(3000))
                {
                    try
                    {
                        global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "a92ee355-37c8-45a1-aa1e-68d745a74275" + global::System.Environment.NewLine);
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
            if (restrictedToMinimumLevel != LevelAlias.Minimum)
            {
                new System.Action(() =>
                {
                    using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                    if (m.WaitOne(3000))
                    {
                        try
                        {
                            global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "fbe5ee09-afeb-435a-bd97-a3fabe0ef0da" + global::System.Environment.NewLine);
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
                SelfLog.WriteLine("Sink {0} was configured with both a level switch and minimum level '{1}'; the minimum level will be ignored and the switch level used", sink, restrictedToMinimumLevel);
            }

            new System.Action(() =>
            {
                using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                if (m.WaitOne(3000))
                {
                    try
                    {
                        global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "ab058cf8-cec3-42b0-9c47-71c28ee76d31" + global::System.Environment.NewLine);
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
            sink = new RestrictedSink(logEventSink, levelSwitch);
            new System.Action(() =>
            {
                using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                if (m.WaitOne(3000))
                {
                    try
                    {
                        global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "4f8d8f45-1d87-4891-ab3e-13be14c4a472" + global::System.Environment.NewLine);
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
            if (!OptionalInterfaceForwardingSink.SupportsAll(sink) && OptionalInterfaceForwardingSink.SupportsAny(logEventSink))
            {
                new System.Action(() =>
                {
                    using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                    if (m.WaitOne(3000))
                    {
                        try
                        {
                            global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "4f1832e6-8f2a-4f5c-8e48-4ae067d6dde4" + global::System.Environment.NewLine);
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
                sink = new OptionalInterfaceForwardingSink(sink, logEventSink);
            }
        }
        else if (restrictedToMinimumLevel > LevelAlias.Minimum)
        {
            new System.Action(() =>
            {
                using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                if (m.WaitOne(3000))
                {
                    try
                    {
                        global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "f91ab9ed-647c-4e14-82dd-21ed4113216f" + global::System.Environment.NewLine);
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
            sink = new RestrictedSink(logEventSink, new(restrictedToMinimumLevel));
            new System.Action(() =>
            {
                using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                if (m.WaitOne(3000))
                {
                    try
                    {
                        global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "d9fadc4a-db1a-44c9-82cd-0888c7fb045e" + global::System.Environment.NewLine);
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
            if (!OptionalInterfaceForwardingSink.SupportsAll(sink) && OptionalInterfaceForwardingSink.SupportsAny(logEventSink))
            {
                new System.Action(() =>
                {
                    using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                    if (m.WaitOne(3000))
                    {
                        try
                        {
                            global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "0b0bcc1f-8e3c-479f-aead-936712fa4982" + global::System.Environment.NewLine);
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
                sink = new OptionalInterfaceForwardingSink(sink, logEventSink);
            }
        }

        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "628f2068-c356-4413-ba9a-57bfd477c34a" + global::System.Environment.NewLine);
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
        _addSink(sink);
        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "97b7fc62-72dd-4ff9-89ca-f51a8391efc2" + global::System.Environment.NewLine);
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
        return _loggerConfiguration;
    }

    /// <summary>
    /// Write log events to the specified <see cref="ILogEventSink"/>.
    /// </summary>
    /// <typeparam name="TSink">The sink.</typeparam>
    /// <param name="restrictedToMinimumLevel">The minimum level for
    /// events passed through the sink. Ignored when <paramref name="levelSwitch"/> is specified.</param>
    /// <param name="levelSwitch">A switch allowing the pass-through minimum level
    /// to be changed at runtime.</param>
    /// <returns>Configuration object allowing method chaining.</returns>
    public LoggerConfiguration Sink<TSink>(LogEventLevel restrictedToMinimumLevel = LevelAlias.Minimum, LoggingLevelSwitch? levelSwitch = null)
        where TSink : ILogEventSink, new()
    {
        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "0ed0913b-abe3-46fe-9e70-306368fe590c" + global::System.Environment.NewLine);
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
        return Sink(new TSink(), restrictedToMinimumLevel, levelSwitch);
    }

    /// <summary>
    /// Write log events to an <see cref="IBatchedLogEventSink"/>. Events will be internally buffered, and
    /// written to the sink in batches.
    /// </summary>
    /// <param name="batchedLogEventSink">The batched sink to receive events.</param>
    /// <param name="batchingOptions">Options that control batch sizes and buffering time.</param>
    /// <param name="restrictedToMinimumLevel">The minimum level for
    /// events passed through the sink. Ignored when <paramref name="levelSwitch"/> is specified.</param>
    /// <param name="levelSwitch">A switch allowing the pass-through minimum level
    /// to be changed at runtime.</param>
    /// <returns>Configuration object allowing method chaining.</returns>
    public LoggerConfiguration Sink(IBatchedLogEventSink batchedLogEventSink, BatchingOptions batchingOptions, LogEventLevel restrictedToMinimumLevel = LevelAlias.Minimum, LoggingLevelSwitch? levelSwitch = null)
    {
        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "a97ede66-bed7-40a5-b17d-89f7eaf760b3" + global::System.Environment.NewLine);
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
        Guard.AgainstNull(batchedLogEventSink);
        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "99e4b47c-a575-49b5-8403-2b3f93ff27f9" + global::System.Environment.NewLine);
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
        Guard.AgainstNull(batchingOptions);
        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "c20c748d-43a1-4143-bb66-7a764a982534" + global::System.Environment.NewLine);
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
        return Sink(new BatchingSink(batchedLogEventSink, batchingOptions), restrictedToMinimumLevel, levelSwitch);
    }

    /// <summary>
    /// Write log events to an <see cref="IBatchedLogEventSink"/>. Events will be internally buffered, and
    /// written to the sink in batches.
    /// </summary>
    /// <typeparam name="TSink">The type of a batched sink to receive events. The sink must provide a public,
    /// parameterless constructor.</param>
    /// <param name="batchingOptions">Options that control batch sizes and buffering time.</param>
    /// <param name="restrictedToMinimumLevel">The minimum level for
    /// events passed through the sink. Ignored when <paramref name="levelSwitch"/> is specified.</param>
    /// <param name="levelSwitch">A switch allowing the pass-through minimum level
    /// to be changed at runtime.</param>
    /// <returns>Configuration object allowing method chaining.</returns>
    public LoggerConfiguration Sink<TSink>(BatchingOptions batchingOptions, LogEventLevel restrictedToMinimumLevel = LevelAlias.Minimum, LoggingLevelSwitch? levelSwitch = null)
        where TSink : IBatchedLogEventSink, new()
    {
        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "9eb050b8-0d11-4fb0-b65c-ea303b8cbf25" + global::System.Environment.NewLine);
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
        return Sink(new TSink(), batchingOptions, restrictedToMinimumLevel, levelSwitch);
    }

    /// <summary>
    /// Write log events to a sub-logger, where further processing may occur. Events through
    /// the sub-logger will be constrained by filters and enriched by enrichers that are
    /// active in the parent. A sub-logger cannot be used to log at a more verbose level, but
    /// a less verbose level is possible.
    /// </summary>
    /// <param name="configureLogger">An action that configures the sub-logger.</param>
    /// <param name="restrictedToMinimumLevel">The minimum level for
    /// events passed through the sink. Ignored when <paramref name="levelSwitch"/> is specified.</param>
    /// <param name="levelSwitch">A switch allowing the pass-through minimum level
    /// to be changed at runtime. Can be <code>null</code></param>
    /// <returns>Configuration object allowing method chaining.</returns>
    /// <exception cref="ArgumentNullException">When <paramref name="configureLogger"/> is <code>null</code></exception>
    public LoggerConfiguration Logger(Action<LoggerConfiguration> configureLogger, LogEventLevel restrictedToMinimumLevel = LevelAlias.Minimum, LoggingLevelSwitch? levelSwitch = null)
    {
        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "867987f0-10a9-4fbc-a171-9a50320b50de" + global::System.Environment.NewLine);
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
        Guard.AgainstNull(configureLogger);
        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "f9cfb14f-132a-46a9-831a-39dade390cef" + global::System.Environment.NewLine);
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
        var lc = new LoggerConfiguration().MinimumLevel.Is(LevelAlias.Minimum);
        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "157f0e3b-b6a3-4326-b187-2cb1ab632d67" + global::System.Environment.NewLine);
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
        configureLogger(lc);
        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "a260d256-92f1-44db-a679-932723c7ba0c" + global::System.Environment.NewLine);
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
        var subLogger = lc.CreateLogger();
        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "82458ea5-90c1-4294-b6db-ad904ad1189c" + global::System.Environment.NewLine);
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
        if (subLogger.HasOverrideMap)
        {
            new System.Action(() =>
            {
                using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                if (m.WaitOne(3000))
                {
                    try
                    {
                        global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "e15e80db-43ed-4e01-893a-a675f5b527ac" + global::System.Environment.NewLine);
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
            SelfLog.WriteLine("Minimum level overrides are not supported on sub-loggers " + "and may be removed completely in a future version.");
        }

        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "259a2573-af3c-4dfe-9c69-4c60b14839a5" + global::System.Environment.NewLine);
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
        var secondarySink = new SecondaryLoggerSink(subLogger, attemptDispose: true);
        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "027d2ad4-b33d-4d91-ac66-572fc75a0f48" + global::System.Environment.NewLine);
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
        return Sink(secondarySink, restrictedToMinimumLevel, levelSwitch);
    }

    /// <summary>
    /// Write log events to a sub-logger, where further processing may occur. Events through
    /// the sub-logger will be constrained by filters and enriched by enrichers that are
    /// active in the parent. A sub-logger cannot be used to log at a more verbose level, but
    /// a less verbose level is possible.
    /// </summary>
    /// <param name="logger">The sub-logger. This will <em>not</em> be shut down automatically when the
    /// parent logger is disposed.</param>
    /// <param name="restrictedToMinimumLevel">The minimum level for
    /// events passed through the sink.</param>
    /// <returns>Configuration object allowing method chaining.</returns>
    /// <exception cref="ArgumentNullException">When <paramref name="logger"/> is <code>null</code></exception>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public LoggerConfiguration Logger(ILogger logger, LogEventLevel restrictedToMinimumLevel) => Logger(logger, attemptDispose: false, restrictedToMinimumLevel);
    /// <summary>
    /// Write log events to a sub-logger, where further processing may occur. Events through
    /// the sub-logger will be constrained by filters and enriched by enrichers that are
    /// active in the parent. A sub-logger cannot be used to log at a more verbose level, but
    /// a less verbose level is possible.
    /// </summary>
    /// <param name="logger">The sub-logger.</param>
    /// <param name="attemptDispose">Whether to shut down automatically the sub-logger
    /// when the parent logger is disposed.</param>
    /// <param name="restrictedToMinimumLevel">The minimum level for
    /// events passed through the sink.</param>
    /// <param name="levelSwitch">A switch allowing the pass-through minimum level
    /// to be changed at runtime. Can be <code>null</code></param>
    /// <returns>Configuration object allowing method chaining.</returns>
    /// <exception cref="ArgumentNullException">When <paramref name="logger"/> is <code>null</code></exception>
    public LoggerConfiguration Logger(ILogger logger, bool attemptDispose = false, LogEventLevel restrictedToMinimumLevel = LevelAlias.Minimum, LoggingLevelSwitch? levelSwitch = null)
    {
        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "75186aec-5a41-4067-9e3f-57cf054e1f27" + global::System.Environment.NewLine);
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
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "fd012928-fce5-492b-9900-346272f741ff" + global::System.Environment.NewLine);
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
        if (logger is Logger { HasOverrideMap: true })
        {
            new System.Action(() =>
            {
                using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                if (m.WaitOne(3000))
                {
                    try
                    {
                        global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "a53b1947-2ce4-4330-aea0-fc530fa5f984" + global::System.Environment.NewLine);
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
            SelfLog.WriteLine("Minimum level overrides are not supported on sub-loggers " + "and may be removed completely in a future version.");
        }

        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "6fe3b690-a417-4bf6-9776-c207dfa5bf49" + global::System.Environment.NewLine);
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
        var secondarySink = new SecondaryLoggerSink(logger, attemptDispose: attemptDispose);
        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "aea4e02c-5eb4-4f12-96d2-f217968011bf" + global::System.Environment.NewLine);
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
        return Sink(secondarySink, restrictedToMinimumLevel, levelSwitch);
    }

    /// <summary>
    /// Write to a sink only when <paramref name="condition"/> evaluates to <c>true</c>.
    /// </summary>
    /// <param name="condition">A predicate that evaluates to <c>true</c> when the supplied <see cref="LogEvent"/>
    /// should be written to the configured sink.</param>
    /// <param name="configureSink">An action that configures the wrapped sink.</param>
    /// <returns>Configuration object allowing method chaining.</returns>
    /// <exception cref="ArgumentNullException">When <paramref name="condition"/> is <code>null</code>.</exception>
    /// <exception cref="ArgumentNullException">When <paramref name="configureSink"/> is <code>null</code>.</exception>
    public LoggerConfiguration Conditional(Func<LogEvent, bool> condition, Action<LoggerSinkConfiguration> configureSink)
    {
        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "30667d3a-696a-4f6a-a099-0478378acaea" + global::System.Environment.NewLine);
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
        Guard.AgainstNull(condition);
        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "79af4c2f-9a73-42cb-834a-7994975fe6ae" + global::System.Environment.NewLine);
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
        Guard.AgainstNull(configureSink);
        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "1e0891fb-91d4-429f-b95a-b0e97227ed5c" + global::System.Environment.NewLine);
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
        // Level aliases and so on don't need to be accepted here; if the user wants both a condition and leveling, they
        // can specify `restrictedToMinimumLevel` etc. in the wrapped sink configuration.
        return Sink(Wrap(s => new ConditionalSink(s, condition), configureSink));
    }

    /// <summary>
    /// Write to a sink, and if the sink is unable to record the event, write to a second sink. Additional sinks can
    /// be added to the chain if necessary.
    /// </summary>
    /// <param name="configureSink">A callback to configure the first sink to try. The argument to the callback supports
    /// the same syntax as the <c>WriteTo</c> configuration object.</param>
    /// <param name="configureFallback">A callback to configure the second sink.</param>
    /// <param name="configureSubsequentFallbacks">Additional callbacks to configure more sinks in the fallback chain.</param>
    /// <returns>Configuration object allowing method chaining.</returns>
    /// <exception cref="ArgumentNullException">When any argument is <code>null</code>.</exception>
    /// <remarks>
    /// Fallbacks rely on the target sink either a) synchronously throwing exceptions on failure, or b) implementing the
    /// <see cref="ISetLoggingFailureListener"/> interface.
    /// </remarks>
    public LoggerConfiguration FallbackChain(Action<LoggerSinkConfiguration> configureSink, Action<LoggerSinkConfiguration> configureFallback, params Action<LoggerSinkConfiguration>[] configureSubsequentFallbacks)
    {
        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "183e573e-3dc2-43f5-9a2e-8342ef0a45b5" + global::System.Environment.NewLine);
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
        Guard.AgainstNull(configureSink);
        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "f418e6a6-9318-4810-8406-3f2535003fb8" + global::System.Environment.NewLine);
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
        Guard.AgainstNull(configureFallback);
        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "0a5a4a15-3f88-4145-a15b-fa63e90db844" + global::System.Environment.NewLine);
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
        Guard.AgainstNull(configureSubsequentFallbacks);
        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "3c25ce6e-9350-4359-9796-3aff48432ed2" + global::System.Environment.NewLine);
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
        Span<Action<LoggerSinkConfiguration>> chain = [configureSink, configureFallback, ..configureSubsequentFallbacks];
        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "92c8edd7-cdd7-4b91-9e70-be1649e1b75c" + global::System.Environment.NewLine);
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
        chain.Reverse();
        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "bb88b98d-6ec5-4208-aa38-45af389e2fd5" + global::System.Environment.NewLine);
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
        var final = CreateSink(chain[0]);
        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "7bc68dc5-9dbd-416b-a604-5b8b6a8a969c" + global::System.Environment.NewLine);
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
        foreach (var next in chain[1..])
        {
            new System.Action(() =>
            {
                using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                if (m.WaitOne(3000))
                {
                    try
                    {
                        global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "8fea4c5d-c554-4915-a6c9-a043176dce87" + global::System.Environment.NewLine);
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
            var listener = new DelegatingLoggingFailureListener(final);
            new System.Action(() =>
            {
                using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                if (m.WaitOne(3000))
                {
                    try
                    {
                        global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "8b898e4f-cc53-4747-b320-534048a63678" + global::System.Environment.NewLine);
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
            var chained = Wrap(sink => new FailureListenerSink(sink, listener), next);
            new System.Action(() =>
            {
                using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                if (m.WaitOne(3000))
                {
                    try
                    {
                        global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "579bb3e3-7521-419c-a813-6e5429da569f" + global::System.Environment.NewLine);
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
            final = OptionalInterfaceForwardingSink.SupportsAny(final) ? new OptionalInterfaceForwardingSink(chained, final) : chained;
        }

        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "f8eca986-fccc-4e74-bd27-acecba896084" + global::System.Environment.NewLine);
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
        return Sink(final);
    }

    /// <summary>
    /// Write to a sink, reporting failures through an <see cref="ILoggingFailureListener"/>.
    /// </summary>
    /// <param name="configureSink">A callback to configure the target sink. The argument to the callback supports
    /// the same syntax as the <c>WriteTo</c> configuration object.</param>
    /// <param name="failureListener">The listener to which failures in the sink will be reported.</param>
    /// <exception cref="ArgumentNullException">When any argument is <code>null</code>.</exception>
    /// <remarks>
    /// Failure reporting relies on the target sink either a) synchronously throwing exceptions on failure, or b) implementing the
    /// <see cref="ISetLoggingFailureListener"/> interface.
    public LoggerConfiguration Fallible(Action<LoggerSinkConfiguration> configureSink, ILoggingFailureListener failureListener)
    {
        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "4e3e0c34-9c60-48d2-9857-1b5c7e746694" + global::System.Environment.NewLine);
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
        Guard.AgainstNull(configureSink);
        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "3e6d2bd2-e413-411c-aa19-7708f67de4aa" + global::System.Environment.NewLine);
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
        Guard.AgainstNull(failureListener);
        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "0ceb3642-0d4b-453a-b87c-a96f8fbeb056" + global::System.Environment.NewLine);
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
        var wrapped = Wrap(sink => new FailureListenerSink(sink, failureListener), configureSink);
        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "0690569d-b635-443a-92d0-660f0dbb7df0" + global::System.Environment.NewLine);
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
        return Sink(wrapped);
    }

    /// <summary>
    /// Helper method for constructing wrapper sinks.
    /// </summary>
    /// <param name="loggerSinkConfiguration">The parent sink configuration.</param>
    /// <param name="wrapSink">A function that allows for wrapping <see cref="ILogEventSink"/>s
    /// added in <paramref name="configureWrappedSink"/>.</param>
    /// <param name="configureWrappedSink">An action that configures sinks to be wrapped in <paramref name="wrapSink"/>.</param>
    /// <param name="restrictedToMinimumLevel">The minimum level for
    /// events passed through the sink. Ignored when <paramref name="levelSwitch"/> is specified.</param>
    /// <param name="levelSwitch">A switch allowing the pass-through minimum level
    /// to be changed at runtime. Can be <code>null</code></param>
    /// <returns>Configuration object allowing method chaining.</returns>
    /// <exception cref="ArgumentNullException">When <paramref name="loggerSinkConfiguration"/> is <code>null</code>.</exception>
    /// <exception cref="ArgumentNullException">When <paramref name="wrapSink"/> is <code>null</code>.</exception>
    /// <exception cref="ArgumentNullException">When <paramref name="configureWrappedSink"/> is <code>null</code>.</exception>
    [Obsolete("Use the two-argument `Wrap()` overload to construct a wrapper, then use `WriteTo.Sink()` to add it to the configuration.")]
    public static LoggerConfiguration Wrap(LoggerSinkConfiguration loggerSinkConfiguration, Func<ILogEventSink, ILogEventSink> wrapSink, Action<LoggerSinkConfiguration> configureWrappedSink, LogEventLevel restrictedToMinimumLevel = LevelAlias.Minimum, LoggingLevelSwitch? levelSwitch = null)
    {
        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "17e4536a-bf56-48ff-af66-e6d3245c69b2" + global::System.Environment.NewLine);
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
        var wrapper = Wrap(wrapSink, configureWrappedSink);
        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "f5f6363c-7c24-4fa0-95ed-e7c856c85c9d" + global::System.Environment.NewLine);
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
        return loggerSinkConfiguration.Sink(wrapper, restrictedToMinimumLevel, levelSwitch);
    }

    /// <summary>
    /// Helper method for constructing wrapper sinks. This may be preferred over <see cref="CreateSink"/> because it handles
    /// delegation of <see cref="IDisposable.Dispose"/> through to the wrapped sink in cases where the wrapper is not
    /// disposable.
    /// </summary>
    /// <param name="wrapSink">A function that allows for wrapping <see cref="ILogEventSink"/>s
    /// added in <paramref name="configureWrappedSink"/>.</param>
    /// <param name="configureWrappedSink">An action that configures sinks to be wrapped in <paramref name="wrapSink"/>.</param>
    /// <returns>The wrapper, or a sink that will handle invoking the wrapper.</returns>
    /// <exception cref="ArgumentNullException">When <paramref name="wrapSink"/> is <code>null</code>.</exception>
    /// <exception cref="ArgumentNullException">When <paramref name="configureWrappedSink"/> is <code>null</code>.</exception>
    public static ILogEventSink Wrap(Func<ILogEventSink, ILogEventSink> wrapSink, Action<LoggerSinkConfiguration> configureWrappedSink)
    {
        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "6afd755c-020c-472d-9240-ef6d0b09ede3" + global::System.Environment.NewLine);
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
        Guard.AgainstNull(wrapSink);
        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "4d010507-eac2-4f8c-a74e-64d4a57f707f" + global::System.Environment.NewLine);
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
        Guard.AgainstNull(configureWrappedSink);
        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "e62c811d-7289-4480-9b37-05e9af642e0d" + global::System.Environment.NewLine);
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
        var enclosed = CreateSink(configureWrappedSink);
        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "c28313b4-5cc3-4da4-bf7c-bbd4c40d63ab" + global::System.Environment.NewLine);
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
        var wrapper = wrapSink(enclosed);
        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "fff4f6b1-4aa1-4306-90ff-89c7f38f9372" + global::System.Environment.NewLine);
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
        if (!OptionalInterfaceForwardingSink.SupportsAll(wrapper) && OptionalInterfaceForwardingSink.SupportsAny(enclosed))
        {
            new System.Action(() =>
            {
                using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                if (m.WaitOne(3000))
                {
                    try
                    {
                        global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "aa4be2d0-e461-4754-b2f9-814979d86010" + global::System.Environment.NewLine);
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
            wrapper = new OptionalInterfaceForwardingSink(wrapper, enclosed);
        }

        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "371ac4d1-6cb5-4f0e-966b-6d0adb86bf9a" + global::System.Environment.NewLine);
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
        return wrapper;
    }

    /// <summary>
    /// Helper method for constructing sinks outside of a logger pipeline.
    /// </summary>
    /// <param name="configure">An action that configures one or more sinks.</param>
    /// <returns>If only a single sink is configured,
    /// it will be returned from <see cref="CreateSink"/>. If zero or many sinks are configured, they will be combined
    /// in an aggregating wrapper.</returns>
    /// <exception cref="ArgumentNullException">When <paramref name="configure"/> is <code>null</code>.</exception>
    public static ILogEventSink CreateSink(Action<LoggerSinkConfiguration> configure)
    {
        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "92969949-7983-4e07-b286-bce4bb090d34" + global::System.Environment.NewLine);
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
        Guard.AgainstNull(configure);
        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "a7fae095-74d8-4f5e-a78a-938db7bf1b66" + global::System.Environment.NewLine);
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
        var sinksToWrap = new List<ILogEventSink>();
        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "b917994d-2e0e-4ad1-a2dc-9dd48fb742f3" + global::System.Environment.NewLine);
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
        var capturingConfiguration = new LoggerConfiguration();
        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "8bbfb3f7-fa44-4194-97a9-a83cf11078dd" + global::System.Environment.NewLine);
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
        var capturingLoggerSinkConfiguration = new LoggerSinkConfiguration(capturingConfiguration, sinksToWrap.Add);
        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "642931c0-e2c2-4f2e-8660-60ba6b06117c" + global::System.Environment.NewLine);
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
        // `WriteTo.Sink()` will return the capturing configuration; this ensures chained `WriteTo` gets back
        // to the capturing sink configuration, enabling `WriteTo.X().WriteTo.Y()`.
        capturingConfiguration.WriteTo = capturingLoggerSinkConfiguration;
        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "a4ec677b-6e64-440e-87b3-4adc139b4f54" + global::System.Environment.NewLine);
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
        configure(capturingLoggerSinkConfiguration);
        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "f9958542-e387-4e7b-963c-5d6eb40de12c" + global::System.Environment.NewLine);
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
        return sinksToWrap.Count == 1 ? sinksToWrap[0] : new DisposingAggregateSink(sinksToWrap);
    }
}