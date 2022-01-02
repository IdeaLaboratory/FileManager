﻿using System;
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
        public string AppTi { get; set; } = "File";
        
        private string _filePath;

        public string FilePath
        {
            get { return _filePath; }
            set { _filePath = value; }
        }

        private RenameRemoveViewModel _renameVm = new RenameRemoveViewModel();

        public  RenameRemoveViewModel RenameVm  
        {
            get { return _renameVm; }
            set { _renameVm = value; }
        }


    }
}
