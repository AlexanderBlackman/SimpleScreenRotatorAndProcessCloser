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
using System.Threading;
using System.Diagnostics;
//using System.Windows.Forms;
using System.Windows.Interop;
using System.Globalization;

namespace NukeExplorerChangeLanguage
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CloseExplorer_exe_Click(object sender, RoutedEventArgs e)
        {
            var proc = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = "taskkill.exe",
                    Arguments = $"/F /IM {processToKillTextBox.Text}",    //"/F /IM explorer.exe",
                    UseShellExecute = true,
                    CreateNoWindow = true
                }
            };
            Thread.Sleep(300);
            proc.Start();

        }


        private void SetLaptopToPortrait_Click(object sender, RoutedEventArgs e)
        {
            Display.Rotate(2, Display.Orientations.DEGREES_CW_270);

        }

        private void SetLaptopToLandscape_Click(object sender, RoutedEventArgs e)
        {
            Display.Rotate(2, Display.Orientations.DEGREES_CW_0);
        }



  /*      private void changeInputLanguage_Checked(object sender, RoutedEventArgs e)
        {
            if (sender is RadioButton radioButton)
            {
                string moo = radioButton.Content.ToString();
                if (moo == "Chinese")
                {
                    InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(Application.CurrentCulture);

                }
            }
        }*/
    }
}
