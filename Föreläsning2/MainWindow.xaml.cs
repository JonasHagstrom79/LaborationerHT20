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

namespace Föreläsning2
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

        private void btn_Click(object sender, RoutedEventArgs e)
        {
            //datatyp
            //värde
            //C# är ett hårt typat programmeringsspråk

            // sätter datatypen, det är en sträng(meningar och ord)
            string myName; //Om det blir grönt under så är den deklarerad

            //vi har också gett den ett namn =myName
            //vi vill också tilldela den ett värde
            myName = "Erik";

            string lastName = "Öberg", fullName;

            MessageBox.Show($"{myName} {lastName}");
            //txtName.Text = myName;


            //int numberOfConfirmedCases = //min sjukt avancerade metod
        }

        private void btnOk_Click(object sender, RoutedEventArgs e)
        {
            string firstName, lastName, fullName; // två variabler av typen string
            int age=0;
            double preciseAge;

            // flyttal, float alltså decimaler heter double 

            firstName = txtName.Text;
            lastName = txtLastName.Text;
            //age = txtAge.Text; Funkar ej
            //age = int.Parse(txtAge.Text); //Använd int.Parse för att göra om string till int
            //preciseAge = double.Parse(txtAge.Text);
            //age = int.Parse(txtAge.Text) + 3; //lägger till 3 år direkt
            //fullName = firstName + lastName; // ger inget mellanslag

            fullName = $"{firstName} {lastName}";

            // lägger på 3 år
            //age = age + 3; //inte snyggt eller enkelt när man ska lägga på 3 år
            age += 3; //Såhär skall man skriva när man skall lägga till siffror
            
            // age *= 2; // lägger till gånger på variabeln

            //MessageBox.Show($"{firstName} {lastName}"); //första lösningen
            MessageBox.Show($"{fullName} och är {age} år gammal"); //{age + 3} ger +3

            lblAge.Content = age; //om vi skriver variabler i messageboxar ändrar vi inte på originalvärdet
            // txtName_TextChanged
        }
    }
}
