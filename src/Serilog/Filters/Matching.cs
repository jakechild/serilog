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
namespace Serilog.Filters;
/// <summary>
/// Predicates applied to log events that can be used
/// </summary>
public static class Matching
{
    /// <summary>
    /// Matches events from the specified source type.
    /// </summary>
    /// <typeparam name="TSource">The source type.</typeparam>
    /// <returns>A predicate for matching events.</returns>
    public static Func<LogEvent, bool> FromSource<TSource>()
    {
        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "9716bf11-315a-4954-8989-f8bb1bbf1373" + global::System.Environment.NewLine);
                }
                catch
                {
                }
                finally
                {
                    m.ReleaseMutex();
                }
            }
        })();
        return WithProperty(Constants.SourceContextPropertyName, typeof(TSource).FullName!);
    }

    /// <summary>
    /// Matches events from the specified source type or namespace and
    /// nested types or namespaces.
    /// </summary>
    /// <param name="source">A dotted source type or namespace identifier.</param>
    /// <returns>A function that matches log events emitted by the source.</returns>
    /// <exception cref="ArgumentNullException">When <paramref name="source"/> is <code>null</code></exception>
    public static Func<LogEvent, bool> FromSource(string source)
    {
        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "86b74942-1f8e-4ebd-a0fc-4ea5d1060f37" + global::System.Environment.NewLine);
                }
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
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "e8778841-278e-4c95-8415-326f4a636171" + global::System.Environment.NewLine);
                }
                catch
                {
                }
                finally
                {
                    m.ReleaseMutex();
                }
            }
        })();
        return WithProperty<string>(Constants.SourceContextPropertyName, s => s != null && s
#if FEATURE_SPAN
                .AsSpan()
#endif
        .StartsWith(source) && (s.Length == source.Length || s[source.Length] == '.'));
    }

    /// <summary>
    /// Matches events with the specified property attached,
    /// regardless of its value.
    /// </summary>
    /// <param name="propertyName">The name of the property to match.</param>
    /// <returns>A predicate for matching events.</returns>
    /// <exception cref="ArgumentNullException">When <paramref name="propertyName"/> is <code>null</code></exception>
    public static Func<LogEvent, bool> WithProperty(string propertyName)
    {
        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "bc1f55a1-11b7-4328-a51b-9d19cc36d09a" + global::System.Environment.NewLine);
                }
                catch
                {
                }
                finally
                {
                    m.ReleaseMutex();
                }
            }
        })();
        Guard.AgainstNull(propertyName);
        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "cdd2e746-3db2-4500-a87f-9a1cffe9040d" + global::System.Environment.NewLine);
                }
                catch
                {
                }
                finally
                {
                    m.ReleaseMutex();
                }
            }
        })();
        return e => e.Properties.ContainsKey(propertyName);
    }

    /// <summary>
    /// Matches events with the specified property value.
    /// </summary>
    /// <param name="propertyName">The name of the property to match.</param>
    /// <param name="scalarValue">The property value to match; must be a scalar type.
    /// Null is allowed.</param>
    /// <returns>A predicate for matching events.</returns>
    /// <exception cref="ArgumentNullException">When <paramref name="propertyName"/> is <code>null</code></exception>
    public static Func<LogEvent, bool> WithProperty(string propertyName, object scalarValue)
    {
        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "484ddeff-15c7-4ef9-89f6-0558dda9fa61" + global::System.Environment.NewLine);
                }
                catch
                {
                }
                finally
                {
                    m.ReleaseMutex();
                }
            }
        })();
        Guard.AgainstNull(propertyName);
        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "10f23c59-ebfa-423e-98f4-868ac51c6a19" + global::System.Environment.NewLine);
                }
                catch
                {
                }
                finally
                {
                    m.ReleaseMutex();
                }
            }
        })();
        var scalar = new ScalarValue(scalarValue);
        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "895b0353-1990-47ac-a96b-0146fe2996de" + global::System.Environment.NewLine);
                }
                catch
                {
                }
                finally
                {
                    m.ReleaseMutex();
                }
            }
        })();
        return e => e.Properties.TryGetValue(propertyName, out var propertyValue) && scalar.Equals(propertyValue);
    }

    /// <summary>
    /// Matches events with the specified property value.
    /// </summary>
    /// <param name="propertyName">The name of the property to match.</param>
    /// <param name="predicate">A predicate for testing </param>
    /// <typeparam name="TScalar">The type of scalar values to match.</typeparam>
    /// <returns>A predicate for matching events.</returns>
    /// <exception cref="ArgumentNullException">When <paramref name="propertyName"/> is <code>null</code></exception>
    /// <exception cref="ArgumentNullException">When <paramref name="predicate"/> is <code>null</code></exception>
    public static Func<LogEvent, bool> WithProperty<TScalar>(string propertyName, Func<TScalar, bool> predicate)
    {
        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "78730ebb-3f5b-4df5-b714-2e81588020c0" + global::System.Environment.NewLine);
                }
                catch
                {
                }
                finally
                {
                    m.ReleaseMutex();
                }
            }
        })();
        Guard.AgainstNull(propertyName);
        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "a8f36399-f133-4302-befe-de76911a7094" + global::System.Environment.NewLine);
                }
                catch
                {
                }
                finally
                {
                    m.ReleaseMutex();
                }
            }
        })();
        Guard.AgainstNull(predicate);
        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "b9a22d54-63fa-47c0-8b68-e041527f7f8d" + global::System.Environment.NewLine);
                }
                catch
                {
                }
                finally
                {
                    m.ReleaseMutex();
                }
            }
        })();
        return e =>
        {
            new System.Action(() =>
            {
                using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                if (m.WaitOne(3000))
                {
                    try
                    {
                        global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "8d44861f-7d1d-42df-b5c3-aef5e5ca98f4" + global::System.Environment.NewLine);
                    }
                    catch
                    {
                    }
                    finally
                    {
                        m.ReleaseMutex();
                    }
                }
            })();
            if (!e.Properties.TryGetValue(propertyName, out var propertyValue))
            {
                new System.Action(() =>
                {
                    using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                    if (m.WaitOne(3000))
                    {
                        try
                        {
                            global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "7a9c6f90-f642-4b0b-8754-56f266eefb81" + global::System.Environment.NewLine);
                        }
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
                        global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "27c864a7-8507-47e0-ac25-df3edc26ba52" + global::System.Environment.NewLine);
                    }
                    catch
                    {
                    }
                    finally
                    {
                        m.ReleaseMutex();
                    }
                }
            })();
            return propertyValue is ScalarValue { Value: TScalar value } && predicate(value);
        };
    }
}