using System;
using System.IO.Compression;
using System.IO;
using System.Security.Permissions;

namespace SeekAndArchive
{
    class Program
    {
        public static string Filename { get; set; }

        static void Main(string[] args)
        {
            Run(args);
        }
        
        [PermissionSet(SecurityAction.Demand, Name = "FullTrust")]
        private static void Run(string[] args)
        {
            using (FileSystemWatcher watcher = new FileSystemWatcher())
            {
                watcher.Path = args[1];
                Filename = args[0];

                watcher.NotifyFilter = NotifyFilters.LastAccess
                    | NotifyFilters.LastWrite
                    | NotifyFilters.FileName
                    | NotifyFilters.DirectoryName;

                watcher.Filter = Filename;

                watcher.EnableRaisingEvents = true;

                watcher.Changed += OnChanged;
                watcher.Created += OnChanged;
                watcher.Deleted += OnChanged;
                watcher.Renamed += OnChanged;

                Console.WriteLine("Press 'q' to quit.");
                while (Console.Read() != 'q') ;
            }
        }

        private static void OnChanged(object source, FileSystemEventArgs e)
        {
            using (FileStream zipToOpen = new FileStream(@$"D:\directoryToWatch\lol.zip", FileMode.Open))
            {
                using (ZipArchive archive = new ZipArchive(zipToOpen, ZipArchiveMode.Update))
                {
                    ZipArchiveEntry readmeEntry = archive.CreateEntry($"{Filename.Substring(0, Filename.Length - 4)}.txt");
                    using (StreamWriter writer = new StreamWriter(readmeEntry.Open()))
                    {
                        writer.WriteLine("Information about this package.");
                        writer.WriteLine("========================");
                    }
                }
            }
        }
            
    }
}
