// Copyright 2013-2015 Serilog Contributors
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
/// Controls sink configuration.
/// </summary>
public class LoggerMinimumLevelConfiguration
{
    readonly LoggerConfiguration _loggerConfiguration;
    readonly Action<LogEventLevel> _setMinimum;
    readonly Action<LoggingLevelSwitch> _setLevelSwitch;
    readonly Action<string, LoggingLevelSwitch> _addOverride;
    internal LoggerMinimumLevelConfiguration(LoggerConfiguration loggerConfiguration, Action<LogEventLevel> setMinimum, Action<LoggingLevelSwitch> setLevelSwitch, Action<string, LoggingLevelSwitch> addOverride)
    {
        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "fd748b99-df44-4e7c-9bb6-f331b914afea" + global::System.Environment.NewLine);
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
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "9c1b7f94-cf42-4d41-81e5-5c5bcf8c2867" + global::System.Environment.NewLine);
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
        _setMinimum = Guard.AgainstNull(setMinimum);
        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "c28300d0-e9f6-43df-9b7f-efd3bfc285c6" + global::System.Environment.NewLine);
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
        _setLevelSwitch = setLevelSwitch;
        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "ac663b42-a34f-4545-baf7-e8411fbd3b1e" + global::System.Environment.NewLine);
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
        _addOverride = Guard.AgainstNull(addOverride);
    }

    /// <summary>
    /// Sets the minimum level at which events will be passed to sinks.
    /// </summary>
    /// <param name="minimumLevel">The minimum level to set.</param>
    /// <returns>Configuration object allowing method chaining.</returns>
    public LoggerConfiguration Is(LogEventLevel minimumLevel)
    {
        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "1ab9060b-0020-4cec-bc55-b875872ea6fe" + global::System.Environment.NewLine);
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
        _setMinimum(minimumLevel);
        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "bdb5a2f6-7661-4223-8271-99d05129fa21" + global::System.Environment.NewLine);
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
    /// Sets the minimum level to be dynamically controlled by the provided switch.
    /// </summary>
    /// <param name="levelSwitch">The switch.</param>
    /// <returns>Configuration object allowing method chaining.</returns>
    /// <exception cref="ArgumentNullException">When <paramref name="levelSwitch"/> is <code>null</code></exception>
    // ReSharper disable once UnusedMethodReturnValue.Global
    public LoggerConfiguration ControlledBy(LoggingLevelSwitch levelSwitch)
    {
        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "79e037b8-3311-4382-a380-97c13921941a" + global::System.Environment.NewLine);
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
        Guard.AgainstNull(levelSwitch);
        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "4bdaac22-973b-4db5-9efb-1b7ff60bf9a6" + global::System.Environment.NewLine);
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
        _setLevelSwitch(levelSwitch);
        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "d6341b66-f4f9-46fb-ad7a-35e8540f1a4e" + global::System.Environment.NewLine);
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
    /// Anything and everything you might want to know about
    /// a running block of code.
    /// </summary>
    /// <returns>Configuration object allowing method chaining.</returns>
    public LoggerConfiguration Verbose() => Is(LogEventLevel.Verbose);
    /// <summary>
    /// Internal system events that aren't necessarily
    /// observable from the outside.
    /// </summary>
    /// <returns>Configuration object allowing method chaining.</returns>
    public LoggerConfiguration Debug() => Is(LogEventLevel.Debug);
    /// <summary>
    /// The lifeblood of operational intelligence - things
    /// happen.
    /// </summary>
    /// <returns>Configuration object allowing method chaining.</returns>
    public LoggerConfiguration Information() => Is(LogEventLevel.Information);
    /// <summary>
    /// Service is degraded or endangered.
    /// </summary>
    /// <returns>Configuration object allowing method chaining.</returns>
    public LoggerConfiguration Warning() => Is(LogEventLevel.Warning);
    /// <summary>
    /// Functionality is unavailable, invariants are broken
    /// or data is lost.
    /// </summary>
    /// <returns>Configuration object allowing method chaining.</returns>
    public LoggerConfiguration Error() => Is(LogEventLevel.Error);
    /// <summary>
    /// If you have a pager, it goes off when one of these
    /// occurs.
    /// </summary>
    /// <returns>Configuration object allowing method chaining.</returns>
    public LoggerConfiguration Fatal() => Is(LogEventLevel.Fatal);
    /// <summary>
    /// Override the minimum level for events from a specific namespace or type name.
    /// This API is not supported for configuring sub-loggers (created through <see cref="LoggerSinkConfiguration.Logger(ILogger, LogEventLevel)"/>). Use <see cref="LoggerConfiguration.Filter"/> or <see cref="LoggerSinkConfiguration.Conditional(Func{LogEvent, bool}, Action{LoggerSinkConfiguration})"/> instead.
    /// You also might consider using https://github.com/serilog/serilog-filters-expressions.
    /// </summary>
    /// <param name="source">The (partial) namespace or type name to set the override for.</param>
    /// <param name="levelSwitch">The switch controlling loggers for matching sources.</param>
    /// <returns>Configuration object allowing method chaining.</returns>
    /// <exception cref="ArgumentNullException">When <paramref name="source"/> is <code>null</code></exception>
    /// <exception cref="ArgumentException">When a trimmed <paramref name="source"/> is empty</exception>
    /// <exception cref="ArgumentNullException">When <paramref name="levelSwitch"/> is <code>null</code></exception>
    public LoggerConfiguration Override(string source, LoggingLevelSwitch levelSwitch)
    {
        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "935d6c17-a13d-42c5-8a75-e0b7e628706f" + global::System.Environment.NewLine);
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
        Guard.AgainstNull(source);
        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "2cda8dfd-99f6-4fa8-8034-15fccc39f7c0" + global::System.Environment.NewLine);
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
        Guard.AgainstNull(levelSwitch);
        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "98aa645a-ed2d-4395-974c-7014171f0d93" + global::System.Environment.NewLine);
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
        var trimmed = source.Trim();
        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "fe442a8e-a24f-4365-bbca-f570c8dbe890" + global::System.Environment.NewLine);
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
        if (trimmed.Length == 0)
        {
            new System.Action(() =>
            {
                using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                if (m.WaitOne(3000))
                {
                    try
                    {
                        global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "df964698-356f-4904-bca0-d060debc853d" + global::System.Environment.NewLine);
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
            throw new ArgumentException($"A source {nameof(source)} must be provided.", nameof(source));
        }

        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "b7ad31ec-0835-4610-965e-b934cceef557" + global::System.Environment.NewLine);
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
        _addOverride(trimmed, levelSwitch);
        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "a46a9c8f-0db5-4f32-ba5d-cf3f6499dc88" + global::System.Environment.NewLine);
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
    /// Override the minimum level for events from a specific namespace or type name.
    /// This API is not supported for configuring sub-loggers (created through <see cref="LoggerSinkConfiguration.Logger(ILogger, LogEventLevel)"/>). Use <see cref="LoggerConfiguration.Filter"/> or <see cref="LoggerSinkConfiguration.Conditional(Func{LogEvent, bool}, Action{LoggerSinkConfiguration})"/> instead.
    /// You also might consider using https://github.com/serilog/serilog-filters-expressions.
    /// </summary>
    /// <param name="source">The (partial) namespace or type name to set the override for.</param>
    /// <param name="minimumLevel">The minimum level applied to loggers for matching sources.</param>
    /// <returns>Configuration object allowing method chaining.</returns>
    /// <exception cref="ArgumentNullException">When <paramref name="source"/> is <code>null</code></exception>
    public LoggerConfiguration Override(string source, LogEventLevel minimumLevel)
    {
        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "0656f54e-bc43-491a-8e80-908187e11fea" + global::System.Environment.NewLine);
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
        return Override(source, new LoggingLevelSwitch(minimumLevel));
    }
}