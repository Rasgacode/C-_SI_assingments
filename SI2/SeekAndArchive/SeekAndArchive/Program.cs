using System;
using System.IO.Compression;
using System.IO;
using System.Security.Permissions;

namespace SeekAndArchive
{
    class Program
    {
        public static string Timestamp { get; set; }

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

                //watcher.Filter = "kutya.*";

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
            Timestamp = GetTimestamp(DateTime.Now);
            using (FileStream zipToCreate = new FileStream(@$"D:\archivedFiles\{Timestamp}.zip", FileMode.Create))
            {
                using (ZipArchive archive = new ZipArchive(zipToCreate, ZipArchiveMode.Create))
                {
                    ZipArchiveEntry newEntry = archive.CreateEntryFromFile(e.FullPath, e.Name);
                    //newEntry.ExtractToFile();
                }
            }
        }

        public static string GetTimestamp(DateTime value)
        {
            return value.ToString("yyyyMMddHHmmssffff");
        }
    }
}
