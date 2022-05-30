using System;
using System.IO.Compression;

namespace _06_ZipAndExtract
{
    class Program
    {
        static void Main(string[] args)
        {
            ZipFile.CreateFromDirectory(@"C:\Users\User\Desktop\Programming  Books and Presentations\C# Advanced\Homework\Resources_StreamsFilesAndDirectoriesExercise", "newZipFile.zip", CompressionLevel.Optimal, false);
            ZipFile.ExtractToDirectory("newZipFile.zip", "destination");
            
        }
    }
}
