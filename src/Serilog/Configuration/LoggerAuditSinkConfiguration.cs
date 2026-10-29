// Copyright 2016-2020 Serilog Contributors
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
namespace Serilog.Configuration;
/// <summary>
/// Controls audit sink configuration.
/// </summary>
public class LoggerAuditSinkConfiguration
{
    readonly LoggerSinkConfiguration _sinkConfiguration;
    internal LoggerAuditSinkConfiguration(LoggerConfiguration loggerConfiguration, Action<ILogEventSink> addSink)
    {
        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "7134c973-bf1e-4ce3-aff0-7452d26de331" + global::System.Environment.NewLine);
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
        _sinkConfiguration = new(loggerConfiguration, addSink);
    }

    /// <summary>
    /// Audit log events to the specified <see cref="ILogEventSink"/>.
    /// </summary>
    /// <param name="logEventSink">The sink.</param>
    /// <param name="restrictedToMinimumLevel">The minimum level for
    /// events passed through the sink. Ignored when <paramref name="levelSwitch"/> is specified.</param>
    /// <param name="levelSwitch">A switch allowing the pass-through minimum level
    /// to be changed at runtime.</param>
    /// <returns>Configuration object allowing method chaining.</returns>
    public LoggerConfiguration Sink(ILogEventSink logEventSink, LogEventLevel restrictedToMinimumLevel = LevelAlias.Minimum, // ReSharper disable once MethodOverloadWithOptionalParameter
    LoggingLevelSwitch? levelSwitch = null)
    {
        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "e76dc2f6-f739-49c4-8541-a4b3fb2e1a19" + global::System.Environment.NewLine);
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
        return _sinkConfiguration.Sink(logEventSink, restrictedToMinimumLevel, levelSwitch);
    }

    /// <summary>
    /// Audit log events to the specified <see cref="ILogEventSink"/>.
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
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "7a426fb4-f991-4107-b2ca-5e66be2d8706" + global::System.Environment.NewLine);
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
        return _sinkConfiguration.Sink<TSink>(restrictedToMinimumLevel, levelSwitch);
    }

    /// <summary>
    /// Audit log events to a sub-logger, where further processing may occur. Events through
    /// the sub-logger will be constrained by filters and enriched by enrichers that are
    /// active in the parent. A sub-logger cannot be used to log at a more verbose level, but
    /// a less verbose level is possible.
    /// </summary>
    /// <param name="configureLogger">An action that configures the sub-logger.</param>
    /// <param name="restrictedToMinimumLevel">The minimum level for
    /// events passed through the sink. Ignored when <paramref name="levelSwitch"/> is specified.</param>
    /// <param name="levelSwitch">A switch allowing the pass-through minimum level
    /// to be changed at runtime.</param>
    /// <returns>Configuration object allowing method chaining.</returns>
    public LoggerConfiguration Logger(Action<LoggerConfiguration> configureLogger, LogEventLevel restrictedToMinimumLevel = LevelAlias.Minimum, LoggingLevelSwitch? levelSwitch = null)
    {
        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "ec528bd8-6c52-4374-9498-4b02a3280a98" + global::System.Environment.NewLine);
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
        return _sinkConfiguration.Logger(configureLogger, restrictedToMinimumLevel, levelSwitch);
    }

    /// <summary>
    /// Audit log events to a sub-logger, where further processing may occur. Events through
    /// the sub-logger will be constrained by filters and enriched by enrichers that are
    /// active in the parent. A sub-logger cannot be used to log at a more verbose level, but
    /// a less verbose level is possible.
    /// </summary>
    /// <param name="logger">The sub-logger. This will <em>not</em> be shut down automatically when the
    /// parent logger is disposed.</param>
    /// <param name="restrictedToMinimumLevel">The minimum level for
    /// events passed through the sink.</param>
    /// <returns>Configuration object allowing method chaining.</returns>
    public LoggerConfiguration Logger(ILogger logger, LogEventLevel restrictedToMinimumLevel = LevelAlias.Minimum)
    {
        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "43821830-c6d7-4dc8-8773-dc5be9e8f49b" + global::System.Environment.NewLine);
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
        return _sinkConfiguration.Logger(logger, restrictedToMinimumLevel);
    }
}