using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManager.ViewModels
{
    public class RemoveViewModel: ViewModelBase
    {
        #region All types of remove View models as property

        private RenameRemoveViewModel _renameVm = new();

        public RenameRemoveViewModel RemoveVm
        {
            get { return _renameVm; }
            set { _renameVm = value; }
        }

        #endregion

        #region Top level rename operations list

        private bool _isReplacing;

        public bool IsReplacing
        {
            get { return _isReplacing; }
            set { _isReplacing = value; }
        }

        private bool _isRemoving;

        public bool IsRemoving
        {
            get { return _isRemoving; }
            set
            {
                _isRemoving = value;
                //UpdateNewFiles();
            }
        }

        private bool _isAdding;

        public bool IsAdding
        {
            get { return _isAdding; }
            set { _isAdding = value; }
        }

        private bool _isNumbering;

        public bool IsNumbering
        {
            get { return _isNumbering; }
            set { _isNumbering = value; }
        }


        #endregion


        private string _filePath;

        public string FilePath
        {
            get { return _filePath; }
            set
            {
                _filePath = value;
                UpdateExistingFiles(_filePath);
            }
        }


        private IList<string> _existingFiles = new List<string>();

        public IList<string> ExistingFiles
        {
            get { return _existingFiles; }
            set
            {
                _existingFiles = value;
                OnPropertyChanged();
            }
        }

        private IList<string> _selectedFiles;

        public IList<string> SelectedFiles
        {
            get { return _selectedFiles; }
            set
            {
                _selectedFiles = value;
            }
        }

        private IList<string> _newFiles;

        public IList<string> NewFiles
        {
            get { return _newFiles; }
            set { _newFiles = value; }
        }

        private void UpdateExistingFiles(string newPath)
        {
            if (Directory.Exists(newPath) == false)
            {
                Trace.WriteLine("New file path is not valid");
                return;
            }

            var files= Directory.EnumerateFiles(newPath);
            ExistingFiles = files.ToList();
        }
    }
}
