using System;
using System.Collections.Generic;
using System.Text;

namespace Labb2b
{
    public class Hogwarts
    {

        public Gryffindor Gryffindor { get; set; }

        public Hufflepuff Hufflepuff { get; set; }

        public Ravenclaw Ravenclaw { get; set; }

        public Slytherin Slytherin { get; set; }

        public Hogwarts() //en konstruktor 
        {
            Gryffindor = new Gryffindor();
            Hufflepuff = new Hufflepuff();
            Ravenclaw = new Ravenclaw();
            Slytherin = new Slytherin();
           
        }
              
              
                
        int count = 0;

        /// <summary>
        /// tilldelar trollkarlar till elevhemmen, ska ligga i klassen Hogwarts
        /// </summary>
        /// <param name="members"></param>
        /// <returns></returns>
        public House SortingHat(Wizard members) 
        {           
            if (count == 0)
            {
                Hufflepuff.Members.Add(members);
                count++;
                return Hufflepuff;
            }
            else if (count == 1)
            {
                Ravenclaw.Members.Add(members);
                count++;
                return Ravenclaw;
            }
            else if (count == 2)
            {
                Gryffindor.Members.Add(members);
                count++;
                return Gryffindor;
            }
            else
            {
                Slytherin.Members.Add(members);
                count = 0;
                return Slytherin;
            }
        }

           
           
             


    }
}
