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

namespace uppgift8
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
            int numGal = 0, numSik = 0, numKnu = 0;
            double numSek = 0;
            

            numGal = int.Parse(txtGal.Text); //Om man vill att nåt måste skrivas i rutan
            numSik = int.Parse(txtSik.Text);
            numKnu = int.Parse(txtKnu.Text);
            

            numSek = numGal * 62.02 + numSik * 3.64 + numKnu * 0.12 ;

            
            //Math.Round(numSek,0); //Anvrundar antal decimaler

            txtSek.Text = numSek.ToString();
            txtSek.Text = ($"{Math.Round(numSek)} SEK");          
           

            

            
            
             //Math.Round(minVariabel,2);

        }
    }
}
