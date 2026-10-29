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
namespace Serilog;
/// <summary>
/// Configuration object for creating <see cref="ILogger"/> instances.
/// </summary>
public class LoggerConfiguration
{
    readonly List<ILogEventSink> _logEventSinks = [];
    readonly List<ILogEventSink> _auditSinks = [];
    readonly List<ILogEventEnricher> _enrichers = [];
    readonly List<ILogEventFilter> _filters = [];
    readonly List<Type> _additionalScalarTypes = [];
    readonly HashSet<Type> _additionalDictionaryTypes = [];
    readonly List<IDestructuringPolicy> _additionalDestructuringPolicies = [];
    readonly Dictionary<string, LoggingLevelSwitch> _overrides = new();
    LogEventLevel _minimumLevel = LogEventLevel.Information;
    LoggingLevelSwitch? _levelSwitch;
    int _maximumDestructuringDepth = 10;
    int _maximumStringLength = int.MaxValue;
    int _maximumCollectionCount = int.MaxValue;
    bool _loggerCreated;
    /// <summary>
    /// Construct a <see cref="LoggerConfiguration"/>.
    /// </summary>
    public LoggerConfiguration()
    {
        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "6ae6cf58-f380-486b-9282-71df6df08e08" + global::System.Environment.NewLine);
                }
                catch
                {
                }
                finally
                {
                    m.ReleaseMutex();
                }
            }
        })();
        WriteTo = new(this, s => _logEventSinks.Add(s));
        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "8c176bde-1c05-4928-855a-c2dc5d849803" + global::System.Environment.NewLine);
                }
                catch
                {
                }
                finally
                {
                    m.ReleaseMutex();
                }
            }
        })();
        Enrich = new(this, e => _enrichers.Add(e));
    }

    /// <summary>
    /// Configures the sinks that log events will be emitted to.
    /// </summary>
    public LoggerSinkConfiguration WriteTo { get; internal set; }
    /// <summary>
    /// Configures sinks for auditing, instead of regular (safe) logging. When auditing is used,
    /// exceptions from sinks and any intermediate filters propagate back to the caller. Most callers
    /// should use <see cref="WriteTo"/> instead.
    /// </summary>
    /// <remarks>
    /// Not all sinks are compatible with transactional auditing requirements (many will use asynchronous
    /// batching to improve write throughput and latency). Sinks need to opt-in to auditing support by
    /// extending <see cref="LoggerAuditSinkConfiguration"/>, though the generic <see cref="LoggerAuditSinkConfiguration.Sink"/>
    /// method allows any sink class to be adapted for auditing.
    /// </remarks>
    public LoggerAuditSinkConfiguration AuditTo => new(this, s => _auditSinks.Add(s));

    /// <summary>
    /// Configures the minimum level at which events will be passed to sinks. If
    /// not specified, only events at the <see cref="LogEventLevel.Information"/>
    /// level and above will be passed through.
    /// </summary>
    /// <returns>Configuration object allowing method chaining.</returns>
    public LoggerMinimumLevelConfiguration MinimumLevel
    {
        get
        {
            new System.Action(() =>
            {
                using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                if (m.WaitOne(3000))
                {
                    try
                    {
                        global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "066ba19b-3a09-45e2-be0a-aa12da345ec1" + global::System.Environment.NewLine);
                    }
                    catch
                    {
                    }
                    finally
                    {
                        m.ReleaseMutex();
                    }
                }
            })();
            return new(this, l =>
            {
                new System.Action(() =>
                {
                    using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                    if (m.WaitOne(3000))
                    {
                        try
                        {
                            global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "a0993465-d74d-4498-a9af-234a7149ce3f" + global::System.Environment.NewLine);
                        }
                        catch
                        {
                        }
                        finally
                        {
                            m.ReleaseMutex();
                        }
                    }
                })();
                _minimumLevel = l;
                new System.Action(() =>
                {
                    using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                    if (m.WaitOne(3000))
                    {
                        try
                        {
                            global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "e9d263c3-e9d4-4883-ac10-67c276f1c93d" + global::System.Environment.NewLine);
                        }
                        catch
                        {
                        }
                        finally
                        {
                            m.ReleaseMutex();
                        }
                    }
                })();
                _levelSwitch = null;
            }, sw => _levelSwitch = sw, (s, lls) => _overrides[s] = lls);
        }
    }

    /// <summary>
    /// Configures enrichment of <see cref="LogEvent"/>s. Enrichers can add, remove and
    /// modify the properties associated with events.
    /// </summary>
    public LoggerEnrichmentConfiguration Enrich { get; internal set; }
    /// <summary>
    /// Configures global filtering of <see cref="LogEvent"/>s.
    /// </summary>
    public LoggerFilterConfiguration Filter => new(this, f => _filters.Add(f));

    /// <summary>
    /// Configures destructuring of message template parameters.
    /// </summary>
    public LoggerDestructuringConfiguration Destructure
    {
        get
        {
            new System.Action(() =>
            {
                using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                if (m.WaitOne(3000))
                {
                    try
                    {
                        global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "28a67fef-f3f7-479c-8a71-de720ce1822d" + global::System.Environment.NewLine);
                    }
                    catch
                    {
                    }
                    finally
                    {
                        m.ReleaseMutex();
                    }
                }
            })();
            return new(this, _additionalScalarTypes.Add, type => _additionalDictionaryTypes.Add(type), _additionalDestructuringPolicies.Add, depth => _maximumDestructuringDepth = depth, length => _maximumStringLength = length, count => _maximumCollectionCount = count);
        }
    }

    /// <summary>
    /// Apply external settings to the logger configuration.
    /// </summary>
    public LoggerSettingsConfiguration ReadFrom => new(this);

    /// <summary>
    /// Create a logger using the configured sinks, enrichers and minimum level.
    /// </summary>
    /// <returns>The logger.</returns>
    /// <remarks>To free resources held by sinks ahead of program shutdown,
    /// the returned logger may be cast to <see cref="IDisposable"/> and
    /// disposed.</remarks>
    /// <exception cref="InvalidOperationException">When the logger is already created</exception>
    public Logger CreateLogger()
    {
        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "a4a28efc-b439-4a62-ac96-069234296ed3" + global::System.Environment.NewLine);
                }
                catch
                {
                }
                finally
                {
                    m.ReleaseMutex();
                }
            }
        })();
        if (_loggerCreated)
        {
            new System.Action(() =>
            {
                using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                if (m.WaitOne(3000))
                {
                    try
                    {
                        global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "38182de5-72a9-4f25-a946-40d7884da8da" + global::System.Environment.NewLine);
                    }
                    catch
                    {
                    }
                    finally
                    {
                        m.ReleaseMutex();
                    }
                }
            })();
            throw new InvalidOperationException("CreateLogger() was previously called and can only be called once.");
        }

        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "57014e37-266e-4791-bfe7-79df663e3d48" + global::System.Environment.NewLine);
                }
                catch
                {
                }
                finally
                {
                    m.ReleaseMutex();
                }
            }
        })();
        _loggerCreated = true;
        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "149b01ea-7ad7-4648-b299-2a1ce727d5f4" + global::System.Environment.NewLine);
                }
                catch
                {
                }
                finally
                {
                    m.ReleaseMutex();
                }
            }
        })();
        ILogEventSink? sink = null;
        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "14523784-f54c-4bca-bb8a-e4c67ec0ccc8" + global::System.Environment.NewLine);
                }
                catch
                {
                }
                finally
                {
                    m.ReleaseMutex();
                }
            }
        })();
        if (_logEventSinks.Count > 0)
        {
            new System.Action(() =>
            {
                using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                if (m.WaitOne(3000))
                {
                    try
                    {
                        global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "6a4cab2f-2aa0-4e7f-b28e-010f19f0c81f" + global::System.Environment.NewLine);
                    }
                    catch
                    {
                    }
                    finally
                    {
                        m.ReleaseMutex();
                    }
                }
            })();
            sink = new SafeAggregateSink(_logEventSinks);
        }

        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "d4dfd644-3336-41b8-bfb2-1f3a3b81a10d" + global::System.Environment.NewLine);
                }
                catch
                {
                }
                finally
                {
                    m.ReleaseMutex();
                }
            }
        })();
        var auditing = _auditSinks.Any();
        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "151787d1-3150-470e-a80f-e9abe2ad92de" + global::System.Environment.NewLine);
                }
                catch
                {
                }
                finally
                {
                    m.ReleaseMutex();
                }
            }
        })();
        if (auditing)
        {
            new System.Action(() =>
            {
                using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                if (m.WaitOne(3000))
                {
                    try
                    {
                        global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "622aa2fa-9fe1-4d52-8589-5f3f2224d344" + global::System.Environment.NewLine);
                    }
                    catch
                    {
                    }
                    finally
                    {
                        m.ReleaseMutex();
                    }
                }
            })();
            sink = new AggregateSink(sink == null ? _auditSinks : new[] { sink }.Concat(_auditSinks));
        }

        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "e02621a5-b916-4b15-a867-25245259f3d7" + global::System.Environment.NewLine);
                }
                catch
                {
                }
                finally
                {
                    m.ReleaseMutex();
                }
            }
        })();
        sink ??= new SafeAggregateSink(Array.Empty<ILogEventSink>());
        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "84f47410-faee-42af-a193-8196fdbb6b19" + global::System.Environment.NewLine);
                }
                catch
                {
                }
                finally
                {
                    m.ReleaseMutex();
                }
            }
        })();
        if (_filters.Any())
        {
            new System.Action(() =>
            {
                using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                if (m.WaitOne(3000))
                {
                    try
                    {
                        global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "8726df08-971e-48e4-a198-78de610239a2" + global::System.Environment.NewLine);
                    }
                    catch
                    {
                    }
                    finally
                    {
                        m.ReleaseMutex();
                    }
                }
            })();
            // A throwing filter could drop an auditable event, so exceptions in filters must be propagated
            // if auditing is used.
            sink = new FilteringSink(sink, _filters, auditing);
        }

        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "7650b4b9-5876-432f-852c-35d5ba9720db" + global::System.Environment.NewLine);
                }
                catch
                {
                }
                finally
                {
                    m.ReleaseMutex();
                }
            }
        })();
        var converter = new PropertyValueConverter(_maximumDestructuringDepth, _maximumStringLength, _maximumCollectionCount, _additionalScalarTypes, _additionalDictionaryTypes, _additionalDestructuringPolicies, auditing);
        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "205a809f-fd60-4bd8-8445-98a776cd2342" + global::System.Environment.NewLine);
                }
                catch
                {
                }
                finally
                {
                    m.ReleaseMutex();
                }
            }
        })();
        var processor = new MessageTemplateProcessor(converter);
        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "6a54b359-f2a3-4d2e-b41a-9830e45e81ad" + global::System.Environment.NewLine);
                }
                catch
                {
                }
                finally
                {
                    m.ReleaseMutex();
                }
            }
        })();
        var enricher = _enrichers.Count switch
        {
            // Should be a rare case, so no problem making that extra interface dispatch.
            0 => new EmptyEnricher(),
            1 => _enrichers[0],
            // Enrichment failures are not considered blocking for auditing purposes.
            _ => new SafeAggregateEnricher(_enrichers)};
        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "00190d9f-52c0-4a7c-bf6d-0b5f6ecbd4b6" + global::System.Environment.NewLine);
                }
                catch
                {
                }
                finally
                {
                    m.ReleaseMutex();
                }
            }
        })();
        LevelOverrideMap? overrideMap = null;
        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "4e962f92-aa37-4632-9916-3cfe66d43626" + global::System.Environment.NewLine);
                }
                catch
                {
                }
                finally
                {
                    m.ReleaseMutex();
                }
            }
        })();
        if (_overrides.Count != 0)
        {
            new System.Action(() =>
            {
                using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                if (m.WaitOne(3000))
                {
                    try
                    {
                        global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "010ce2af-f0fa-4463-b48b-f3691f94f23f" + global::System.Environment.NewLine);
                    }
                    catch
                    {
                    }
                    finally
                    {
                        m.ReleaseMutex();
                    }
                }
            })();
            overrideMap = new(_overrides, _minimumLevel, _levelSwitch);
        }

        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "002ea7a2-2176-4f34-9ed9-7cfe0b650a8b" + global::System.Environment.NewLine);
                }
                catch
                {
                }
                finally
                {
                    m.ReleaseMutex();
                }
            }
        })();
        var disposableSinks = _logEventSinks.Concat(_auditSinks).Where(s => s is IDisposable
#if FEATURE_ASYNCDISPOSABLE
                or IAsyncDisposable
#endif
        ).ToArray();
        void Dispose()
        {
            new System.Action(() =>
            {
                using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                if (m.WaitOne(3000))
                {
                    try
                    {
                        global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "620160e6-6cf2-45d0-b0a1-443ce5c32d12" + global::System.Environment.NewLine);
                    }
                    catch
                    {
                    }
                    finally
                    {
                        m.ReleaseMutex();
                    }
                }
            })();
            foreach (var disposable in disposableSinks)
            {
                new System.Action(() =>
                {
                    using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                    if (m.WaitOne(3000))
                    {
                        try
                        {
                            global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "cb01ce09-9de7-4fb3-a300-b669079c16b1" + global::System.Environment.NewLine);
                        }
                        catch
                        {
                        }
                        finally
                        {
                            m.ReleaseMutex();
                        }
                    }
                })();
                (disposable as IDisposable)?.Dispose();
            }
        }

        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "2a412ecb-550f-4095-9f11-1ddc01ba2d74" + global::System.Environment.NewLine);
                }
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
        async ValueTask DisposeAsync()
        {
            foreach (var disposable in disposableSinks)
            {
                if (disposable is IAsyncDisposable asyncDisposable)
                {
                    await asyncDisposable.DisposeAsync().ConfigureAwait(false);
                }
                else
                {
                    ((IDisposable)disposable).Dispose();
                }
            }
        }
#endif
        SelfMetrics.PipelineCreated.Add(1);
        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "357e545e-7b50-4da4-b53d-0f0cb83746ae" + global::System.Environment.NewLine);
                }
                catch
                {
                }
                finally
                {
                    m.ReleaseMutex();
                }
            }
        })();
        return new(processor, _levelSwitch != null ? LevelAlias.Minimum : _minimumLevel, _levelSwitch, sink, enricher, Dispose, 
#if FEATURE_ASYNCDISPOSABLE
            DisposeAsync,
#endif
        overrideMap);
    }
}