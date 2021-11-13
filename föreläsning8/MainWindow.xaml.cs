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

namespace föreläsning8
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

        /// <summary>
        /// Rensar inmatad text
        /// </summary>
        private void ClearUi() //metod som rensar alla textrutor
        {
            txtInput.Clear();//tarbort text
            txtChar.Clear();//tarbort text


        }
        /// <summary>
        /// Returnerar namnet Erik
        /// </summary>
        /// <returns></returns>
        private string GetName()
        {
            return "Erik";
        }

        //exempel på uppgiften med biobesöken

        private void Button_Click(object sender, RoutedEventArgs e) 
        {
            int age = 8;
            bool validAge;
            MovieHelper helper = new MovieHelper();

            validAge = helper.HasValidAgeForMovie(15);

            if (helper.HasValidAgeForMovie(age)) 
            { 
            MessageBox.Show($"Hej du är {age} år och får se filmen")
            }
        
        
        }

        private void GåPåBio()
        {
        
        
        }

        //private void Button_Click_1(object sender, RoutedEventArgs e)
        //{

        //}
    }
}
