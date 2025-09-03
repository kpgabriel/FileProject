using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileProject.Services
{
    internal class FileService
    {
        public Dictionary<string, int> FileTypeCount;
        public FileService(Dictionary<string,int> fileTypeCount) { 
            this.FileTypeCount = fileTypeCount;
        }
        public void checkDir(string directory, string newDir)
        {
            string targetDir = Path.Combine(directory, newDir);
            if (!Directory.Exists(targetDir))
            {
                Directory.CreateDirectory(targetDir);
            }
        }

        public void countFileType(string fileExtension)
        {
            //Implement this method to count file types
        }
    }
}
