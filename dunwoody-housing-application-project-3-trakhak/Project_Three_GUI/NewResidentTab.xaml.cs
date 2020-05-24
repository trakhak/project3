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
using System.Windows.Shapes;

namespace Project_Three_GUI
{
    /// <summary>
    /// Interaction logic for NewResidentTab.xaml
    /// </summary>
    public partial class NewResidentTab : Window
    {
        public NewResidentTab()
        {
            InitializeComponent();
        }

        private void ReturnButton(object sender, RoutedEventArgs e)
        {
            SelectionTab navigateToSelection = new SelectionTab();
            navigateToSelection.Show();
            this.Close();
        }

        private void BtnLoginSubmit_Click_1(object sender, RoutedEventArgs e)
        {

        }
    }
}
