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
using mshtml;


namespace JungleLearning
{
    /// <summary>
    /// Interaction logic for WebBrowserWindow.xaml
    /// </summary>
    public partial class WebBrowserWindow : Window
    {
        public WebBrowserWindow()
        {
            InitializeComponent();

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            MyBrowser.Navigate(boxSearchBar.Text);
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            MyBrowser.GoBack();
        } //Allows user to navigate back through the web browser pages/tabs

        private void FwdBtn_Click(object sender, RoutedEventArgs e)
        {
            MyBrowser.GoForward();
        } //Allows user to navigate forward through the browser, however this code causes an error if the user skips too far forward to a tab that is not present/available

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MyBrowser.Refresh();
        } //Let's the user refresh the web browser

        
        private void JSinjection()
        {
            
            ///Unable to use standard HtmlElement for head, container, etc.
        }
        private void HideJSError()
        {
            //FIX IMMEDIATELY
        } //Hides all errors displayed in the web browser, this should prevent children from worrying about errors found in the browser and program

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.MyBrowser.Navigate("https://www.google.com/");
        }

        private void BtnBBC_Click(object sender, RoutedEventArgs e)
        {
            this.MyBrowser.Navigate("https://www.bbc.co.uk/bitesize/levels/z3g4d2p");
        }
    }
}
