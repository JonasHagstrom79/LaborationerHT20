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

namespace föreläsning9
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
            string shuffledNames = NameShuffle("Donald Trump Jr");
            shuffledNames = NameShuffle("Nils Erik Jr Öberg");
            shuffledNames = NameShuffle("Seymor Butts");

            shuffledNames = NameShuffle("Nils Karlsson Pyssling");
        }

        //private bool TestPaths() 
        //{
        //    int random = 50;
        //    int checkValue = 50;
        //    if (random > 50)
        //    {
        //        return true;
        //    }
        //    else //lägg alltid på en else sats för att metoden inte skall bli "röd", så att den returnerar någonting
        //    {
        //        return false;
        //    }
        //}

        private int CountWhiteSpaces(string input) 
        {
            int numberOfSpaces = 0;
            foreach (char letter in input)
            {
                if (char.IsWhiteSpace(letter))
                {
                    numberOfSpaces++;
                }
            }
            return numberOfSpaces;
        }

        private int CountedWhiteSpaces(string input) 
        {
            int numberOfSpaces = 0;
            foreach (char letter in input)
            {
                if (char.IsWhiteSpace(letter) )
                {
                    numberOfSpaces++;
                }
                return numberOfSpaces;
            }
        }

        private string NameShuffle(string names, int whiteSpaceId) 
        {
            string firstName = "", lastName = "";
            int numberOfSpaces = CountedWhiteSpaces(names), countSpace =0;
            bool foundLastSpace = false;
            
            //nu vet vi antalet mellanslag.
            for (int i = 0; i < names.Length; i++)
            {
                if (char.IsWhiteSpace(names[i]))  //[i] är indexvärde som man måste jobba med
                {
                    countSpace++;
                    if (countSpace == numberOfSpaces)
                    {
                        //Vi har hittat mellanslaget
                        //Här ska vi börja
                        foundLastSpace = true;
                        continue;
                    }
                }
                else if (foundLastWhiteSpace)
                {
                    lastName += names[i].ToString();
                }
                else
                {
                    firstName += names[i];
                }
                return $"{lastName} {firstName} ";
            }
            //*********************************************************
            //if (numberOfSpaces == 1) //alternativt sätt är .Equals(1)
            //{
            //    return NameShuffle(names);
            //}
            //return "";
        }



      

        
    }


}
