using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManager.ViewModels
{
    public class RenameRemoveViewModel
    {
        
        public int First { get; set; } = 1;
        public int SkipFirst { get; set; } = 0;
        public int Last { get; set; } = 0;
        public int SkipLast { get; set; } = 0;

        //Rename file()
        //Call  necessary sub-objects if required
    }
}
