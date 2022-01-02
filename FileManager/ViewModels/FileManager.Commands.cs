using FileManager.ViewModels.Commands;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace FileManager.ViewModels
{
    /// <summary>
    /// This is the main\root ViewModel
    /// </summary>
    public partial class FileManager
    {
        private ICommand _command;

        public ICommand Command => _command ?? (_command = new BrowsePathCommand(
                   x =>
                   {
                       BrowsePath();
                   }));

        private static void BrowsePath()
        {

        }
    }
}
