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
using Microsoft.Win32;

namespace Project_Three_GUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            this.Title = "hello world";
            this.WindowStartupLocation = WindowStartupLocation;
        }

        private void Window_MouseMove(object sender, MouseEventArgs e)
        {
            Title = e.GetPosition(this).ToString();
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("The App is Closing");
            this.Close();
        }

        private void BtnOpenFile_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openDlg = new OpenFileDialog();
            openDlg.ShowDialog();
        }

        private void BtnSaveFile_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveDlg = new SaveFileDialog();
            saveDlg.ShowDialog();
        }

        private void BtnLoginSubmit_Click(object sender, RoutedEventArgs e)
        {
            SelectionTab navigateToSelection = new SelectionTab();

            string txtUsername;
            string txtPassword;

            if (this.txtUsername = 'home')
            {
                if(this.txtPassword = '1234')

                    navigateToSelection.Show();
                    this.Close();

            }
            else
            {
                Console.WriteLine("Incorrect Password");
            }
        }
    }
}
