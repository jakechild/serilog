// Copyright 2013-2017 Serilog Contributors
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
namespace Serilog.Rendering;
static class Casing
{
    /// <summary>
    /// Apply upper or lower casing to <paramref name="value"/> when <paramref name="format"/> is provided.
    /// Returns <paramref name="value"/> when no or invalid format provided
    /// </summary>
    /// <returns>The provided <paramref name="value"/> with formatting applied</returns>
    public static string Format(string value, string? format = null)
    {
        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "dfde97f9-8fcf-47ca-9c3f-b31c1dbf7664" + global::System.Environment.NewLine);
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
        return format switch
        {
            "u" => value.ToUpperInvariant(),
            "w" => value.ToLowerInvariant(),
            _ => value
        };
    }
}