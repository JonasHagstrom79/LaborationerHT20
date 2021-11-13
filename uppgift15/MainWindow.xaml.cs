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

namespace uppgift15
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //int count = 0;
        public MainWindow()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Undersöker om det finns vokaler med stor bokstav i en sträng
        /// </summary>
        /// <param name=""></param>
        /// <param name=""></param>
        /// <returns></returns>

        public bool IsHighVowel(char rotv)
        {
            string highWovel = "AEIOUYÅÄÖ";

            foreach (char high in highWovel)
            {
                if (high == rotv)
                {
                    return true;
                }
            }
            return false;

        }

        public bool IsLowVowel(char rotv)
        {
            string lowWovel = "aeiouyåäö";

            foreach (char low in lowWovel)
            {
                if (low == rotv)
                {
                    return true;
                }
            }
            return false;

        }

        public bool IsVowel(char rotv)
        {
            string vowels = "aeiouyåäöAEIOUYÅÄÖ";

            foreach (char vowel in vowels)
            {
                if (vowel == rotv)
                {
                    return true;
                }
            }
            return false;
        }

        public string Jibberish(string rotv)
        {
            char[] charConverter = rotv.ToCharArray();
            for (int i = 0; i < rotv.Length; i++)
            {
                if (IsLowVowel(charConverter[i]))
                {
                    charConverter[i] = 'ö';
                }
                else if (IsHighVowel(charConverter[i]))
                {
                    charConverter[i] = 'Ö';
                }

            }
            string txtJib = new string(charConverter);
            return txtJib;
        }

        public int NumberOfVowels(string rotv)
        {
            int count = 0;

            foreach (char c in rotv)
            {

                if (IsVowel(c))
                {
                    count++;
                }
            }
            return count;

        }

        private void btnConvert_Click(object sender, RoutedEventArgs e)
        {

            string rotv = txtInput.Text;

            int count = NumberOfVowels(rotv); //kallar på metoden
            string txtJib = Jibberish(rotv);

            txtRotv.Text = $"{txtJib}";
            lblVok.Content = ($"Antal vokaler: {count}");
            //lblSign.Content = "Rotvälska";

        }



    }
}
