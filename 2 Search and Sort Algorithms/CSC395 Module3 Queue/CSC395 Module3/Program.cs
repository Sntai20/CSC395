using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSC395_Module3
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Read user input from this file.
                string inputPath = @"input.txt";

                // Write program output to this file.
                string outputPath = @"output.txt";

                // To store contents in myQarr array, 
                // read contents one line per entry from input.txt.
                string[] myQArr = Utility.ReadFromFile(inputPath);

                // To reverse the contents of input.txt, 
                // enqueue contents into a queue then push contents into a stack 
                // and finally pop contents out in reverse order.
                Utility.ReverseFileContentsWithQueueAndStack(myQArr);

                // Write the contents of the entries from input.txt 
                // (one line per entry) and store them into an array.
                Utility.WriteToFile(outputPath, myQArr);

                // Display the contents of myQArr.
                Console.Write($"Success! File contents from {inputPath} " +
                    $"reversed and saved to file {outputPath}.");
            }
            catch (System.IO.DirectoryNotFoundException)
            {
                Console.WriteLine("File input path could not be found.");
            }
            catch (SystemException)
            {
                Console.WriteLine("Something went wrong.");
            }
        }
    }
}
