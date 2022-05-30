using System;
using System.IO;

namespace _04_CopyBinaryFile
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream fsr = new FileStream(@"C:\Users\User\Desktop\Programming  Books and Presentations\C# Advanced\Homework\Resources_StreamsFilesAndDirectoriesExercise\ToCopy.png", FileMode.Open);
            FileStream fsw = new FileStream("Copied.png", FileMode.CreateNew);

            using (fsr)
            {
                byte[] buffer = new byte[4096];
                int bytesRead;

                using (fsw)
                {
                    while ((bytesRead = fsr.Read(buffer, 0, buffer.Length)) > 0)
                    {
                        fsw.Write(buffer, 0, bytesRead);
                    }
                }

            }
        }
    }
}
