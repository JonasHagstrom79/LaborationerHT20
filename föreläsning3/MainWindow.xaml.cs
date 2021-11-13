using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
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

namespace föreläsning3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window

    {
        private static readonly Random random = new Random();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnSum_Click(object sender, RoutedEventArgs e)
        {
            int sumOnes = 0, sumTwos = 0, sumThrees = 0, sumFours = 0, sumFives = 0, sumSixes = 0, totalSum =0;
            int dieOne, dieTwo, dieThree, dieFour, dieFive, dieSix;

            dieOne = random.Next(1, 7); //slumpar mellan 1-6
            dieTwo = random.Next(6) + 1; //Ett annat sätt att göra samma som ovan
            dieThree = random.Next(1, 7);
            dieFour = random.Next(1, 7);
            dieFive = random.Next(1, 7);
            dieSix = random.Next(1, 7);
                //Konventera från sträng till integer

            //diceOne = int.Parse(txtOnes.Text);

            //Konvertera från integer till sträng

            //txtOnes.Text = sumOnes.ToString();
            //txtTwos.Text = sumTwos.ToString();
            //txtThrees.Tex = sumThrees.ToString();
            //txtFours.Text = sumFours.ToString();
            //txtFives.Text = sumFives.ToString();
            //txtSixes.Text = sumSixes.ToString();  

            //Refaktorera ctrl +r +r håll in alt för att markera saker

            sumOnes = int.Parse(txtOnes.Text);
            sumTwos = int.Parse(txtTwos.Text);
            sumThrees = int.Parse(txtThrees.Text);
            sumFours = int.Parse(txtFours.Text);
            sumFives = int.Parse(txtFives.Text);
            sumSixes = int.Parse(txtSixes.Text);
                        
            totalSum = sumOnes + sumTwos + sumThrees + sumFours + sumFives + sumSixes;




            // Kommer vår totala summa att vara 63 poäng eller högre?
            // om ja -->bonus
            // om nej -->ingen bonus

            // IF-sats om (villkor som kan sägas vara sant eller falskt), dubbla == ska det vara, jämförelser kräver det = blir tilldelat ett värde
            //*1 if (totalSum == 62) // vi vill åt totalsum, >= större än eller lika med, == lika med, != inte lika med, < mindre än, <= mindre eller lika med, > större än
            //{
            //    totalSum += 25; //om totalsum är större än 62 så läggs 50 på i bonus
            //    txtBonus.Text = "25"; // Visar bonus 50 om man får det
            //}

            //else if (totalSum >= 63) //
            //{
            //    totalSum += 50;
            //    txtBonus.Text = "50";
            //}

            //else if (totalSum == 50)
            //{
            //    totalSum += 15;
            //    txtBonus.Text = "15";
            //*1 }

            //*2 lägg till en ifsats med flera villkor
            //*2 om summs == 50 eller summa == 25

            if (totalSum == 50 | totalSum == 25) //& betyder och i boolska, | betyder eller
            {
                totalSum += 25;
                txtBonus.Text = "25";
            }

            else if (totalSum >= 63) //ändra till else if annars får vi dubbel bonus
            {
                totalSum += 50;
                txtBonus.Text = "50";
            }

            else
            {
                txtBonus.Text = "0"; //Om ej +62 så skrivs bonus som 0
            }
            
            txtTotal.Text = totalSum.ToString();
            //sumTwos = int.Parse(txtTwos.Text);
            //totalSum = sumOnes + sumTwos;
            //txtTotal.Text = totalSum.ToString();


            //txtTotal.Text = sumOnes.ToString(); //summan av ettorna hamnar på totalen
        }
        /// <summary>
        /// Rensar alla textboxar
        /// </summary>
        private void ClearUI() 
        {
            txtOnes.Clear();
            txtTwos.Clear();
            txtThrees.Clear();
            txtFours.Clear();
        }

        private void CheckSavedDice() 
        {
            CheckSavedDice[0] = (bool)chkSavedDieOne.IsChecked;  //(bool) måste vara framför eftersom värdet blir neutralt annars
            CheckSavedDice[1] = (bool)chkSavedDieTwo.IsChecked;
            CheckSavedDice[2] = (bool)chkSavedDieThree.IsChecked;
            CheckSavedDice[3] = (bool)chkSavedDieFour.IsChecked;
            CheckSavedDice[4] = (bool)chkSavedDieFive.IsChecked;
        }

        public int[] RollDices() 
        {
            for (int i = 0; i < numberOfDice; i++)
            {
                dices[i] = RollDie();
            }
            return dices;
        }

        private int RollDie() 
        {
            return random.Next(1, 7);
        }

        private void btnRollDice_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
