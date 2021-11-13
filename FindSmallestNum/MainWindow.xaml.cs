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

namespace FindSmallestNum
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double[] numbers;

        public MainWindow()
        {
            InitializeComponent();
            numbers = new double[] { 34, 15, 88, 2, -35, 99, 129283, -35.1 };
            lstNumbers.ItemsSource = null; //glömmer bort listan
            lstNumbers.ItemsSource = numbers; //tilldelar den igen
        }

        //private double FindValue(bool findLowest)
        //{
        //    if (findLowest)
        //    {
        //        return FindLowestValue();
        //    }
        //    else
        //    { 
        //        return FindHighestValue();
        //    }
                        
        //}

        //private double FindLowestValue(double[] numbers)
        //{

        //    double lowestValue = double.MaxValue;
        //    foreach (double value in numbers)
        //    {
        //        if (value <= lowestValue)
        //        {
        //            lowestValue = value;
        //        }

        //        return lowestValue;
        //}

        //private double DifferenceMaxMin()
        //{
        //    double difference = findHighestValue() - LfindowestValue();
        //    return difference;
        //}

        private void btn_Click(object sender, RoutedEventArgs e)
        {
                double lowestValue = double.MaxValue;
                //vilket tal är lägst?

                foreach (double value in numbers)
                {
                    if (value <= lowestValue)
                    {
                        lowestValue = value;
                    }
                }
                lstNumbers.SelectedValue = lowestValue;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double highestValue = double.MinValue;
            //vilket tal är högst?

            foreach (double value in numbers)
            {
                if (value >= highestValue)
                {
                    highestValue = value;
                }
            }
            lstNumbers.SelectedValue = highestValue;
        }

        private void btnSelectValue_Click(object sender, RoutedEventArgs e)
        {
            if (lstNumbers.SelectedItem == null)
            {
                return;
            }
            //string[] names = { "a, b" };
            //lstNumbers.ItemsSource = null;
            //lstNumbers.ItemsSource = names;
            double selectedValue = (double)lstNumbers.SelectedItem;

            MessageBox.Show(selectedValue.ToString());
        }
    }
}