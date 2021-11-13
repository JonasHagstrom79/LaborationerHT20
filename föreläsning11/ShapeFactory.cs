using System;
using System.Collections.Generic;
using System.Text;

namespace föreläsning11
{
    public class ShapeFactory //static är en statisk, man kan inte lagra saker i en sån
    {
        public shape CreateShape(string type, double width, double height) 
        {
            if (type == "Rectangle")
            {
                return new Rectangle()
                {
                    Heighth = height,
                    Width = width

                };
                
            }return null;
        
        }


    }


}
