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

namespace uppgift13
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

            string userInput = txtInput.Text, userChar = txtChar.Text;
            
            int count = 0;

           
            for (int i = 0; i < userInput.Length; i++)
            {
                if (userChar.Contains(userInput[i]))
                {
                    count++;
                }
            }

            lblResult.Content = ($"Hittade bokstaven {userChar} {count} gånger");
            
        }
        /// <summary>
        /// Rensar inmatad text
        /// </summary>
        

    }


}
