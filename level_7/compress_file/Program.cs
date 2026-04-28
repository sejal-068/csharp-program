using System;
using System.IO;
using System.IO.Compression;

class Program
{
    static void Main()
    {
        using (FileStream original = File.OpenRead("data.txt"))
        using (FileStream compressed = File.Create("data.gz"))
        using (GZipStream gzip = new GZipStream(compressed, CompressionMode.Compress))
        {
            original.CopyTo(gzip);
        }

        Console.WriteLine("File compressed");
    }
}