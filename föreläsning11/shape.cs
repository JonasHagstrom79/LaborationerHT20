using System;
using System.Collections.Generic;
using System.Text;

namespace föreläsning11
{
    public class shape //skriver man "abstract" efter public så får man inte skapa objekt av klassen, de är enbart en mall
    {
        public string Type { get; set; }

        public double Heighth { get; set; }

        public double Width { get; set; }

        /// <summary>
        /// Beräknar arean av figuren
        /// </summary>
        /// <returns>area</returns>
        public virtual double CalculateArea() //virtual gör den till polymorfism, man kan 
        {
            return Heighth * Width;
        }
    }
}
