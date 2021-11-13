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

namespace uppgift12
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int count = 0;
        double[] values = new double[5];
       
        public MainWindow()
        {
            InitializeComponent();           
            
        }

        private void ClearTextAndNum() 
        {
            //values.Clear(values, 0, values.Length);
            Array.Clear(values, 0, 5);
            txtNum.Clear();
            txtValue.Clear();
            listBoxValues.ItemsSource = null;
            txtNum.Focus();
            btnOk.IsEnabled = true;
            count = 0;
            //return;
        }

        private void btnOk_Click(object sender, RoutedEventArgs e)
        {
            
            double numberInput;
            
            numberInput = double.Parse(txtNum.Text);

            double sum;


            values[count] = numberInput; 
            count++;
            


            txtNum.Clear();

            if (count == 5)
            {
                sum = (values[0] + values[1] + values[2] + values[3] + values[4]) / count;
                txtValue.Text = sum.ToString();

                btnOk.IsEnabled = false;

            }

            listBoxValues.ItemsSource = null;
            listBoxValues.ItemsSource = values;

            

        }

        private void btnReset_Click(object sender, RoutedEventArgs e)
        {
            ClearTextAndNum();
        }
    }
}
