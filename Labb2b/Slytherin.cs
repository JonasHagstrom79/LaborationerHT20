using System;
using System.Collections.Generic;
using System.Text;

namespace Labb2b
{
    public class Slytherin : House
    {
        /// <summary>
        /// kontrollerar om första bokstaven är en konsonant
        /// </summary>
        /// <param name="currentPassword"></param>
        /// <returns></returns>
        public override bool FirstCharVowel(string currentPassword)
        {
            if (IsConsonant(currentPassword[0]))
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// kontrollerar att lösenordet är minst 8 tecken långt
        /// </summary>
        /// <param name="currentPassword"></param>
        /// <returns></returns>
        public override bool PasswordLenght5(string currentPassword)
        {
            if (currentPassword.Length >= 8)
            {
                return true;
            }
            return false;
        }

        public Slytherin() //kostruktor
        {
            HouseGhost = "Blodige Baronen";
            Mascot = "Orm";
            Password = "en ensam trollkarl";
            Members = new List<Wizard>(); //Måste ha en egen separat lista för boxarna
        }
    }
}
