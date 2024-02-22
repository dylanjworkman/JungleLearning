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

namespace JungleLearning
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            /// Add exit function
            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            /// Changes to help page
            Window1 help1 = new Window1();
            help1.ShowDialog();
        }

        private void BtnInternet_Click(object sender, RoutedEventArgs e)
        {
            WebBrowserWindow webTab = new WebBrowserWindow();
            webTab.ShowDialog();
        }

        private void BtnWriting_Click(object sender, RoutedEventArgs e)
        {
            zLiterateLittleLions writPage = new zLiterateLittleLions();
            writPage.ShowDialog();
        }

        private void BtnMaths_Click(object sender, RoutedEventArgs e)
        {
            mMaths1 mammalM = new mMaths1();
            mammalM.ShowDialog();
        }
    }
}

// User Interface for Main Window Complete, additional signs could be added in future (07/01/2020)
