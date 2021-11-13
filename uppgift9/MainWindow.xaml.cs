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

namespace uppgift9
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

        private void txtCtrl_Click(object sender, RoutedEventArgs e)
        {

            string name;
            int age = 0;
            

            name = txtName.Text;

            age = int.Parse(txtAge.Text);

            if (txtAdult.IsChecked == true)
            {
                if (age >= 15)
                {
                    txtMsg.Text = ($"Hej {name}. Du är {age} år gammal och får se alla filmer.");
                }

                if (age >= 11 && age <= 14)
                {
                    txtMsg.Text = ($"Hej {name}. Du är {age} år gammal och då får du se filmer med åldersgräns upp till 11 år. Det spelar ingen roll att du går tillsammmnas med en vuxen");
                }

                if (age >= 7 && age <= 10)
                {
                    txtMsg.Text = ($"Hej {name}. Du är {age} år gammal och får se filmer med ådersgräns upp till 11 år eftersom du har en vuxen med dig");
                }

                if (age <= 6)
                {
                    txtMsg.Text = ($"Hej {name}. Du är {age} år gammal och får se filmer med åldersgräns upp till 7 år eftersom du har en vuxen med dig");
                }
            }

            if (txtMinor.IsChecked == true)
            {
                if (age >= 15)
                {
                    txtMsg.Text = ($"Hej {name}. Du är {age} år gammal och får se alla filmer.");
                }

                if (age >= 11 && age <= 14)
                {
                    txtMsg.Text = ($"Hej {name}. Du är {age} år gammal och då får du se filmer med åldersgräns upp till 11 år.");
                }

                if (age >= 7 && age <= 10)
                {
                    txtMsg.Text = ($"Hej {name}. Du är {age} år gammal och får se filmer med ådersgräns upp till 7 år");
                }

                if (age <= 6)
                {
                    txtMsg.Text = ($"Hej {name}. Du är {age} år gammal och får se filmer som är barntillåtna");
                }
            }


            
        }

        
    }
}
