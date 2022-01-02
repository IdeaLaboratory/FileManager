using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace FileManager.ViewModels.Commands
{
    internal class BrowsePathCommand : RelayCommandBase
    {
        public BrowsePathCommand(Action<object> execute) : base(execute)
        {
        }
    }
}
