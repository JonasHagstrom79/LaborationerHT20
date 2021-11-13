using System;
using System.Collections.Generic;
using System.Text;

namespace föreläsning10
{
    public class Person
    {
        /// <summary>
        /// egenskapen namn kan både läsa och ändra
        /// </summary>
        //lägga till egenskaper som vi kan ge värden, alla properties(egenskaper) skriivs med stor bokstav
        public string Name { get; set; }//man kan hämta get, och sätta set egenskaper
        public double Length { get; set; }
        /// <summary>
        /// Egenskapen password kan bara läsas
        /// </summary>
        public string Password { get; set; } //skriv prop och dubbel tab, ta bort set så är den red only'

        public double Weight { get; set; }


        public double CalculateBmi() 
        {
            double bmi = Weight / (Length * Length);
            return bmi;
        }

        public override string ToString() //override för att göra namnen(Erik och Omar) till string
        {
            return Name;
            return $"{Name}: {Length}";
        }


    }
}
