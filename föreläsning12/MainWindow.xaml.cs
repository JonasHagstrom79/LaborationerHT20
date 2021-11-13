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

namespace föreläsning12
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Person person;
        public MainWindow()
        {
            InitializeComponent();

            //Person person = new Person() //Första delen
            //{
            //    FirstName = "Sandra",
            //    LastName = "Hansson"

            //};


            person = new Person();
            person.SetName("Sandra", "Hansson");
        }

        private void btnQuotes_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(person.GetRandomQuote());
        }
    }
}
