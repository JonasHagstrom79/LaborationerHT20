using System;
using System.Collections.Generic;
using System.Text;

namespace Labb2b
{
    public class Hufflepuff : House
    {
        public Hufflepuff()
        {
            HouseGhost = "Den tjocke munkbrodern";
            Mascot = "Grävling"; 
            Password = "en ensam trollkarl";
            Members = new List<Wizard>(); //Måste ha lista här annaars kraschar programmet
        }        
    }
}
