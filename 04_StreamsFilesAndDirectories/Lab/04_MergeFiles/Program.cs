using System;
using System.IO;

namespace _04_MergeFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader readerOne = new StreamReader("FileOne.txt");
            StreamReader readerTwo = new StreamReader("FileTwo.txt");

            using (readerOne)
            {
                using (readerTwo)
                {
                    string lineOne = readerOne.ReadLine();
                    string lineTwo = readerTwo.ReadLine();

                    using (StreamWriter writer = new StreamWriter("output.txt"))
                    {
                        while (lineOne != null && lineTwo != null)
                        {
                            writer.WriteLine(lineOne);
                            writer.WriteLine(lineTwo);

                            lineOne = readerOne.ReadLine();
                            lineTwo = readerTwo.ReadLine();
                        }

                    }
                }
            }

        }
    }
}
