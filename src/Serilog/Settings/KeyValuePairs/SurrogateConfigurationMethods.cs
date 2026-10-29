// Copyright 2013-2018 Serilog Contributors
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
namespace Serilog.Settings.KeyValuePairs;
/// <summary>
/// Contains "fake extension" methods for the Serilog configuration API.
/// By default the settings knows how to find extension methods, but some configuration
/// are actually "regular" method calls and would not be found otherwise.
///
/// This static class contains internal methods that can be used instead.
///
/// See also <seealso cref="CallableConfigurationMethodFinder"/>
/// </summary>
static class SurrogateConfigurationMethods
{
    static readonly Dictionary<Type, MethodInfo[]> SurrogateMethodCandidates = typeof(SurrogateConfigurationMethods).GetTypeInfo().DeclaredMethods.GroupBy(m => m.GetParameters().First().ParameterType).ToDictionary(g => g.Key, g => g.ToArray());
    internal static readonly MethodInfo[] WriteTo = SurrogateMethodCandidates[typeof(LoggerSinkConfiguration)];
    internal static readonly MethodInfo[] AuditTo = SurrogateMethodCandidates[typeof(LoggerAuditSinkConfiguration)];
    internal static readonly MethodInfo[] Enrich = SurrogateMethodCandidates[typeof(LoggerEnrichmentConfiguration)];
    internal static readonly MethodInfo[] Destructure = SurrogateMethodCandidates[typeof(LoggerDestructuringConfiguration)];
    internal static readonly MethodInfo[] Filter = SurrogateMethodCandidates[typeof(LoggerFilterConfiguration)];
    internal static LoggerConfiguration Sink(LoggerSinkConfiguration loggerSinkConfiguration, ILogEventSink sink, LogEventLevel restrictedToMinimumLevel = LevelAlias.Minimum, LoggingLevelSwitch? levelSwitch = null)
    {
        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "05ad75af-7ab9-4ddb-b7ee-1ad348be8e98" + global::System.Environment.NewLine);
                }
                catch
                {
                }
                finally
                {
                    m.ReleaseMutex();
                }
            }
        })();
        return loggerSinkConfiguration.Sink(sink, restrictedToMinimumLevel, levelSwitch);
    }

    internal static LoggerConfiguration Sink(LoggerAuditSinkConfiguration auditSinkConfiguration, ILogEventSink sink, LogEventLevel restrictedToMinimumLevel = LevelAlias.Minimum, LoggingLevelSwitch? levelSwitch = null)
    {
        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "fdeb6810-c906-4c2a-89d6-bca30164e074" + global::System.Environment.NewLine);
                }
                catch
                {
                }
                finally
                {
                    m.ReleaseMutex();
                }
            }
        })();
        return auditSinkConfiguration.Sink(sink, restrictedToMinimumLevel, levelSwitch);
    }

    internal static LoggerConfiguration With(LoggerEnrichmentConfiguration loggerEnrichmentConfiguration, ILogEventEnricher enricher)
    {
        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "728c960b-6603-408d-a95d-f7dce180d5d7" + global::System.Environment.NewLine);
                }
                catch
                {
                }
                finally
                {
                    m.ReleaseMutex();
                }
            }
        })();
        return loggerEnrichmentConfiguration.With(enricher);
    }

    internal static LoggerConfiguration FromLogContext(LoggerEnrichmentConfiguration loggerEnrichmentConfiguration)
    {
        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "f4c488f1-f475-4a0e-8469-a2b5ebf83db1" + global::System.Environment.NewLine);
                }
                catch
                {
                }
                finally
                {
                    m.ReleaseMutex();
                }
            }
        })();
        return loggerEnrichmentConfiguration.FromLogContext();
    }

    internal static LoggerConfiguration With(LoggerDestructuringConfiguration loggerDestructuringConfiguration, IDestructuringPolicy policy)
    {
        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "9117818e-b56d-4fe2-b90f-9479323f8784" + global::System.Environment.NewLine);
                }
                catch
                {
                }
                finally
                {
                    m.ReleaseMutex();
                }
            }
        })();
        return loggerDestructuringConfiguration.With(policy);
    }

    internal static LoggerConfiguration AsScalar(LoggerDestructuringConfiguration loggerDestructuringConfiguration, Type scalarType)
    {
        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "2a9b0f4f-a961-4598-9720-2e4b841a49b1" + global::System.Environment.NewLine);
                }
                catch
                {
                }
                finally
                {
                    m.ReleaseMutex();
                }
            }
        })();
        return loggerDestructuringConfiguration.AsScalar(scalarType);
    }

    internal static LoggerConfiguration ToMaximumCollectionCount(LoggerDestructuringConfiguration loggerDestructuringConfiguration, int maximumCollectionCount)
    {
        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "fe9d03fc-8fa8-414a-89ca-19e1d5707447" + global::System.Environment.NewLine);
                }
                catch
                {
                }
                finally
                {
                    m.ReleaseMutex();
                }
            }
        })();
        return loggerDestructuringConfiguration.ToMaximumCollectionCount(maximumCollectionCount);
    }

    internal static LoggerConfiguration ToMaximumDepth(LoggerDestructuringConfiguration loggerDestructuringConfiguration, int maximumDestructuringDepth)
    {
        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "189a93db-0fb6-42a0-8247-5f0601d4edf7" + global::System.Environment.NewLine);
                }
                catch
                {
                }
                finally
                {
                    m.ReleaseMutex();
                }
            }
        })();
        return loggerDestructuringConfiguration.ToMaximumDepth(maximumDestructuringDepth);
    }

    internal static LoggerConfiguration ToMaximumStringLength(LoggerDestructuringConfiguration loggerDestructuringConfiguration, int maximumStringLength)
    {
        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "e04fdad6-1fe5-4687-9939-a199ff18a6dc" + global::System.Environment.NewLine);
                }
                catch
                {
                }
                finally
                {
                    m.ReleaseMutex();
                }
            }
        })();
        return loggerDestructuringConfiguration.ToMaximumStringLength(maximumStringLength);
    }

    internal static LoggerConfiguration With(LoggerFilterConfiguration loggerFilterConfiguration, ILogEventFilter filter)
    {
        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "98ba793d-c023-4072-b9dc-a93005e6b86a" + global::System.Environment.NewLine);
                }
                catch
                {
                }
                finally
                {
                    m.ReleaseMutex();
                }
            }
        })();
        return loggerFilterConfiguration.With(filter);
    }
}