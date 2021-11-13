using Microsoft.VisualBasic.CompilerServices;
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

namespace uppgift10
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    

    public partial class MainWindow : Window
    {
        public static readonly Random slump = new Random();
        int slumptal, counter;
        
        public MainWindow()
        {
            InitializeComponent();
            Guess.IsEnabled = false;

        }

        private void Random_Click(object sender, RoutedEventArgs e)
        {
            slumptal = slump.Next(1000);
            Guess.IsEnabled = true;
            //MessageBox.Show($"{slumptal}"); //För att testa slumpgeneratorn
        }

        private void Guess_Click(object sender, RoutedEventArgs e)
        {


            int number = 0; 
            counter = counter++;
                        
            number = int.Parse(txtNum.Text);


            if (number == slumptal)
            {
                counter++;
                txtMessage.Text = ($"Gratulerar, du gissade helt rätt. Det tog {counter} försök att gissa rätt nummer");                
            }
            
            if (number >= slumptal + 100)
            {
                txtMessage.Text = ("Oh, du är inte ens nära. Du gissade alldeles för högt");
                counter++;
            }
            
            if (number <= slumptal - 100)
            {
                txtMessage.Text = ("Oh, du är inte ens nära. Du gissade alldeles för lågt");
                counter++;
            }
            
            if (number >= slumptal + 1 && number <= slumptal +99 )
            {
                txtMessage.Text = ("Du gissade ganska nära, men för högt");
                counter++;
            }
            
            if (number <= slumptal -1 && number >= slumptal - 99)
            {
                txtMessage.Text = ("Du gissade ganska nära, men för lågt");
                counter++;
            }
        }
    }
}
