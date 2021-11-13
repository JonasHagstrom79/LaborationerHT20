using System;
using System.Collections.Generic;
using System.Text;

namespace Labb2b
{
    public class Wizard
    {
        //Ingen lista över trollkarlar här!!

        public static readonly Random random = new Random();

        public string BloodStatus { get; set; }

        //Hur som helst. Våra trollkarlar kan vara av typen ”renblod”, ”halvblod”, ”mugglarfödd” eller ”okänt”.
        public bool DeathEater { get; set; }

        public bool DumbledoresArmy { get; set; }

        public string Name { get; set; }
        
        public override string ToString() //Annars kommer inte namnet i listan över trollkarlar, samma som comboboxen
        {
            return $"{Name}";
        }
        
        //bygg constructor här?
        public Wizard()
        {
            BloodStatus = WizardBloodStatus();
            DeathEater = IsDeathEater();
            DumbledoresArmy = Dumbledore();
        }
        /// <summary>
        /// metod som slumar fram blodstatus på en trollkarl
        /// </summary>
        /// <returns></returns>
        public string WizardBloodStatus()  //nytt torsdag, gjorde rätt från början
        {
            
            int intBloodStatus = random.Next(101);

            if (intBloodStatus <= 60)
            {
                BloodStatus = "Halvblod";
            }
            else if (intBloodStatus >= 61 && intBloodStatus <= 85)
            {
                BloodStatus = "Mugglarfödd";

            }
            else if (intBloodStatus >= 86 && intBloodStatus <= 95)
            {
                BloodStatus = "Fullblod";
            }
            else
            {
                BloodStatus = "Okänt";
            }
            return BloodStatus;
        }
        /// <summary>
        /// metod som slumpar om en trollkarl är deathEater baserd på blodstatusens sannolikhet för detta
        /// </summary>
        /// <returns></returns>
        public bool IsDeathEater() 
        {
            int randomDeathEater = random.Next(101);

            if (BloodStatus == "Halvblod" && randomDeathEater <= 25)
            {
                return true;
            }
            else if (BloodStatus == "Mugglarfödd" && randomDeathEater <= 15)
            {
                return true;
            }
            else if (BloodStatus == "Fullblod" && randomDeathEater <= 60)
            {
                return true;
            }
            else if (BloodStatus == "Okänt" && randomDeathEater <= 25)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// metod som slumpar om en trollkarl är med i Dumbledores Army baserad på sannolikheten för elev eller dödsätare
        /// </summary>
        /// <returns></returns>
        public bool Dumbledore() 
        {
            int randomDumbledoresArmy = random.Next(101);

            if (randomDumbledoresArmy <= 45 && IsDeathEater() == false) //kan ha! framför = inte är
            {
                return true;
            }
            else if (randomDumbledoresArmy <= 25 && IsDeathEater() == true) //mindre eller lika med //kan bara ha IsDEatheater
            {
                return true;//false;
            }
            else
            {
                return false;
            }            
        }      




    }
}
