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

namespace föreläsning5
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
            string name = "Erik";
            char charachter = 'E', smallchar = 'e'; // '' enkelfnuttar vid en bokstav

            // Array är en variabel som kan innehålla flera värden(Progsharp Kap 5)
            // en array är indexerad, man kan komma åt någonting på en given plats om amn vill
            //"en sträng är en array av chars" skulle man kunna säga
            // första facket är 0
            MessageBox.Show(name[2].ToString()); //ger i

            //skapar länder
            // 0, 1, 2 = indexvärden
            string[] countries = new string[3];

            countries[0] = "Sverige";
            countries[1] = "Norge";
            countries[2] = "Finland";

            string[] fruits = new string[]
            {
                "banana",
                "apple",
                "orange"
            };

            //hämta ett specifikt land och frukt

            MessageBox.Show($"I {countries[2]} äter man {fruits[0]}");


            //läxan blir yatzi, finns det lägen att fundera på om det finns lägen där vi har variabler med samma värde
            // kan vi använda oss av array, där vi istället för att skapa separata variabler kan göra en array?
            //få koden att bli bättre
        }

    }
}
