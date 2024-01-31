using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QQPinyinCleaner
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string folderPath = @"C:\Your\Folder\Path";

            try
            {
                // Get all files in the folder
                string[] allFiles = Directory.GetFiles(folderPath);

                // Filter files without extensions using LINQ
                var filesWithExtensions = allFiles.Where(file => Path.GetExtension(file) != string.Empty);

                // Display the filtered files
                Console.WriteLine("Files with extensions:");
                foreach (var file in filesWithExtensions)
                {
                    Console.WriteLine(file);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
    }
}
