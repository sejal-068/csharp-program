using System.Diagnostics;

Stopwatch sw = Stopwatch.StartNew();

// your logic here

sw.Stop();
Console.WriteLine("Time: " + sw.ElapsedMilliseconds);