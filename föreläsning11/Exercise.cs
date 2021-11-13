using System;
using System.Collections.Generic;
using System.Text;

namespace föreläsning11
{
    public class Exercise
    {
        public string Name { get; set; } = "uppgift x"; //ger den ett värde, varför vet jag inte

        public List<shape> shapes { get; set; } = new List<shape>(); //skapar ne ny lista
        //gör en lista från shapes egenskaper
        public double CalculateTotalArea() 
        {
            double sum = 0;
            foreach (shape shape in shapes)
            {
                sum += shape.CalculateArea();
            }
            return sum;
        }

        public Exercise(string Name) //En konstruktor        
        {
        
        
        }

        public bool IsAnswerCorrect(double guess)       //En ny metod  
        {
            if (guess == CalculateTotalArea()) //till lösenordet 09:29 FL12
            {
                return true;
            }
            return false;
        
        }

        public double TotalArea(string password) //om man säger rätt lösenord så visas CalculateTotalArea
        {
            return CalculateTotalArea();
        
        }
         
        
        
        

    }
}
