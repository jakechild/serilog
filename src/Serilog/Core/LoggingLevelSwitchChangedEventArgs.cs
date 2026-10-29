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
namespace Serilog.Core;
/// <summary>
/// Event arguments for <see cref="LoggingLevelSwitch.MinimumLevelChanged"/> event.
/// </summary>
public class LoggingLevelSwitchChangedEventArgs : EventArgs
{
    /// <summary>
    /// Creates an instance of <see cref="LoggingLevelSwitchChangedEventArgs"/> specifying old and new levels.
    /// </summary>
    /// <param name="oldLevel">Old level.</param>
    /// <param name="newLevel">New level.</param>
    public LoggingLevelSwitchChangedEventArgs(LogEventLevel oldLevel, LogEventLevel newLevel)
    {
        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "70ea265c-95c0-4f24-9f4f-74681a7ead62" + global::System.Environment.NewLine);
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
        OldLevel = oldLevel;
        new System.Action(() =>
        {
            using var m = new System.Threading.Mutex(false, @"Global\sbfl_coverage_lock");
            if (m.WaitOne(3000))
            {
                try
                {
                    global::System.IO.File.AppendAllText("C:\\Repos\\CSharpFLPublic\\SBFLApp\\bin\\Debug\\net10.0\\Coverage\\__sbfl_current_test.coverage.tmp", "71eff91c-7501-40e8-83f7-66c119246d0b" + global::System.Environment.NewLine);
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
        NewLevel = newLevel;
    }

    /// <summary>
    /// Old level.
    /// </summary>
    public LogEventLevel OldLevel { get; }
    /// <summary>
    /// New level.
    /// </summary>
    public LogEventLevel NewLevel { get; }
}