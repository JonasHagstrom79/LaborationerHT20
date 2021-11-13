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

namespace uppgift7
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
            //double numOne =0; 
            int numOne = 0, numTwoo = 0, numHeltal = 0, numRest = 0;

            //numOne = double.Parse(txtNumOne.Text);
            numOne = int.Parse(txtNumOne.Text);
            numTwoo = int.Parse(txtNumTwoo.Text);

            numHeltal = numOne / numTwoo;
            txtHeltal.Text = numHeltal.ToString();

            numRest = numOne % numTwoo; // % beräknar resten vid division
            txtRest.Text = numRest.ToString();

        }
    }
}
