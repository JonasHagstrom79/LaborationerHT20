using System;
using System.Collections.Generic;
using System.Text;

namespace Labb2b
{
    public class Ravenclaw : House
    {
        public Ravenclaw()
        {
            HouseGhost = "Grå Damen";
            Mascot = "Örn";
            Password = "en ensam trollkarl";
            Members = new List<Wizard>(); //Måste ha en egen separat lista för boxarna
        }
    }
}
