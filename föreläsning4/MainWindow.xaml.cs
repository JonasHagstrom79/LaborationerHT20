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

namespace föreläsning4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static readonly Random random = new Random(); //ändras aldrig med static readonly
        double probability;
        //Konstruktor = en metod som körs när vi skapar vårt objekt
        public MainWindow()
        {
            InitializeComponent();
            //här kan vi lägga in kod som skall köras när programmet startas
            // bara vid start, aldrig mer
            probability = random.NextDouble();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //double probability;
            int prize, pay;
            bool result;
            
            // Skapar en slumpgenerator = maskinene docs.microsoft.com
            Random random;

              //new skapar ett nytt objekt av random, alla metoder och klasser har alltid parenteser

            // slumpa fram sannolikheten
            //probability = random.NextDouble();

            probability = Math.Round(probability, 3);
            prize = int.Parse(txtPrize.Text);
            pay = int.Parse(txtPay.Text);

            //1 (0.2 * 50 - 9)

            double factor = 1 * (probability * prize - pay);

            // ska jag satsa eller inte?
            // ja om > 1 annars nej

            if (factor > 0)
            {
                result = true;
            }
            else 
            {
                result = false;
            }

            chkWortToGamble.IsChecked = result;
            progressProbability.Value = probability; //länkad till baren
            txtProbability.Text = probability.ToString();
        }
    }
}
