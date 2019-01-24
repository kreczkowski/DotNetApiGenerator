using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;

namespace DotNetApiGenerator.Helpers
{
    internal static class CLICommands
    {
        private static string createProject { get;} = $"new webapi";

        public static void CreateProject()
        {
            try
            {
                Directory.CreateDirectory($"D:/{ProjectSettings.ProjectName}");

                ProcessStartInfo proStart = new ProcessStartInfo();
                Process pro = new Process();
                proStart.FileName = "dotnet.exe";
                proStart.WorkingDirectory = $"D:/{ProjectSettings.ProjectName}";
                string arg = createProject;
                proStart.Arguments = arg;
                proStart.WindowStyle = ProcessWindowStyle.Normal;
                pro.StartInfo = proStart;
                pro.Start();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
