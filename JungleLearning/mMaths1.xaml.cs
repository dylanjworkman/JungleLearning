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

namespace JungleLearning
{
    /// <summary>
    /// Interaction logic for mMaths1.xaml
    /// </summary>
    public partial class mMaths1 : Window
    {
        int a, b, c;

        public mMaths1()
        {
            InitializeComponent();
        }

        private void BtnAddition_Click(object sender, RoutedEventArgs e)
        {
            //adds two numbers (a and b together)
            a = Convert.ToInt32(num1.Text);
            b = Convert.ToInt32(num2.Text);
            c = a + b;
            answerbox.Text = c.ToString();
        }
        //FIX CODE BELOW ASAP!
        private void BtnSubtraction_Click(object sender, RoutedEventArgs e)
        {
            //subtracts two numbers
            a = Convert.ToInt32(num1.Text);
            b = Convert.ToInt32(num2.Text);
            c = a - b;
            answerbox.Text = c.ToString();
        }

        private void BtnMultiply_Click(object sender, RoutedEventArgs e)
        {
            //multiplies two numbers
            a = Convert.ToInt32(num1.Text);
            b = Convert.ToInt32(num2.Text);
            c = a * b;
            answerbox.Text = c.ToString();
        }

        private void BtnDivision_Click(object sender, RoutedEventArgs e)
        {
            //divides two numbers
            a = Convert.ToInt32(num1.Text);
            b = Convert.ToInt32(num2.Text);
            c = a / b;
            answerbox.Text = c.ToString();
        }

    }
}
