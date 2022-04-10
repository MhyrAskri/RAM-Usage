using System;
using System.Diagnostics;
using System.Threading;

namespace SystemUsage
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new MemoryMetricsClient();
            while (true)
            {
                var metrics = client.GetMetrics();

                Console.WriteLine("Total: " + metrics.Total);
                Console.WriteLine("Used : " + metrics.Used);
                Console.WriteLine("Free : " + metrics.Free);
                Thread.Sleep(1000);
            }
        }
    }
}
