using System;
using System.Collections.Generic;
using System.Text;

namespace föreläsning13
{
    public class Deck
    {
        public static readonly Random random = new Random();
        public List<Card> Cards { get; set; } /*= new List<Card>();*/ // kan skrivas såhär för ny lista så man kan lägga till saker
        //public List<Card> Cards //går ej att styra, detta är en variabel. Get set gör den till en property

        public Deck() 
        {
            //fyll vår kortlek med spelkort
            FillDeckWithCards();
            //Cards = new List<Card> ///visade någonting intressant
            //{
            //    new Card
            //    {
            //      CardType="Knekt",
            //      Rank=11,
            //      Suit="Hjärter"
                  
            //    }
            //};
        }

        private void FillDeckWithCards()
        {
            {
                Cards = new List<Card>();
                for (int i = 1; i < 5; i++) //4 sviter
                {
                    for (int j = 2; j < 15; j++) //13 kort (totalt 52 (4x13))
                    {
                        Card card = new Card();    //skapa nytt kort
                                                   // tilldelar sviter
                        if (i == 1)
                            card.Suit = "Spader";
                        else if (i == 2)
                            card.Suit = "Klöver";
                        else if (i == 3)
                            card.Suit = "Hjärter";
                        else if (i == 4)
                            card.Suit = "Ruter";
                        // tilldela värde
                        card.Rank = j;
                        // tilldela klädda kort
                        if (j == 14)
                            card.CardType = "Ess";
                        else if (j == 13)
                            card.CardType = "Kung";
                        else if (j == 12)
                            card.CardType = "Dam";
                        else if (j == 11)
                            card.CardType = "Knekt";
                        else if (j <= 10 && j >= 2)
                            card.CardType = j.ToString();
                        Cards.Add(card);                  
                                           
                                                                      
                        
                        
                        
                    }




                }



            }
            
        }

        public Card GetCard() 
        {
            int randomIndex = random.Next(Cards.Count);
            Card card = Cards[randomIndex];
            Cards.RemoveAt(randomIndex); //alla metoder kräver parenteser
            return card;
        }

    }

}
