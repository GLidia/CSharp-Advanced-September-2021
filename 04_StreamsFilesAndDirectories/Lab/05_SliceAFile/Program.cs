using System;
using System.IO;
using System.Text;

namespace _05_SliceAFile
{
    class Program
    {
        static void Main(string[] args)
        {
            using (FileStream fs = new FileStream(@"C:\Users\User\Desktop\Programming  Books and Presentations\C# Advanced\Homework\Resources_StreamsFilesAndDirectoriesLab\05. Slice File\sliceMe.txt", FileMode.OpenOrCreate))
            {
                string[] fileNames = new string[4] { "Part-1.txt", "Part-2.txt", "Part-3.txt", "Part-4.txt" };

                long eachFileSize = (long)Math.Ceiling(fs.Length / 4.0);

                for (int i = 0; i < 4; i++)
                {
                    byte[] buffer = new byte[eachFileSize];
                    fs.Read(buffer);

                    using (FileStream newFS = new FileStream(fileNames[i], FileMode.Create))
                    {
                        newFS.Write(buffer);
                    }

                }
            }
        }
    }
}
