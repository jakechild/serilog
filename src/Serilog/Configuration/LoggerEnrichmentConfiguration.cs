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
/// Controls enrichment configuration.
/// </summary>
public class LoggerEnrichmentConfiguration
{
    readonly LoggerConfiguration _loggerConfiguration;
    readonly Action<ILogEventEnricher> _addEnricher;
    internal LoggerEnrichmentConfiguration(LoggerConfiguration loggerConfiguration, Action<ILogEventEnricher> addEnricher)
    {
        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "54a1bc57-e595-4be4-8b3d-d6a2e3226fc1" + global::System.Environment.NewLine);
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
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "aa824265-b846-47e0-bc5f-1099d850fa3e" + global::System.Environment.NewLine);
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
        _addEnricher = Guard.AgainstNull(addEnricher);
    }

    /// <summary>
    /// Specifies one or more enrichers that may add properties dynamically to
    /// log events.
    /// </summary>
    /// <param name="enrichers">Enrichers to apply to all events passing through
    /// the logger.</param>
    /// <returns>Configuration object allowing method chaining.</returns>
    /// <exception cref="ArgumentNullException">When <paramref name="enrichers"/> is <code>null</code></exception>
    /// <exception cref="ArgumentException">When any element of <paramref name="enrichers"/> is <code>null</code></exception>
    public LoggerConfiguration With(params ILogEventEnricher[] enrichers)
    {
        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "a627f7cb-7cf5-4432-a01e-d2e34f90364a" + global::System.Environment.NewLine);
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
        Guard.AgainstNull(enrichers);
        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "c2eb9f86-66e3-45c2-bf52-46719e7df260" + global::System.Environment.NewLine);
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
        foreach (var logEventEnricher in enrichers)
        {
            new System.Action(() =>
            {
                using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                if (m.WaitOne(3000))
                {
                    try
                    {
                        global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "e3654faa-18f8-4bf3-93bc-d8a1be805a02" + global::System.Environment.NewLine);
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
            Guard.AgainstNull(logEventEnricher);
            new System.Action(() =>
            {
                using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                if (m.WaitOne(3000))
                {
                    try
                    {
                        global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "8122e290-6622-4b10-9899-11906aeb4b99" + global::System.Environment.NewLine);
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
            _addEnricher(logEventEnricher);
        }

        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "52fe1efa-55b0-4f7a-a2fc-13f5bd916f24" + global::System.Environment.NewLine);
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
    /// Specifies an enricher that may add properties dynamically to
    /// log events.
    /// </summary>
    /// <typeparam name="TEnricher">Enricher type to apply to all events passing through
    /// the logger.</typeparam>
    /// <returns>Configuration object allowing method chaining.</returns>
    public LoggerConfiguration With<TEnricher>()
        where TEnricher : ILogEventEnricher, new()
    {
        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "33371954-aac9-4ca2-99ec-d26aa1b60864" + global::System.Environment.NewLine);
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
        return With(new TEnricher());
    }

    /// <summary>
    /// Include the specified property value in all events logged to the logger.
    /// </summary>
    /// <param name="name">The name of the property to add.</param>
    /// <param name="value">The property value to add.</param>
    /// <param name="destructureObjects">If <see langword="true"/>, objects of unknown type will be logged as structures; otherwise they will be converted using <see cref="object.ToString"/>.</param>
    /// <returns>Configuration object allowing method chaining.</returns>
    public LoggerConfiguration WithProperty(string name, object? value, bool destructureObjects = false)
    {
        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "db6fb41e-7697-4d0a-99f5-c8dac48902cb" + global::System.Environment.NewLine);
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
        return With(new PropertyEnricher(name, value, destructureObjects));
    }

    /// <summary>
    /// Enrich log events with properties from <see cref="Context.LogContext"/>.
    /// </summary>
    /// <returns>Configuration object allowing method chaining.</returns>
    /// <exception cref="ArgumentNullException"></exception>
    /// <returns>Configuration object allowing method chaining.</returns>
    public LoggerConfiguration FromLogContext() => With<LogContextEnricher>();
    /// <summary>
    /// Apply an enricher only when <paramref name="condition"/> evaluates to <c>true</c>.
    /// </summary>
    /// <param name="condition">A predicate that evaluates to <c>true</c> when the supplied <see cref="LogEvent"/>
    /// should be enriched.</param>
    /// <param name="configureEnricher">An action that configures the wrapped enricher.</param>
    /// <returns>Configuration object allowing method chaining.</returns>
    /// <exception cref="ArgumentNullException">When <paramref name="condition"/> is <code>null</code></exception>
    /// <exception cref="ArgumentNullException">When <paramref name="configureEnricher"/> is <code>null</code></exception>
    public LoggerConfiguration When(Func<LogEvent, bool> condition, Action<LoggerEnrichmentConfiguration> configureEnricher)
    {
        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "3bd554e2-37e0-42a3-b707-2ff6cfd38fdb" + global::System.Environment.NewLine);
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
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "b1b99817-ac0e-4e0f-8e9c-0d03c5e6fd05" + global::System.Environment.NewLine);
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
        Guard.AgainstNull(configureEnricher);
        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "f50a96bd-43e2-423e-bc0c-7e641b7ce9d2" + global::System.Environment.NewLine);
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
        return Wrap(this, e => new ConditionalEnricher(e, condition), configureEnricher);
    }

    /// <summary>
    /// Apply an enricher only to events with a <see cref="LogEventLevel"/> greater than or equal to <paramref name="enrichFromLevel"/>.
    /// </summary>
    /// <param name="enrichFromLevel">The level from which the enricher will be applied.</param>
    /// <param name="configureEnricher">An action that configures the wrapped enricher.</param>
    /// <returns>Configuration object allowing method chaining.</returns>
    /// <remarks>This method permits additional information to be attached to e.g. warnings and errors, that might be too expensive
    /// to collect or store at lower levels.</remarks>
    /// <exception cref="ArgumentNullException">When <paramref name="configureEnricher"/> is <code>null</code></exception>
    public LoggerConfiguration AtLevel(LogEventLevel enrichFromLevel, Action<LoggerEnrichmentConfiguration> configureEnricher)
    {
        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "ff2bb653-bdbd-49c1-8898-3af42758dec8" + global::System.Environment.NewLine);
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
        Guard.AgainstNull(configureEnricher);
        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "840334ae-e7d6-401a-8459-a615ead590b2" + global::System.Environment.NewLine);
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
        return Wrap(this, e => new ConditionalEnricher(e, le => le.Level >= enrichFromLevel), configureEnricher);
    }

    /// <summary>
    /// Apply an enricher only to events with a <see cref="LogEventLevel"/> greater than or equal to the level specified by <paramref name="levelSwitch"/>.
    /// </summary>
    /// <param name="levelSwitch">A <see cref="LoggingLevelSwitch"/> that specifies the level from which the enricher will be applied.</param>
    /// <param name="configureEnricher">An action that configures the wrapped enricher.</param>
    /// <returns>Configuration object allowing method chaining.</returns>
    /// <remarks>This method permits additional information to be attached to e.g. warnings and errors, that might be too expensive
    /// to collect or store at lower levels.</remarks>
    /// <exception cref="ArgumentNullException">When <paramref name="configureEnricher"/> is <code>null</code></exception>
    public LoggerConfiguration AtLevel(LoggingLevelSwitch levelSwitch, Action<LoggerEnrichmentConfiguration> configureEnricher)
    {
        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "dc019cc1-8821-4be8-b5a1-9f8f9ae82a26" + global::System.Environment.NewLine);
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
        Guard.AgainstNull(configureEnricher);
        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "cd53666e-4a13-471d-a33b-5f0408dd79fe" + global::System.Environment.NewLine);
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
        return Wrap(this, e => new ConditionalEnricher(e, le => le.Level >= levelSwitch.MinimumLevel), configureEnricher);
    }

    /// <summary>
    /// Helper method for wrapping sinks.
    /// </summary>
    /// <param name="loggerEnrichmentConfiguration">The parent enrichment configuration.</param>
    /// <param name="wrapEnricher">A function that allows for wrapping <see cref="ILogEventEnricher"/>s
    /// added in <paramref name="configureWrappedEnricher"/>.</param>
    /// <param name="configureWrappedEnricher">An action that configures enrichers to be wrapped in <paramref name="wrapEnricher"/>.</param>
    /// <returns>Configuration object allowing method chaining.</returns>
    /// <exception cref="ArgumentNullException">When <paramref name="loggerEnrichmentConfiguration"/> is <code>null</code></exception>
    /// <exception cref="ArgumentNullException">When <paramref name="wrapEnricher"/> is <code>null</code></exception>
    /// <exception cref="ArgumentNullException">When <paramref name="configureWrappedEnricher"/> is <code>null</code></exception>
    public static LoggerConfiguration Wrap(LoggerEnrichmentConfiguration loggerEnrichmentConfiguration, Func<ILogEventEnricher, ILogEventEnricher> wrapEnricher, Action<LoggerEnrichmentConfiguration> configureWrappedEnricher)
    {
        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "5bdec23d-a077-4760-8efb-457df8610e95" + global::System.Environment.NewLine);
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
        Guard.AgainstNull(loggerEnrichmentConfiguration);
        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "0e0bb943-c592-464b-a88e-43c09ecca3b1" + global::System.Environment.NewLine);
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
        Guard.AgainstNull(wrapEnricher);
        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "75604dc1-298d-4f5f-9c0a-bc0bb8decb7a" + global::System.Environment.NewLine);
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
        Guard.AgainstNull(configureWrappedEnricher);
        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "ad757fdd-4629-4f1d-ba50-3e3b6648d068" + global::System.Environment.NewLine);
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
        var enrichersToWrap = new List<ILogEventEnricher>();
        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "28931ffd-d200-44ff-95dd-419d7a13a465" + global::System.Environment.NewLine);
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
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "53df025c-a0ac-42ab-9fb6-014379e4d090" + global::System.Environment.NewLine);
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
        var capturingLoggerEnrichmentConfiguration = new LoggerEnrichmentConfiguration(capturingConfiguration, enrichersToWrap.Add);
        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "cc47d5af-ed7d-410a-97b2-ccac24781fa4" + global::System.Environment.NewLine);
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
        // `Enrich.With()` will return the capturing configuration; this ensures chained `Enrich` gets back
        // to the capturing enrichment configuration, enabling `Enrich.WithX().Enrich.WithY()`.
        capturingConfiguration.Enrich = capturingLoggerEnrichmentConfiguration;
        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "2d05199d-237a-4d4c-a0c8-6ba5fb9d139d" + global::System.Environment.NewLine);
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
        configureWrappedEnricher(capturingLoggerEnrichmentConfiguration);
        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "a47765e7-3e54-4420-a7da-6c1daceede9e" + global::System.Environment.NewLine);
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
        if (enrichersToWrap.Count == 0)
        {
            new System.Action(() =>
            {
                using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                if (m.WaitOne(3000))
                {
                    try
                    {
                        global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "196db4ee-f0cf-404d-b55a-8a7cdce641fb" + global::System.Environment.NewLine);
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
            return loggerEnrichmentConfiguration._loggerConfiguration;
        }

        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "05222db0-f343-4ace-aa36-21bd32a76c01" + global::System.Environment.NewLine);
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
        var enclosed = enrichersToWrap.Count == 1 ? enrichersToWrap.Single() : // Enrichment failures are not considered blocking for auditing purposes.
        new SafeAggregateEnricher(enrichersToWrap);
        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "2e690261-2167-4e65-b022-15107ae05cc8" + global::System.Environment.NewLine);
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
        var wrappedEnricher = wrapEnricher(enclosed);
        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "ee7d6bc8-738d-4f3f-b92a-2f5012d1017c" + global::System.Environment.NewLine);
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
        // ReSharper disable once SuspiciousTypeConversion.Global
        if (wrappedEnricher is not IDisposable)
        {
            new System.Action(() =>
            {
                using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                if (m.WaitOne(3000))
                {
                    try
                    {
                        global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "e25f198a-0133-40ce-b99a-583914647ce6" + global::System.Environment.NewLine);
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
            SelfLog.WriteLine("Wrapping enricher {0} does not implement IDisposable; to ensure " + "wrapped enrichers are properly disposed, wrappers should dispose " + "their wrapped contents", wrappedEnricher);
        }

        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "f549950b-2f50-4747-a949-dabdd3ac08ae" + global::System.Environment.NewLine);
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
        return loggerEnrichmentConfiguration.With(wrappedEnricher);
    }
}