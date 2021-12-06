using System.Diagnostics;

namespace AdventOfCode2021.Helpers
{
    public class MethodTimer
    {
        private static readonly Stopwatch StopWatch = new Stopwatch();
        
        public static void StartTimer()
        {
            StopWatch.Start();
        }

        public static string StopTimerAndFetchResults()
        {
            StopWatch.Stop();
            var results = $"Executed method in {StopWatch.ElapsedMilliseconds.ToString()} milliseconds.";
            StopWatch.Reset();
            return results;
        }
    }
}