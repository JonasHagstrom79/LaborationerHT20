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

namespace föreläsning13
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Deck deck;
        Card card, nextCard;
        int currentRank;
        public MainWindow()
        {
            InitializeComponent();
            deck = new Deck();
            card = deck.GetCard();
            currentRank = card.Rank;
            //lblRank.Content = card.Rank;
            //lblSuit.Content = card.Suit;
            ShowCard(card);
        }

        private void ShowCard(Card card)
        {
            lblRank.Content = card.Rank;
            lblSuit.Content = card.Suit;
        }

        private void GetAndShowCard() 
        {
            nextCard = deck.GetCard();
            if (nextCard == null)
            {
                MessageBox.Show("Game over");
            }
            ShowCard(nextCard);
        }

        private void btnHigher_Click(object sender, RoutedEventArgs e)
        {
            GetAndShowCard();

            bool result = IsGuessCorrect(true);
            
            
            //nextCard = deck.GetCard();
            //ShowCard(nextCard);
            //if (nextCard.Rank >= card.Rank)
            //{

            //}
            //card = nextCard;

            //nextCard.Rank = 100;
            //int antal = 5, nummer = 7;

            //antal = nummer;

            //antal = 3;
        }

        private void btnLower_Click(object sender, RoutedEventArgs e)
        {
            GetAndShowCard();
            bool result = IsGuessCorrect(false);
            //nextCard = deck.GetCard();
            //ShowCard(nextCard);
        }

        private bool IsGuessCorrect(bool guessHigher) //bool för att man ska gissa
        {
            bool nextCardIsHigherOrEqual;
            if (currentRank <= nextCard.Rank)
            {
                nextCardIsHigherOrEqual = true;
            }
            else
            {
                nextCardIsHigherOrEqual = false;
            }
            currentRank = nextCard.Rank;
            if (guessHigher && nextCardIsHigherOrEqual || (!guessHigher == false && !nextCardIsHigherOrEqual == false))
            {
                return true;
            }

            return false;

        }


    }
}    

