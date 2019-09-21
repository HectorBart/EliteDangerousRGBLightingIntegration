using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using EliteDangerousRGBLightingIntegration.Applications;

namespace EliteDangerousRGBLightingIntegration
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

        public string logFolder;

        private void Folder_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog dialog = new FolderBrowserDialog())
            {
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    string logFolder = dialog.SelectedPath;
                    logLocation.Text = logFolder;

                    this.logFolder = logFolder;
                }
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            bool run = true;

            if(lifx.IsChecked == true)
            {
                LIFX lifx = new LIFX();

                lifx.lifxEnabled = true;

                System.Windows.Controls.TextBox lifxKey = (System.Windows.Controls.TextBox)sender;
                string lifxKeyString = lifxKey.Text;

                lifx.lifxKeyString = lifxKeyString;
                // setup lifx
            }

            if(chroma.IsChecked == true)
            {
                Chroma chroma = new Chroma();

                chroma.chromaEnabled = true;
                // setup chroma
            }

            if(cue.IsChecked == true)
            {
                // setup cue
            }

            if(hue.IsChecked == true)
            {
                // setup hue
            }

            while (run)
            {
                string log = GetLogs.GetLogFile(this.logFolder);


            }

        }
    }
}
