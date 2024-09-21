using System;
using System.Diagnostics;

class Program
{
    static void Main()
    {
        Process process = new Process();

        process.StartInfo.FileName = @"C:\Program Files\Microsoft Office\root\Office16\WINWORD.EXE";

        process.Start();

        Console.WriteLine("Word запущен, ожидание завершения...");

        process.WaitForExit();

        int exitCode = process.ExitCode;
        Console.WriteLine($"Процесс завершен с кодом: {exitCode}");
    }
}
