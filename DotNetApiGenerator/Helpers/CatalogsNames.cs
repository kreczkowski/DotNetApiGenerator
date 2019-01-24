using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DotNetApiGenerator.Helpers
{
    /// <summary>
    /// List of directories that must be created for the project
    /// </summary>
    internal static class CatalogsNames
    {

        public static string Entities { get; } = "Entities";

        public static string Helpers { get; } = "Helpers";

        public static string Models { get; } = "Models";

        public static string Services { get; } = "Services";

        /// <summary>
        /// Create Directories in .Net Core Project
        /// </summary>
        public static void CreateDirectories()
        {
            Directory.CreateDirectory($"D:/{ProjectSettings.ProjectName}/{Entities}");
            Directory.CreateDirectory($"D:/{ProjectSettings.ProjectName}/{Helpers}");
            Directory.CreateDirectory($"D:/{ProjectSettings.ProjectName}/{Models}");
            Directory.CreateDirectory($"D:/{ProjectSettings.ProjectName}/{Services}");
        }

    }
}
