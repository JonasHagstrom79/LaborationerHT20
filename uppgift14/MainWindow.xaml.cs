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

namespace uppgift14
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

        private bool OnlyNumbersAllowed(string input) //man kan skriva in flera variabler, bool eller int eller double
        {
            for (int i = 0; i < input.Length; i++)
            {
                char c = input[i];
                if (char.IsLetter(c))
                {
                    return false;
                }
                //return true;
            }
            return true;
        }

        private void btnAge_Click(object sender, RoutedEventArgs e)
        {
            int /*today,*/yearsOld/*, ageNum = 0*/;

            string ageNum = txtBirthYear.Text;
            //ageXYZ = int.Parse(txtBirthYear.Text);
            if (OnlyNumbersAllowed(ageNum) == false)
            {
                MessageBox.Show("Bara siffror får fyllas i");
            }
            else
            {
                int age = int.Parse(txtBirthYear.Text);
                
                int today = DateTime.Now.Year;
                yearsOld = today - age;
                MessageBox.Show($"Du är {yearsOld} år gammal");
            }

        }
    }

}
