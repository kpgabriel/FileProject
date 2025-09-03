using System.IO;
using System.Runtime.CompilerServices;
using FileProject.Services;
using System.Text.Json;

namespace FileProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string directory = $"{args[0]}";
            string[] files = Directory.GetFiles(directory);
            //FileService fileService = new FileService();

            // Loop through your files
            foreach (string file in files)
            {
                FileInfo fileInfo = new FileInfo(file);
                string fileExtension = Path.GetExtension(file);
                string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(file);

                // Use Regex.Replace to insert underscores before capital letters and convert to lower case
                string snakeCaseName = System.Text.RegularExpressions.Regex.Replace(
                    fileNameWithoutExtension,
                    "([a-z0-9])([A-Z])",
                    "$1_$2"
                ).ToLower();

                string newFileName = $"{snakeCaseName}{fileExtension}";

                switch (fileExtension)
                {
                    case ".txt":
                        string newDir = "TXT";
                        File.Move(file, Path.Combine(directory, newDir, newFileName));
                        Console.WriteLine($"Moving file {file} -----> {directory}\\{newDir}\\{newFileName}");
                        break;
                    case ".jpg":
                        Console.WriteLine("jpg File found");
                        break;
                    case ".png":
                        Console.WriteLine("png File found");
                        break;
                    case ".pdf":
                        Console.WriteLine("pdf File found");
                        break;
                    case ".docx":
                        Console.WriteLine("docx File found");
                        break;
                    default:
                        Console.WriteLine($"Other File found {file}");
                        break;
                }
            }
            //Console.WriteLine("Files found by extension:");
            //Console.WriteLine(JsonSerializer.Serialize(fileService.FileTypeCount, new JsonSerializerOptions { WriteIndented = true }));
        }
    }
}
