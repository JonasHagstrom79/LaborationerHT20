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

namespace uppgift6
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double numOne = 0, numTwoo = 0, numTotal = 0;


        public MainWindow()
        {
           
            InitializeComponent();
            
        }

        private void add_Click(object sender, RoutedEventArgs e)
        {
            //double numOne =0, numTwoo =0, numTotal =0; //Variabler deklarerade

            numOne = double.Parse(txtNumOne.Text);   //Gör om till sträng med Parse
            numTwoo = double.Parse(txtNumTwoo.Text); //Gör om från decimaltal till sträng
            
            numTotal = numOne + numTwoo;

            
            txtTotal.Text = numTotal.ToString(); //Hittar på en variabel txtTotal.Text och ger den värdet av numTotal konverterat till sträng
            
            txtShow.Content = "Summa"; // ändrar innehåll på variabeln txtShow
        }

        private void sub_Click(object sender, RoutedEventArgs e)
        {
            //double numOne = 0, numTwoo = 0, numTotal = 0;

            numOne = double.Parse(txtNumOne.Text);
            numTwoo = double.Parse(txtNumTwoo.Text);

            numTotal = numOne - numTwoo;

            txtTotal.Text = numTotal.ToString();

            txtShow.Content = "Differens";

        }

        private void multi_Click(object sender, RoutedEventArgs e)
        {
            numOne = double.Parse(txtNumOne.Text);
            numTwoo = double.Parse(txtNumTwoo.Text);

            numTotal = numOne * numTwoo;

            txtTotal.Text = numTotal.ToString();

            txtShow.Content = "Produkt";

        }

        private void divi_Click(object sender, RoutedEventArgs e)
        {
            numOne = double.Parse(txtNumOne.Text);
            numTwoo = double.Parse(txtNumTwoo.Text);

            numTotal = numOne / numTwoo;

            txtTotal.Text = numTotal.ToString();

            txtShow.Content = "Kvot";
        }

        private void clear_Click(object sender, RoutedEventArgs e)
        {
            txtNumOne.Clear();
            txtNumTwoo.Clear();
            txtTotal.Clear();
        }
    }
}
