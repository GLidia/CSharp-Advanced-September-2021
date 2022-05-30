using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _05_DirectoryTraversal
{
    class Program
    {
        static void Main(string[] args)
        {
            //extension + (fileName + size of each file)
            Dictionary<string, Dictionary<string, long>> extensions = new Dictionary<string, Dictionary<string, long>>();

            string[] files = Directory.GetFiles(@"C:\Users\User\Documents\Introduction to Islamic Philosophy Fall 2018");

            foreach (string file in files)
            {
                FileInfo fi = new FileInfo(file);
                string extension = fi.Extension;
                string name = fi.Name;
                long size = fi.Length;

                if (!extensions.ContainsKey(extension))
                {
                    extensions.Add(extension, new Dictionary<string, long>());
                }

                extensions[extension].Add(name, size);
            }

            StreamWriter writer = new StreamWriter(@"C:\Users\User\Desktop\report.txt");
            using (writer)
            {
                foreach (var extension in extensions.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key))
                {
                    writer.WriteLine(extension.Key);
                    foreach (var file in extension.Value.OrderBy(x => x.Value))
                    {
                        double fileSizeInKB = file.Value / 1024.00;
                        writer.WriteLine($"--{file.Key} - {fileSizeInKB}kb");
                    }
                }
            }
        }
    }
}
