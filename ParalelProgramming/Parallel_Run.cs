using System.Collections.Concurrent;
using System.Diagnostics;

namespace ParalelProgramming
{
    public static class Parallel_Run
    {
        public static void Run(List<House> houses)
        {
            ConcurrentBag<int> threadIds = new ConcurrentBag<int>();
            var stopWatch = new Stopwatch();
            stopWatch.Start();
            var parallel_houses = houses.AsParallel();
            parallel_houses.ForAll(x =>
            {
                x.Remontis_Gaketeba();
                int threadId = Thread.CurrentThread.ManagedThreadId;
                threadIds.Add(threadId);
            });
            stopWatch.Stop();

            var elapsed = stopWatch.Elapsed;

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine($"Unique threads used: {threadIds.Distinct().Count()}");
            string elapsedTime = String.Format("{0:00} hours {1:00} minutes {2:00} seconds {3:000} ms",
                       elapsed.Hours, elapsed.Minutes, elapsed.Seconds, elapsed.Milliseconds);

            // Output the formatted elapsed time
            Console.WriteLine($"Parallel Run Takes: {elapsedTime}");
        }
    }
}
