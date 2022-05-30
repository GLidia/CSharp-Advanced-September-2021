using System;
using System.IO;

namespace _06_FolderSize
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] fileNames = Directory.GetFiles(@"C:\Users\User\Desktop\Programming  Books and Presentations\C# Advanced\Homework\Resources_StreamsFilesAndDirectoriesLab\06. Folder Size\TestFolder");

            double sum = 0;
            foreach (string file in fileNames)
            {
                FileInfo fi = new FileInfo(file);
                sum += fi.Length;
            }

            string result = (sum / 1024 / 1024).ToString();
            File.WriteAllText("Output.txt", result);
        }
    }
}
