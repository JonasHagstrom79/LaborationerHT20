using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Godiskalkylator
{
    public class CandyCalculator 
    {

        

        public List<Person> people { get; set; } //lista över personobjekt här

        public CandyCalculator() //**
        {
            people = new List<Person>();
        }

        /// <summary>
        /// generell basmetod som delar ut godisarna
        /// </summary>
        /// <param name="candy"></param>
        /// <param name="byAge"></param>
        /// <param name="byFirstName"></param>
        /// <param name="byLastName"></param>
        public void DistributeCandy(int candy, bool byAge, bool byFirstName, bool byLastName) 
        {
            
            
            int numCandy, numRestCandy;

            numCandy = candy / people.Count;
            numRestCandy = candy % people.Count;

            if (byAge == true) 
            {
                 DistributeCandyByAge();
            }
            else if (byFirstName)
            {
                DistributeCandyByFirstName();
            }
            else if (byLastName)
            {
                DistributeCandyByLastName();
            }
            foreach  (var person in people) //lokal variabel person i listan Person
            {
                person.Candies = 0; //nollställer godisarna efter varje utdelning
                person.Candies += numCandy; //Candies får värdet av numCandy
                if (numRestCandy >0 )
                {
                    person.Candies++;
                    numRestCandy--;
                }
            }                       

        }

        /// <summary>
        /// metod som delar ut godisarna efter ålder
        /// </summary>
        /// <returns></returns>
        public List<Person> DistributeCandyByAge() 
        {
            bool byAge = true;
            if (byAge)
            {
                people = people.OrderBy(person => person.Age).ToList(); //HÄR ÄR JAG
                
            }

            return people;
        }


        /// <summary>
        /// metod som delar ut godisarna efter förnamn
        /// </summary>
        /// <returns></returns>
        public List<Person> DistributeCandyByFirstName() 
        {
            bool byFirstName = true;
            if (byFirstName)
            {
                people = people.OrderBy(person => person.FirstName).ToList();
            }

            return people;
        }

        /// <summary>
        /// metod som delar ut godisarna efter efternamn
        /// </summary>
        /// <returns></returns>
        public List<Person> DistributeCandyByLastName() 
        {
            bool byLastName = true;
            if (byLastName)
            {
                people = people.OrderBy(person => person.Age).ToList();
            }
            return people;
        }

        
    }



}
