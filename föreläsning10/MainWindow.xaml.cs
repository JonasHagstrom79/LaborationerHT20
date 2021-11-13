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

namespace föreläsning10
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Person person2;
        List<Person> people;
        Course course;
        //Att göra readonly variabler tappar man inkapslingen
        public MainWindow()
        {
            InitializeComponent();
            course = new Course();
            course.Name = "Programmering";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //string name = "Erik"; //Helt okej ur visual studio perspektiv
            //double lenght = 1.73;
            //string careOfAdress;

            //string name2 = "Omar";
            //double length2 = 2.02;
            //string careOfAdress2; "Pelle Olsson"

            //MessageBox.Show(name);
            //*****************************************************************klass härnedan

            //skapa objekt, med tomma värden

            Person person = new Person();

            //punktnotera för att ge egenskaper
            person.Name = "Erik"; //Propertie är skiftnyckel
            person.Length = 1.73;
            person.Password = "Hemligt";

            person.Password = "Nytt lösenord";
            person.Weight = 70;

            MessageBox.Show(person.Password);
            double bmi = person.CalculateBmi();
            MessageBox.Show($"{bmi}");




            person2 = new Person
            {
                Name = "Omar", //ska vara ,
                Weight = 76,
                Length = 2.05


            };//ska vara den ; här
            

            people = new List<Person>(); //listor kan man fylla på allt eftersom, Erik och Omar nu

            people.Add(person);
            people.Add(person2);
            people.Add(person2);
            people.Add(person2);
            people.Add(person2);

            lstNames.ItemsSource = people;




            //************************************************************************
            //string[] test = new string[3]; // ny instans =0=nytt objekt, kan inte fylla på arrayer
            //string[] test2 = { "Erik", "Pelle" };



        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            //Här vill jag ändra på nåt objekt som jag har i listan, skriv alltid new när vivill ha ett nytt objekt
            person2 = new Person();
            person2.Name = "Greta";
            people.Add(person2);

            //string name = "Erik"; <<---Detta vad som händer under Ändra knapppen
            //name = "Greta";

            lstNames.ItemsSource = null;
            lstNames.ItemsSource = people;

        }

        private void btnNew_Click(object sender, RoutedEventArgs e)
        {

            Person person = new Person
            {
                Name = "Bertil"
            }; //här ska vara ;


            course.Students.Add(person);

            lstNames.ItemsSource = course.Students;
        }
        
        private void UpdateUI() 
        {
            lstNames.ItemsSource = null; //tömmer listboxen
            lstNames.ItemsSource = course.Students;
        }   
           

           



        
    }
}
