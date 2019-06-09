using System;
namespace CSC395_Module3
{
    public class Utility
    {
        public static string[] ReadFromFile(string path)
        {
            // Read text from text file, change to lower, and store in lowerWords.
            //try
            //{
            string[] words = System.IO.File.ReadAllLines(path);
            // Create parallel array of words by calling ToLower.
            string[] lowerWords = new string[words.Length];
            for (int ctr = words.GetLowerBound(0); ctr <= words.GetUpperBound(0); ctr++)
                lowerWords[ctr] = words[ctr].ToLower();
            //}
            //catch(System.IO.DirectoryNotFoundException)
            //{
            //Console.WriteLine($"The following file path could not be found: {path}");  
            //}
            // Pass the file contents to sorting algorthims.
            return lowerWords;
        }
    }
}
