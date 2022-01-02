using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FileManager.Views
{
    /// <summary>
    /// Interaction logic for Rename.xaml
    /// </summary>
    public partial class RenameView : UserControl
    {
        public RenameView()
        {
            InitializeComponent();
        }

        private void DisableInsertNumber(object sender, RoutedEventArgs e)
        {
            NumberingInsertAt.IsEnabled = false;
        }

        private void EnableInsertNumber(object sender, RoutedEventArgs e)
        {
            NumberingInsertAt.IsEnabled = true;
        }
    }
}
