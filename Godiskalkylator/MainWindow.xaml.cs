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

namespace Godiskalkylator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string filename = "CandyList.json";
        
       
        public MainWindow()
        {
            InitializeComponent();
            OpenFile();
            
        }
        Person person; //skapar ett objekt av klassen Person
             

        CandyCalculator candycalculator = new CandyCalculator();

        /// <summary>
        /// raderar listan people
        /// </summary>
        public void ClearList()
        {
            candycalculator.people.Clear();
            lstPerson.ItemsSource = null;    
            
        }

        /// <summary>
        /// raderar texten i textboxarna
        /// </summary>
        public void ClearText() 
        {
            txtFirstName.Clear();
            txtLastName.Clear();
            txtAge.Clear();
        }


        #region Save and Load file Methods
        /// <summary>
        /// Saves a file as CandyList.json @ bin/Debug/netcoreapp3.1
        /// </summary>
        public void SaveFile()
        {
            //string filename = "CandyList.json";
            FileHandler.Save(candycalculator.people, filename);
        }

        /// <summary>
        /// Open the file CandyList.json @ bin/Debug/netcoreapp3.1
        /// </summary>
        public void OpenFile() 
        {
            candycalculator.people = FileHandler.Open<List<Person>>("CandyList.json");
            lstPerson.ItemsSource = candycalculator.people;
        }
        #endregion

        /// <summary>
        /// metod som lägger till en person till listan
        /// </summary>
        public void AddPerson() 
        {
             
            /*string firstname = txtFirstName.Text;*/ //gjorde helt rätt :)))))
            string lastname = txtLastName.Text;
            int age = int.Parse(txtAge.Text);

            person = new Person(); //skapar ett objekt av klassen Person, objektet heter person. Listan är <Person>
            {
                person.FirstName = txtFirstName.Text;/*firstname;*/
                person.LastName = lastname;
                person.Age = age;
            }
            candycalculator.people.Add(person); //lägger till en person till listan på varje knapptryck. listan heter people

            lstPerson.ItemsSource = null;
            lstPerson.ItemsSource = candycalculator.people; //people = hur många på listan, count +1 för varje person

            

            ClearText();

            SaveFile();
        }


        
        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            AddPerson();
        }

        private void btnDistr_Click(object sender, RoutedEventArgs e)
        {
            

            
            int candy = int.Parse(txtCandy.Text); //läser in värdet

            bool byAge = radioAge.IsChecked.Value;
            bool byFirstName = radioFirstName.IsChecked.Value;
            bool byLastName = radioLastName.IsChecked.Value;

            candycalculator.DistributeCandy(candy, byAge, byFirstName, byLastName); //när du skapat nåt från CandyCalculator kan du ropa på metoder därifrån :)

            lstPerson.ItemsSource = null;
            lstPerson.ItemsSource = candycalculator.people;
            

        }

        private void btnClearList_Click(object sender, RoutedEventArgs e)
        {
            ClearList();
        }

        
    }
} 
