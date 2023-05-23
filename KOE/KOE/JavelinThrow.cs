using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KOE
{
    class JavelinThrow
    {
        public int Id { get; set; }
        public string AthleteName { get; set; }
        public int Meters { get; set; }
        public int Centimeters { get; set; }

        public JavelinThrow (int id, int meters, int centimeters, string athleteName)
        {
            Id = id;
            Meters = meters;
            Centimeters = centimeters;
            AthleteName = athleteName;
        }
        
        


    }
}
