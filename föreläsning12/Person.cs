using System;
using System.Collections.Generic;
using System.Text;

namespace föreläsning12
{
    public class Person
    {
        public string FirstName { get; private set; } //man kan styra om det är privat, för att kunna göra kontroller

        public string LastName { get; private set; }

        //public string Initials //Ett sätt tt returnera initialerna
        //{
        //    get 
        //    {
        //        return $"{FirstName[0]} {LastName[0]}";
        //    }
        //}
        public string Initials => $"{FirstName[0]} {LastName[0]}"; //Samma som ovan pilen är vad som gör att det går att returneras

        #region Fields

        //private List<Quote>
        private List<string> quotesString;
        private static readonly Random random = new Random(); //slumpgeneratorn
        #endregion
        public Person()
        {
            InitQuotes();
        }
        #region Private Methods
        private void InitQuotes()
        {
            quotesString = new List<string>()
            {
                "Blabbla",
                "Hej och hå",
                "Kalle Anka",
                "Arne Anka"
            };
        }

        quotes = new List<Quote>() //här, 10:34
        {
            
        }
            
            
        #endregion

        #region Public Methods
        public void SetName(string firstname, string lastname) //sätta väre med lite olika kontroller
        {
            FirstName = firstname;
            LastName = lastname;
        }
#       
        public string GetRandomQuote() 
        {
            int randomValue = random.Next(quotes.Count);    //slumpar citat, den har ett inbyggt värde som heter Count som räknar hur många quotes i vår lista
            return quotes[randomValue]; //slumpar tillbaka
        }

        
        #endregion
#
#
    }
}
