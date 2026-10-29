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
/// Controls template parameter destructuring configuration.
/// </summary>
public class LoggerDestructuringConfiguration
{
    readonly LoggerConfiguration _loggerConfiguration;
    readonly Action<Type> _addScalar;
    readonly Action<Type> _addDictionaryType;
    readonly Action<IDestructuringPolicy> _addPolicy;
    readonly Action<int> _setMaximumDepth;
    readonly Action<int> _setMaximumStringLength;
    readonly Action<int> _setMaximumCollectionCount;
    internal LoggerDestructuringConfiguration(LoggerConfiguration loggerConfiguration, Action<Type> addScalar, Action<Type> addDictionaryType, Action<IDestructuringPolicy> addPolicy, Action<int> setMaximumDepth, Action<int> setMaximumStringLength, Action<int> setMaximumCollectionCount)
    {
        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "67ae7bb6-a741-4db1-99be-0ccae3828730" + global::System.Environment.NewLine);
                }
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
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "1e73fc7b-7513-4148-846b-803032148ffe" + global::System.Environment.NewLine);
                }
                catch
                {
                }
                finally
                {
                    m.ReleaseMutex();
                }
            }
        })();
        _addScalar = Guard.AgainstNull(addScalar);
        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "221ecc74-f338-49a5-91f4-5bd999a73379" + global::System.Environment.NewLine);
                }
                catch
                {
                }
                finally
                {
                    m.ReleaseMutex();
                }
            }
        })();
        _addDictionaryType = Guard.AgainstNull(addDictionaryType);
        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "df9104fa-b61e-40c8-b930-3d3cdd15249f" + global::System.Environment.NewLine);
                }
                catch
                {
                }
                finally
                {
                    m.ReleaseMutex();
                }
            }
        })();
        _addPolicy = Guard.AgainstNull(addPolicy);
        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "0dfc77c4-ae9e-497a-9711-3604bb73f168" + global::System.Environment.NewLine);
                }
                catch
                {
                }
                finally
                {
                    m.ReleaseMutex();
                }
            }
        })();
        _setMaximumDepth = Guard.AgainstNull(setMaximumDepth);
        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "b49c3565-65c0-47ce-b51f-54f949393732" + global::System.Environment.NewLine);
                }
                catch
                {
                }
                finally
                {
                    m.ReleaseMutex();
                }
            }
        })();
        _setMaximumStringLength = Guard.AgainstNull(setMaximumStringLength);
        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "5914097e-c85a-4af9-9356-f587e21235e2" + global::System.Environment.NewLine);
                }
                catch
                {
                }
                finally
                {
                    m.ReleaseMutex();
                }
            }
        })();
        _setMaximumCollectionCount = Guard.AgainstNull(setMaximumCollectionCount);
    }

    /// <summary>
    /// Treat objects of the specified type as scalar values, i.e., don't break
    /// them down into properties even when destructuring complex types.
    /// </summary>
    /// <param name="scalarType">Type to treat as scalar.</param>
    /// <returns>Configuration object allowing method chaining.</returns>
    /// <exception cref="ArgumentNullException">When <paramref name="scalarType"/> is <code>null</code></exception>
    public LoggerConfiguration AsScalar(Type scalarType)
    {
        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "09fbbad5-081f-4dca-920b-942672a85bd3" + global::System.Environment.NewLine);
                }
                catch
                {
                }
                finally
                {
                    m.ReleaseMutex();
                }
            }
        })();
        Guard.AgainstNull(scalarType);
        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "cf9ff0e1-6e7d-4fe1-9fd6-cab77bcdcaf8" + global::System.Environment.NewLine);
                }
                catch
                {
                }
                finally
                {
                    m.ReleaseMutex();
                }
            }
        })();
        _addScalar(scalarType);
        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "e874945d-77ac-4e38-a0e5-b7f4932285ce" + global::System.Environment.NewLine);
                }
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
    /// Treat objects of the specified type as scalar values, i.e., don't break
    /// them down into properties even when destructuring complex types.
    /// </summary>
    /// <typeparam name="TScalar">Type to treat as scalar.</typeparam>
    /// <returns>Configuration object allowing method chaining.</returns>
    public LoggerConfiguration AsScalar<TScalar>() => AsScalar(typeof(TScalar));
    /// <summary>
    /// When destructuring objects, transform instances with the provided policies.
    /// </summary>
    /// <param name="destructuringPolicies">Policies to apply when destructuring.</param>
    /// <returns>Configuration object allowing method chaining.</returns>
    /// <exception cref="ArgumentNullException">When <paramref name="destructuringPolicies"/> is <code>null</code></exception>
    /// <exception cref="ArgumentException">When any element of <paramref name="destructuringPolicies"/> is <code>null</code></exception>
    // ReSharper disable once MemberCanBePrivate.Global
    public LoggerConfiguration With(params IDestructuringPolicy[] destructuringPolicies)
    {
        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "60bb0c50-49d1-4498-8acb-53a0c2dfeae5" + global::System.Environment.NewLine);
                }
                catch
                {
                }
                finally
                {
                    m.ReleaseMutex();
                }
            }
        })();
        Guard.AgainstNull(destructuringPolicies);
        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "28d7c303-5aca-4c3e-b57d-845dce3093ca" + global::System.Environment.NewLine);
                }
                catch
                {
                }
                finally
                {
                    m.ReleaseMutex();
                }
            }
        })();
        foreach (var destructuringPolicy in destructuringPolicies)
        {
            new System.Action(() =>
            {
                using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                if (m.WaitOne(3000))
                {
                    try
                    {
                        global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "67cb2f6a-f847-46f4-a44c-e9f8806da0af" + global::System.Environment.NewLine);
                    }
                    catch
                    {
                    }
                    finally
                    {
                        m.ReleaseMutex();
                    }
                }
            })();
            if (destructuringPolicy == null)
            {
                new System.Action(() =>
                {
                    using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                    if (m.WaitOne(3000))
                    {
                        try
                        {
                            global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "255f89ce-2f85-4f13-a9b5-f04796d2a5d4" + global::System.Environment.NewLine);
                        }
                        catch
                        {
                        }
                        finally
                        {
                            m.ReleaseMutex();
                        }
                    }
                })();
                throw new ArgumentException("Null policy is not allowed.");
            }

            new System.Action(() =>
            {
                using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                if (m.WaitOne(3000))
                {
                    try
                    {
                        global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "b6cb0021-05a8-46b2-aa7f-30569d1146da" + global::System.Environment.NewLine);
                    }
                    catch
                    {
                    }
                    finally
                    {
                        m.ReleaseMutex();
                    }
                }
            })();
            _addPolicy(destructuringPolicy);
        }

        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "5b43040b-1048-4799-9760-b4713565684d" + global::System.Environment.NewLine);
                }
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
    /// When destructuring objects, transform instances with the provided policy.
    /// </summary>
    /// <typeparam name="TDestructuringPolicy">Policy to apply when destructuring.</typeparam>
    /// <returns>Configuration object allowing method chaining.</returns>
    public LoggerConfiguration With<TDestructuringPolicy>()
        where TDestructuringPolicy : IDestructuringPolicy, new()
    {
        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "5626f50d-f117-47e3-9522-809b5eb5b86b" + global::System.Environment.NewLine);
                }
                catch
                {
                }
                finally
                {
                    m.ReleaseMutex();
                }
            }
        })();
        return With(new TDestructuringPolicy());
    }

    /// <summary>
    /// Capture instances of the specified type as dictionaries.
    /// By default, only concrete instantiations of are considered dictionary-like.
    /// </summary>
    /// <typeparam name="T">Type of dictionary.</typeparam>
    /// <returns>Configuration object allowing method chaining.</returns>
    public LoggerConfiguration AsDictionary<T>()
        where T : IDictionary
    {
        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "cba5f8c4-f74f-41d9-b57c-4bffb182c022" + global::System.Environment.NewLine);
                }
                catch
                {
                }
                finally
                {
                    m.ReleaseMutex();
                }
            }
        })();
        _addDictionaryType(typeof(T));
        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "1cfc0e2a-6051-4169-93e9-821c9083e51c" + global::System.Environment.NewLine);
                }
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
    /// When destructuring objects, transform instances of the specified type with
    /// the provided function.
    /// </summary>
    /// <param name="transformation">Function mapping instances of <typeparamref name="TValue"/>
    /// to an alternative representation.</param>
    /// <typeparam name="TValue">Type of values to transform.</typeparam>
    /// <returns>Configuration object allowing method chaining.</returns>
    /// <exception cref="ArgumentNullException">When <paramref name="transformation"/> is <code>null</code></exception>
    public LoggerConfiguration ByTransforming<TValue>(Func<TValue, object> transformation)
    {
        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "b213f9f5-d724-4e68-ab5d-221b6bcf818e" + global::System.Environment.NewLine);
                }
                catch
                {
                }
                finally
                {
                    m.ReleaseMutex();
                }
            }
        })();
        Guard.AgainstNull(transformation);
        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "a1e0b729-11ec-4adf-9183-1fa340398ffc" + global::System.Environment.NewLine);
                }
                catch
                {
                }
                finally
                {
                    m.ReleaseMutex();
                }
            }
        })();
        var policy = new ProjectedDestructuringPolicy(t => t == typeof(TValue), o => transformation((TValue)o));
        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "068b97b3-ef1f-4554-be5e-6ab679a71423" + global::System.Environment.NewLine);
                }
                catch
                {
                }
                finally
                {
                    m.ReleaseMutex();
                }
            }
        })();
        return With(policy);
    }

    /// <summary>
    /// When destructuring objects, transform instances of the specified type with
    /// the provided function, if the predicate returns true. Be careful to avoid any
    /// intensive work in the predicate, as it can slow down the pipeline significantly.
    /// </summary>
    /// <param name="predicate">A predicate used to determine if the transform applies to
    /// a specific type of value</param>
    /// <param name="transformation">Function mapping instances of <typeparamref name="TValue"/>
    /// to an alternative representation.</param>
    /// <typeparam name="TValue">Type of values to transform.</typeparam>
    /// <returns>Configuration object allowing method chaining.</returns>
    /// <exception cref="ArgumentNullException">When <paramref name="predicate"/> is <code>null</code></exception>
    /// <exception cref="ArgumentNullException">When <paramref name="transformation"/> is <code>null</code></exception>
    public LoggerConfiguration ByTransformingWhere<TValue>(Func<Type, bool> predicate, Func<TValue, object> transformation)
    {
        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "5ec2b6cc-207e-4c3a-ac85-aef8a3fc028d" + global::System.Environment.NewLine);
                }
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
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "2b1017c0-566d-44bc-8404-db63aeab59c1" + global::System.Environment.NewLine);
                }
                catch
                {
                }
                finally
                {
                    m.ReleaseMutex();
                }
            }
        })();
        Guard.AgainstNull(transformation);
        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "80a1b873-4e2f-4376-b339-8f24af232886" + global::System.Environment.NewLine);
                }
                catch
                {
                }
                finally
                {
                    m.ReleaseMutex();
                }
            }
        })();
        var policy = new ProjectedDestructuringPolicy(predicate, o => transformation((TValue)o));
        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "b58f2af6-6832-4155-927a-e0cd033645c5" + global::System.Environment.NewLine);
                }
                catch
                {
                }
                finally
                {
                    m.ReleaseMutex();
                }
            }
        })();
        return With(policy);
    }

    /// <summary>
    /// When destructuring objects, depth will be limited to 10 property traversals deep to
    /// guard against ballooning space when recursive/cyclic structures are accidentally passed. To
    /// change this limit pass a new maximum depth.
    /// </summary>
    /// <param name="maximumDestructuringDepth">The maximum depth to use.</param>
    /// <returns>Configuration object allowing method chaining.</returns>
    /// <exception cref="ArgumentOutOfRangeException">When <paramref name="maximumDestructuringDepth"/> is negative</exception>
    public LoggerConfiguration ToMaximumDepth(int maximumDestructuringDepth)
    {
        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "855f8598-61de-459b-aa7a-8488ba7d62e1" + global::System.Environment.NewLine);
                }
                catch
                {
                }
                finally
                {
                    m.ReleaseMutex();
                }
            }
        })();
        if (maximumDestructuringDepth < 0)
        {
            new System.Action(() =>
            {
                using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                if (m.WaitOne(3000))
                {
                    try
                    {
                        global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "7ffd9a0b-e88d-4ad4-ab22-ee49dca20166" + global::System.Environment.NewLine);
                    }
                    catch
                    {
                    }
                    finally
                    {
                        m.ReleaseMutex();
                    }
                }
            })();
            throw new ArgumentOutOfRangeException(nameof(maximumDestructuringDepth), "Maximum destructuring depth must be positive.");
        }

        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "f3a18d44-1a90-4fd6-bfc6-d3f738cdfb69" + global::System.Environment.NewLine);
                }
                catch
                {
                }
                finally
                {
                    m.ReleaseMutex();
                }
            }
        })();
        _setMaximumDepth(maximumDestructuringDepth);
        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "98f9afb5-f779-42bd-b4e3-1f21d576d7a2" + global::System.Environment.NewLine);
                }
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
    /// When destructuring objects, string values can be restricted to specified length
    /// thus avoiding bloating payload. Limit is applied to each value separately,
    /// sum of length of strings can exceed limit.
    /// </summary>
    /// <param name="maximumStringLength">The maximum string length.</param>
    /// <returns>Configuration object allowing method chaining.</returns>
    /// <exception cref="ArgumentOutOfRangeException">When <paramref name="maximumStringLength"/> is less than 2</exception>
    public LoggerConfiguration ToMaximumStringLength(int maximumStringLength)
    {
        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "3872b4f3-fd9c-492c-aaf8-8ac2ec3e7d48" + global::System.Environment.NewLine);
                }
                catch
                {
                }
                finally
                {
                    m.ReleaseMutex();
                }
            }
        })();
        if (maximumStringLength < 2)
        {
            new System.Action(() =>
            {
                using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                if (m.WaitOne(3000))
                {
                    try
                    {
                        global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "1a89d278-7e77-48d7-98c6-6dec49354176" + global::System.Environment.NewLine);
                    }
                    catch
                    {
                    }
                    finally
                    {
                        m.ReleaseMutex();
                    }
                }
            })();
            throw new ArgumentOutOfRangeException(nameof(maximumStringLength), maximumStringLength, "Maximum string length must be at least two.");
        }

        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "43d13344-da58-4549-a699-efd5af39892b" + global::System.Environment.NewLine);
                }
                catch
                {
                }
                finally
                {
                    m.ReleaseMutex();
                }
            }
        })();
        _setMaximumStringLength(maximumStringLength);
        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "eb6ee249-8f78-43df-aba7-654facbf79f4" + global::System.Environment.NewLine);
                }
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
    /// When destructuring objects, collections be restricted to specified count
    /// thus avoiding bloating payload. Limit is applied to each collection separately,
    /// sum of length of collection can exceed limit.
    /// Applies limit to all <see cref="IEnumerable"/> including dictionaries.
    /// </summary>
    /// <returns>Configuration object allowing method chaining.</returns>
    /// <exception cref="ArgumentOutOfRangeException">When <paramref name="maximumCollectionCount"/> is less than 1</exception>
    public LoggerConfiguration ToMaximumCollectionCount(int maximumCollectionCount)
    {
        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "1aee1ce3-3561-494b-a5bf-f8ba215d2184" + global::System.Environment.NewLine);
                }
                catch
                {
                }
                finally
                {
                    m.ReleaseMutex();
                }
            }
        })();
        if (maximumCollectionCount < 1)
        {
            new System.Action(() =>
            {
                using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                if (m.WaitOne(3000))
                {
                    try
                    {
                        global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "b8116c27-ce46-47bd-a9b5-879f03a41d8a" + global::System.Environment.NewLine);
                    }
                    catch
                    {
                    }
                    finally
                    {
                        m.ReleaseMutex();
                    }
                }
            })();
            throw new ArgumentOutOfRangeException(nameof(maximumCollectionCount), maximumCollectionCount, "Maximum collection length must be at least one.");
        }

        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "b244c718-bdf7-4d4a-a834-94ebed32b312" + global::System.Environment.NewLine);
                }
                catch
                {
                }
                finally
                {
                    m.ReleaseMutex();
                }
            }
        })();
        _setMaximumCollectionCount(maximumCollectionCount);
        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "e858382a-c3ee-4fe4-803e-1cc25484ba53" + global::System.Environment.NewLine);
                }
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
}