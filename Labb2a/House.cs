using System;
using System.Collections.Generic;
using System.Text;

namespace Labb2a
{   
    /// <summary>
    /// Denna klass får ma inte skapa objekt av
    /// Enbart en mall för att hålla gemensamma egenskaper
    /// </summary>
    public abstract class House
    {
        public string HouseGhost { get; set; }

        public string Mascot { get; set; }

        public List<Wizard> Members { get; set; } //här....members är en lista ni ska skapa i houseklasen

        public string Password { get; set; }

        //public override string ToString() //Testar bara
        //{
        //    return this.GetType().Name;
        //}

        /// <summary>
        /// sätter nytt lösenord efter att ha kontrollerat så det gammla är rätt och det nya uppfyller kraven
        /// </summary>
        /// <param name="currentPassword"></param>
        /// <param name="newPassword"></param>
        /// <returns></returns>
        public bool SetPassword(string currentPassword, string newPassword)
        {
            bool correctPasswordFormat = false;

            if (currentPassword == currentPassword && HasCorrectPasswordFormat(newPassword))
            {
                currentPassword = newPassword;
                correctPasswordFormat = true;
            }
            else
            {
                correctPasswordFormat = false;
            }
            return correctPasswordFormat;

        }
       
        /// <summary>
        /// kontrollerar rätt format på lösenord
        /// </summary>
        /// <param name="lösenord"></param>
        /// <returns></returns>
        public bool HasCorrectPasswordFormat(string currentPassword)
        {
            bool correctPasswordFormat = false;

            if (PasswordLenght5(currentPassword) == true && FirstCharVowel(currentPassword) == true && LastCharConsonant(currentPassword))
            {
                correctPasswordFormat = true;
            }
            else
            {
                correctPasswordFormat = false;
            }
            return correctPasswordFormat;
        }

        /// <summary>
        /// kontrollerar om första bokstaven är en vokal
        /// </summary>
        /// <param name="lösenord"></param>
        /// <returns></returns>
        public virtual bool FirstCharVowel(string currentPassword)
        {
            if (IsVowel(currentPassword[0]))
            {
                return true;
            }
            return false;

        }

        /// <summary>
        /// kontrollerar att lösenordet är minst 5 tecken långt
        /// </summary>
        /// <param name="lösenord"></param>
        /// <returns></returns>
        public virtual bool PasswordLenght5(string currentPassword)
        {
            if (currentPassword.Length >= 5)
            {
                return true;
            }
            return false;
        }               

        /// <summary>
        /// kontrollerar om sista bokstaven är en konsonant
        /// </summary>
        /// <param name="lösenord"></param>
        /// <returns></returns>
        public bool LastCharConsonant(string currentPassword)
        {

            int passwordLenght = currentPassword.Length - 1;

            if (IsConsonant(currentPassword[passwordLenght]))
            {
                return true;
            }
            return false;
        }
       
        /// <summary>
        /// undersöker om en bokstav är en vokal
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public bool IsVowel(char input)
        {
            string vowels = "aeiouyåäöAEIOUYÅÄÖ";

            foreach (char vowel in vowels)
            {
                if (vowel == input)
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// undersöker om en boksav är konsonant
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public bool IsConsonant(char input)
        {
            string consonants = "bcdfghjklmnpqrstvwzxBCDFGHJKLMNPQRSTVWZX";

            foreach (char consonant in consonants)
            {
                if (consonant == input)
                {
                    return true;
                }
            }
            return false;
        }

    }
}
