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

namespace uppgift5
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

        private void sum_Click(object sender, RoutedEventArgs e)
        {
            int num1 = 0, num2 = 0, totalSum = 0;

            num1 = int.Parse(txtNum1.Text);
            num2 = int.Parse(txtNum2.Text);

            totalSum = num1 + num2;

            txtTotal.Text = totalSum.ToString();
        }

        private void clear_Click(object sender, RoutedEventArgs e)
        {
            txtNum1.Clear(); 
            txtNum2.Clear(); 
            txtTotal.Clear();
        }
    }
}
