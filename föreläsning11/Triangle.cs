using System;
using System.Collections.Generic;
using System.Text;

namespace föreläsning11
{
    public class Triangle : shape
    {


        #region Public methods 
        public override double CalculateArea()
        {
            return (Heighth * Width) / 2.0;
            //return base.CalculateArea();
        }


        //return (Heighth * Width) / 2.0; //få med decimal
    }

        #endregion


    }

}
