using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funktiot___MeterConverter
{
    class MeterConverter
    {
        
        // Methods
        public static double ToCentimeter (double meters)
        {
            return meters * 100;
        }

        public static double ToDecimeter (double meters)
        {
            return meters * 1000;
        }

        public static double ToKilometer (double meters)
        {
            return meters / 1000;
        }

        public static double ToFeet (double meters)
        {
            double foot = 0.3048;

            return foot * meters;

        }

        public static double ToInch (double meters)
        {
            double inch = 39.37007874;

            return inch * meters;
        }

        public static double ToYard (double meters)
        {
            double yard = 0.9144;

            return yard * meters;
        }




    }








}
