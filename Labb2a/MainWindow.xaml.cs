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

namespace Labb2a
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Hogwarts hogwarts = new Hogwarts();
        Hufflepuff hufflepuff;
        Gryffindor gryffindor;
        Ravenclaw rawenclaw;
        Slytherin slytherin;
        Wizard members;
        public MainWindow()
        {
            InitializeComponent();
            AddComboBox();
            //ToString(); //ej här 
        }


        public void AddComboBox()
        {
            cboTest.Items.Add(hogwarts.Gryffindor);
            cboTest.Items.Add(hogwarts.Hufflepuff);
            cboTest.Items.Add(hogwarts.Slytherin);
            cboTest.Items.Add(hogwarts.Ravenclaw);
        }                                   

        //public override string ToString()
        //{
        //    return this.GetType().Name;
        //}




        //private void btnTest_Click(object sender, RoutedEventArgs e) //gammla test?
        //{           

        //}



        private void cboHouses_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
            
            

        }

        private void btnChangePassword_Click(object sender, RoutedEventArgs e)
        {
            //combobox välj
            //House.SetPassword( txtNewPassword.Text); 
        }
    }
}
