using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManager.ViewModels.Logic
{
    public class CustomFile
    {
        public CustomFile(string path)
        {
            this.FilePath = path;
            Extention = Path.GetExtension(path);
            Name = Path.GetFileNameWithoutExtension(path);
        }

        private string path;

        public string Name { get; set; }
        public string FilePath
        {
            get => path; set
            {
                path = value;
                if (path.Length <= 0)
                {
                    IsValidName = false;
                }
            }
        }
        public string Extention { get; set; }
        public bool IsValidName { get; set; }

        public string Fullname
        {
            get
            {
                return string.Concat(Name, Extention);
            }
        }
    }
}
