using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5_Prog3
{
    // This is just sample model
    public class Patient
    {
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        public double Height { get; set; }
        public double Weight { get; set; }

        public override string ToString()
        {
            string value = $"{Name}, Age: {Age}, Gender: {Gender}, Height {Height} in, Weight {Weight} lbs";
            return value;
        }
    }
}
