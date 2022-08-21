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
using System.IO;

namespace ConfusedFN
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

        private void LaunchBtn_Click(object sender, RoutedEventArgs e)
        {
            string FNPath;
            string FNExePath;
            string FNExeName;
            string LaunchArgs;

            FNPath = PathTextBox.Text;
            FNExePath = System.IO.Path.Combine(this.PathTextBox.Text, "FortniteGameBinariesWin64");
            FNExeName = "FortniteClient-Win64-Shipping.exe";
            LaunchArgs = "-AUTH_LOGIN=" + MailTextBox.Text + " -AUTH_PASSWORD=" + PassTextBox.Text + " -AUTH_TYPE=epic" + "-noeac -fromfl=be -fltoken=h1h4370717422124b232eFac -epicapp=Fortnite -epicenv=Prod -epiclocale=en-us -epicportal";
        }
    }
}
