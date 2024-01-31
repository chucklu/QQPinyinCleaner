using System;
using System.Collections.Generic;
using System.Configuration;
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
            string targetFolder = ConfigurationManager.AppSettings["TargetFolder"];

            try
            {
                // Get all files in the folder
                string[] allFiles = Directory.GetFiles(targetFolder);

                // Filter files without extensions using LINQ
                var filesWithExtensions = allFiles.Where(file => Path.GetExtension(file) == string.Empty);

                // Display the filtered files
                Console.WriteLine("Files with extensions:");
                int i = 0;
                foreach (var file in filesWithExtensions)
                {
                    i++;
                    Console.WriteLine($"{i:D2}, {file}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
            finally
            {
                Console.ReadLine();
            }
        }
    }
}
