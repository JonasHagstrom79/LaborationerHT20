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

namespace föreläsning7
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
        //accessor, hur publik metoden skall vara
        //       returvärde
        /// <summary>
        /// Räknar ut BMI
        /// </summary>
        /// <param name="mass">vikten i kilo</param>
        /// <param name="lenght">längden i meter</param>
        /// <returns></returns>
        private double CalculateBmi(double mass, double lenght) //metodnamn alltid Stor bokstav, alltid parenteser också
        {
            double bmi = mass / (lenght * lenght);
            return bmi; //skickar iväg värdet
            //beräkna bmi
        }
        /// <summary>
        /// Returnerar statusen givet bmivärdet
        /// </summary>
        /// <param name="bmi">personens bmi</param>
        /// <returns></returns>
        private string GetResultFromBmi(double bmi) //<---den tar in
        {
            string result;

            if (bmi < 18.5)
            {
                result = "undervikt";
            }
            else if (bmi >= 18.5 && bmi <= 25)
            {
                result = "normalviktig";
            }
            else
            {
                result = "överviktig";
            }
            return result;   //<<--- den skickar ut     
                
        }



        private void btnOK_Click(object sender, RoutedEventArgs e)
        {
            double mass = 75, length = 1.8;

            double bmi = CalculateBmi(mass, length);
            //double bmi = mass / (length * length); första metoden ovan

            string result = GetResultFromBmi(bmi);
            // andra metoden nedan

            //string result;

            //if (bmi < 18.5)
            //{
            //    result = "undervikt";
            //}
            //else if (bmi >= 18.5 && bmi <= 25)
            //{
            //    result = "normalviktig";
            //}
            //else
            //{
            //    result = "överviktig";
            //}

            MessageBox.Show($"Du väger {mass} kg och får ett bmi på {Math.Round(bmi, 2)}. Det betyder att du är {result}");
        }

        private void btnChk_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
