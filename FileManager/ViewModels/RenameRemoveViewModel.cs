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

        private string RemoveFromLast(int last, int skipLast, string file)
        {
            var newName = string.Concat(file.Substring(0, skipLast), file.Substring(last + skipLast));
            file = newName;
            return Reverse(newName);
        }

        private string RemoveFromFirst(int first, int skipFirst, string file)
        {
            var newName = string.Concat(file.Substring(0, skipFirst), file.Substring(first + skipFirst));
            file = newName;
            return newName;
        }

        //Todo: Extract an entension class
        public static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        internal string Remove(string newName)
        {
            newName = RemoveFromFirst(First, SkipFirst, newName);
            newName = RemoveFromLast(Last, SkipLast, Reverse(newName));
            return newName;
        }
    }
}
