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
                var filesWithoutExtensions = allFiles.Where(file => Path.GetExtension(file) == string.Empty);

                // Display the filtered files
                Console.WriteLine($"{filesWithoutExtensions.Count()} file(s) without extensions:");
                int i = 0;
                foreach (var file in filesWithoutExtensions)
                {
                    i++;
                    //Console.WriteLine($"{i:D2}, {file}");
                }

                var orderedFiles = filesWithoutExtensions.OrderBy(file => Path.GetFileName(file)).ToList();
                int count = orderedFiles.Count;
                var filesToDeletCount = count - 2;
                if (filesToDeletCount > 0)
                {
                    for (i = 0; i < filesToDeletCount; i++)
                    {
                        File.Delete(orderedFiles[i]);
                    }
                    Console.WriteLine($"{filesToDeletCount} file(s) get deleted.");
                }
                else
                {
                    Console.WriteLine($"No files to delete.");
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
