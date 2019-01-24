using DotNetApiGenerator.Helpers;
using System;
using System.Diagnostics;
using System.IO;
using System.Threading;

namespace DotNetApiGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            try
            {
                CLICommands.CreateProject();
                Thread.Sleep(10000);
                CatalogsNames.CreateDirectories();
            }
            catch(Exception ex)
            {
                string tets = ex.StackTrace;
            }
        }
    }
}
