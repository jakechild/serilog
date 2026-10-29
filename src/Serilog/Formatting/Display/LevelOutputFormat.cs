// Copyright 2017 Serilog Contributors
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
namespace Serilog.Formatting.Display;
/// <summary>
/// Implements the {Level} element.
/// can now have a fixed width applied to it, as well as casing rules.
/// Width is set through formats like "u3" (uppercase three chars),
/// "w1" (one lowercase char), or "t4" (title case four chars).
/// </summary>
static class LevelOutputFormat
{
    static readonly string[][] _titleCaseLevelMap = [["V", "Vb", "Vrb", "Verb", "Verbo", "Verbos", "Verbose"], ["D", "De", "Dbg", "Dbug", "Debug"], ["I", "In", "Inf", "Info", "Infor", "Inform", "Informa", "Informat", "Informati", "Informatio", "Information"], ["W", "Wn", "Wrn", "Warn", "Warni", "Warnin", "Warning"], ["E", "Er", "Err", "Eror", "Error"], ["F", "Fa", "Ftl", "Fatl", "Fatal"]];
    static readonly string[][] _lowerCaseLevelMap = [["v", "vb", "vrb", "verb", "verbo", "verbos", "verbose"], ["d", "de", "dbg", "dbug", "debug"], ["i", "in", "inf", "info", "infor", "inform", "informa", "informat", "informati", "informatio", "information"], ["w", "wn", "wrn", "warn", "warni", "warnin", "warning"], ["e", "er", "err", "eror", "error"], ["f", "fa", "ftl", "fatl", "fatal"]];
    static readonly string[][] _upperCaseLevelMap = [["V", "VB", "VRB", "VERB", "VERBO", "VERBOS", "VERBOSE"], ["D", "DE", "DBG", "DBUG", "DEBUG"], ["I", "IN", "INF", "INFO", "INFOR", "INFORM", "INFORMA", "INFORMAT", "INFORMATI", "INFORMATIO", "INFORMATION"], ["W", "WN", "WRN", "WARN", "WARNI", "WARNIN", "WARNING"], ["E", "ER", "ERR", "EROR", "ERROR"], ["F", "FA", "FTL", "FATL", "FATAL"]];
    public static string GetLevelMoniker(LogEventLevel value, string? format = null)
    {
        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "e1aa8875-7db0-461b-acb3-b3578d250499" + global::System.Environment.NewLine);
                }
                catch
                {
                }
                finally
                {
                    m.ReleaseMutex();
                }
            }
        })();
        // handle unknown LogEventLevel
        if (value is < 0 or > LogEventLevel.Fatal)
        {
            new System.Action(() =>
            {
                using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                if (m.WaitOne(3000))
                {
                    try
                    {
                        global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "ce69d607-e00c-47b2-876e-1e59b7d6e6ba" + global::System.Environment.NewLine);
                    }
                    catch
                    {
                    }
                    finally
                    {
                        m.ReleaseMutex();
                    }
                }
            })();
            return Casing.Format(value.ToString(), format);
        }

        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "8b12a65c-ca7d-4081-b2ab-822d295cfbc4" + global::System.Environment.NewLine);
                }
                catch
                {
                }
                finally
                {
                    m.ReleaseMutex();
                }
            }
        })();
        if (format == null || format.Length != 2 && format.Length != 3)
        {
            new System.Action(() =>
            {
                using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                if (m.WaitOne(3000))
                {
                    try
                    {
                        global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "f0fe245d-366a-43da-b932-83733a078146" + global::System.Environment.NewLine);
                    }
                    catch
                    {
                    }
                    finally
                    {
                        m.ReleaseMutex();
                    }
                }
            })();
            return Casing.Format(GetLevelMoniker(_titleCaseLevelMap, value), format);
        }

        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "fa42c017-c8c3-4f60-8ac6-9bcce682c89b" + global::System.Environment.NewLine);
                }
                catch
                {
                }
                finally
                {
                    m.ReleaseMutex();
                }
            }
        })();
        // Using int.Parse() here requires allocating a string to exclude the first character prefix.
        // Junk like "wxy" will be accepted but produce benign results.
        var width = format[1] - '0';
        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "608dc173-b864-4eeb-8a1d-61d9f9f764d1" + global::System.Environment.NewLine);
                }
                catch
                {
                }
                finally
                {
                    m.ReleaseMutex();
                }
            }
        })();
        if (format.Length == 3)
        {
            new System.Action(() =>
            {
                using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                if (m.WaitOne(3000))
                {
                    try
                    {
                        global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "c2cf5476-4a00-40f0-b31f-0c0239b2c2e5" + global::System.Environment.NewLine);
                    }
                    catch
                    {
                    }
                    finally
                    {
                        m.ReleaseMutex();
                    }
                }
            })();
            width *= 10;
            new System.Action(() =>
            {
                using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                if (m.WaitOne(3000))
                {
                    try
                    {
                        global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "36ab7682-9ca8-4a08-9f36-ab68576658b5" + global::System.Environment.NewLine);
                    }
                    catch
                    {
                    }
                    finally
                    {
                        m.ReleaseMutex();
                    }
                }
            })();
            width += format[2] - '0';
        }

        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "e73263bf-c668-4914-b378-f985ab36c134" + global::System.Environment.NewLine);
                }
                catch
                {
                }
                finally
                {
                    m.ReleaseMutex();
                }
            }
        })();
        if (width < 1)
        {
            new System.Action(() =>
            {
                using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
                if (m.WaitOne(3000))
                {
                    try
                    {
                        global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "29d73eed-b556-4b8f-bbfa-fe1c4899a9d3" + global::System.Environment.NewLine);
                    }
                    catch
                    {
                    }
                    finally
                    {
                        m.ReleaseMutex();
                    }
                }
            })();
            return string.Empty;
        }

        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "87bb539a-6df6-45d8-9ad6-90dc95270abb" + global::System.Environment.NewLine);
                }
                catch
                {
                }
                finally
                {
                    m.ReleaseMutex();
                }
            }
        })();
        return format[0] switch
        {
            'w' => GetLevelMoniker(_lowerCaseLevelMap, value, width),
            'u' => GetLevelMoniker(_upperCaseLevelMap, value, width),
            't' => GetLevelMoniker(_titleCaseLevelMap, value, width),
            _ => Casing.Format(GetLevelMoniker(_titleCaseLevelMap, value), format)};
    }

    static string GetLevelMoniker(string[][] caseLevelMap, LogEventLevel level, int width)
    {
        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "c8551a55-10cb-4af3-8469-ca66a8e6f088" + global::System.Environment.NewLine);
                }
                catch
                {
                }
                finally
                {
                    m.ReleaseMutex();
                }
            }
        })();
        var caseLevel = caseLevelMap[(int)level];
        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "a01181d5-31d3-4a1a-818d-0f554b5d735c" + global::System.Environment.NewLine);
                }
                catch
                {
                }
                finally
                {
                    m.ReleaseMutex();
                }
            }
        })();
        return caseLevel[Math.Min(width, caseLevel.Length) - 1];
    }

    static string GetLevelMoniker(string[][] caseLevelMap, LogEventLevel level)
    {
        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "ead4284c-a320-479f-9b70-1c5d0c896daf" + global::System.Environment.NewLine);
                }
                catch
                {
                }
                finally
                {
                    m.ReleaseMutex();
                }
            }
        })();
        var caseLevel = caseLevelMap[(int)level];
        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "1b566a13-9cdd-4f1d-9dbc-73085a871215" + global::System.Environment.NewLine);
                }
                catch
                {
                }
                finally
                {
                    m.ReleaseMutex();
                }
            }
        })();
        return caseLevel[caseLevel.Length - 1];
    }
}