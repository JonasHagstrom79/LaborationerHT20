using System;
using System.Collections.Generic;
using System.Text;

namespace Godiskalkylator
{
    public class Person
    {
        public int Age { get; set; }

        public int Candies { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }
                
        public override string ToString() //måste vara override för att den ska kunna skriva ut texten
        {
            return $"{FirstName} {LastName} ({Age}år): {Candies} st";
        }
                       

    }
}
