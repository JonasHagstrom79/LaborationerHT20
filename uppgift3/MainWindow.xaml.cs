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

namespace uppgift3
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

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            btn1.Content = "Klickad";
            btn2.Content = "Oklickad";
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            btn2.Content = "Klickad";
            btn1.Content = "Oklickad";
        }
    }
}
//Skriv ett program med ett formulär innehållande två knappar. Texten på båda knapparna är från
//början: ”Oklickad”. När man klickar på en av knapparna ska texten på den knappen ändras till:
//”Klickad”. Texten på den andra knappen ska då ändras till ”Oklickad”. 
//Värt att veta:
//Alla komponenter, eller controllers har egenskaper. Dessa kan få värden genom att du själv skriver in dem i Visual studio.
//Men dessa går också att förändra via kod. Det är vad du ska göra här. Om du behöver tips på vad egenskapen du vill
//förändra heter kan du titta i Visual studio i XAML-fönstret eller i fliken Properties.