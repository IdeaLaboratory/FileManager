using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManager.ViewModels
{
    /// <summary>
    /// This is the main\root ViewModel
    /// </summary>
    public partial class FileManager
    {
        public string AppTitle { get; set; } = "File Manager";

        private RemoveViewModel _renameVm = new();

        public RemoveViewModel RenameVm
        {
            get { return _renameVm; }
            set { _renameVm = value; }
        }

        public string Status { get; set; } = "Status OK";
    }
}
