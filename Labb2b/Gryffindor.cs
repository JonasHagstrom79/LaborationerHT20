using System;
using System.Collections.Generic;
using System.Text;

namespace Labb2b
{
    public class Gryffindor : House
    {
        public Gryffindor()
        {
            HouseGhost = "Nästan huvudlöse Nick";
            Mascot = "Lejon";
            Password = "en ensam trollkarl";
            Members = new List<Wizard>(); //Måste ha en egen separat lista för boxarna test
        }
    }
}
