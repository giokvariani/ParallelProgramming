using System.Diagnostics;

namespace ParalelProgramming
{
    public static class Synchronous_Run
    {
        public static void Run(List<House> houses)
        {
            var stopwatch = new Stopwatch();
            List<int> threadIds = new List<int>();
            stopwatch.Start();

            foreach (var item in houses)
            {
                item.Remontis_Gaketeba();
                int threadId = Thread.CurrentThread.ManagedThreadId;
                threadIds.Add(threadId);
            }
            stopwatch.Stop();

            Console.WriteLine();
            Console.WriteLine();
            // Output results
            var elapsed2 = stopwatch.Elapsed;
            Console.WriteLine($"Unique threads used: {threadIds.Distinct().Count()}");
            string elapsedTime = String.Format("{0:00} hours {1:00} minutes {2:00} seconds {3:000} ms",
                       elapsed2.Hours, elapsed2.Minutes, elapsed2.Seconds, elapsed2.Milliseconds);

            // Output the formatted elapsed time
            Console.WriteLine($"Synchronous Run taken: {elapsedTime}");
        }
    }
}
