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

namespace uppgift11
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int numUp, numDown;
        double numPercent =50;

        //Random random = new Random();
        public MainWindow()
        {
            InitializeComponent();
            progressProbability.Value = numPercent; //Variablers namn kan inte vara samma som i XAML :P            
            progressProbability.Value = 50;

        }

        private void btnMore_Click(object sender, RoutedEventArgs e)
        {

            progressProbability.Value = progressProbability.Value + 5; //Variablers namn kan inte vara samma som i XAML :P
            lblPercent.Content = progressProbability.Value;

            
        }

        private void btnLess_Click(object sender, RoutedEventArgs e)
        {
            progressProbability.Value = progressProbability.Value - 5; 
            lblPercent.Content = progressProbability.Value;
        }

        private void btnStart_Click(object sender, RoutedEventArgs e)
        {
            int tries, random; 

            tries = int.Parse(txtTries.Text);

            Random numOfTries = new Random();
            //int random = random.Next(100);

            //gör en random 1och2?
            for (int counter = 0; counter < tries; counter++)
            {
                random = numOfTries.Next(1, 100); //1, 102? Verkar inte göra skillnad, den "tappar" tal i alla fall?

                if (random > progressProbability.Value)
                {
                    numUp++;
                }

                else if (random < progressProbability.Value) 
                {
                    numDown++;
                }

            }

            txtUp.Text = numUp.ToString();
            txtDown.Text = numDown.ToString();

            numUp = 0;
            numDown = 0;

            


        }
    }
}
