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
namespace Serilog.Events;
/// <summary>
/// A property associated with a <see cref="LogEvent"/>.
/// </summary>
public class LogEventProperty
{
    /// <summary>
    /// Construct a <see cref="LogEventProperty"/> with the specified name and value.
    /// </summary>
    /// <param name="name">The name of the property.</param>
    /// <param name="value">The value of the property.</param>
    /// <exception cref="ArgumentNullException">When <paramref name="name"/> is <code>null</code></exception>
    /// <exception cref="ArgumentException">When <paramref name="name"/> is empty or only contains whitespace</exception>
    /// <exception cref="ArgumentNullException">When <paramref name="value"/> is <code>null</code></exception>
    public LogEventProperty(string name, LogEventPropertyValue value)
    {
        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "0e90c4c1-12cf-44d6-8900-0e427159d630" + global::System.Environment.NewLine);
                }
                catch
                {
                }
                finally
                {
                    m.ReleaseMutex();
                }
            }
        })();
        Guard.AgainstNull(value);
        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "60c3c7d4-1843-46f9-a235-c0b54ff12622" + global::System.Environment.NewLine);
                }
                catch
                {
                }
                finally
                {
                    m.ReleaseMutex();
                }
            }
        })();
        EnsureValidName(name);
        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "c24d7f32-a7e5-4cd2-83a1-993d4e84a264" + global::System.Environment.NewLine);
                }
                catch
                {
                }
                finally
                {
                    m.ReleaseMutex();
                }
            }
        })();
        Name = name;
        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "6331264b-b746-4b4c-a291-6295681582ee" + global::System.Environment.NewLine);
                }
                catch
                {
                }
                finally
                {
                    m.ReleaseMutex();
                }
            }
        })();
        Value = value;
    }

    /// <summary>
    /// Construct a <see cref="LogEventProperty"/> from an existing <see cref="EventProperty"/> instance.
    /// </summary>
    /// <param name="property">The existing property.</param>
    /// <exception cref="ArgumentNullException">When <paramref name="property"/> is <code>default</code></exception>
    internal LogEventProperty(EventProperty property)
    {
        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "7317f380-5baa-4f86-ab77-249e0200b928" + global::System.Environment.NewLine);
                }
                catch
                {
                }
                finally
                {
                    m.ReleaseMutex();
                }
            }
        })();
        if (property.Equals(EventProperty.None))
        {
            new System.Action(() =>
            {
                using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                if (m.WaitOne(3000))
                {
                    try
                    {
                        global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "260bcd9d-9189-4af9-b264-1d860a33c743" + global::System.Environment.NewLine);
                    }
                    catch
                    {
                    }
                    finally
                    {
                        m.ReleaseMutex();
                    }
                }
            })();
            throw new ArgumentNullException(nameof(property));
        }

        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "22528b43-0196-4cf1-96da-b6346d2f8511" + global::System.Environment.NewLine);
                }
                catch
                {
                }
                finally
                {
                    m.ReleaseMutex();
                }
            }
        })();
        Name = property.Name;
        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "e0ac2d71-4fe6-4c3b-9bae-cc016ab441c3" + global::System.Environment.NewLine);
                }
                catch
                {
                }
                finally
                {
                    m.ReleaseMutex();
                }
            }
        })();
        Value = property.Value;
    }

    /// <summary>
    /// The name of the property.
    /// </summary>
    public string Name { get; }
    /// <summary>
    /// The value of the property.
    /// </summary>
    public LogEventPropertyValue Value { get; }

    /// <summary>
    /// Test <paramref name="name" /> to determine if it is a valid property name.
    /// </summary>
    /// <param name="name">The name to check.</param>
    /// <returns><see langword="true"/> if the name is valid; otherwise, <see langword="false"/>.</returns>
    public static bool IsValidName([NotNullWhen(true)] string? name) => !string.IsNullOrWhiteSpace(name);
    /// <exception cref="ArgumentNullException">When <paramref name="name"/> is <code>null</code></exception>
    /// <exception cref="ArgumentException">When <paramref name="name"/> is empty or only contains whitespace</exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    internal static void EnsureValidName(string name)
    {
        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "6c6423a2-73a0-433d-8dd5-559b70607d29" + global::System.Environment.NewLine);
                }
                catch
                {
                }
                finally
                {
                    m.ReleaseMutex();
                }
            }
        })();
        Guard.AgainstNull(name);
        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "ab68c1a6-fa56-4183-beb6-3da782ae8da2" + global::System.Environment.NewLine);
                }
                catch
                {
                }
                finally
                {
                    m.ReleaseMutex();
                }
            }
        })();
        if (!IsValidName(name))
        {
            new System.Action(() =>
            {
                using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                if (m.WaitOne(3000))
                {
                    try
                    {
                        global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "3fedc1f3-b309-4ea9-9040-39c017c56dcb" + global::System.Environment.NewLine);
                    }
                    catch
                    {
                    }
                    finally
                    {
                        m.ReleaseMutex();
                    }
                }
            })();
            throw new ArgumentException($"Property {nameof(name)} must not be empty or whitespace.", nameof(name));
        }
    }
}