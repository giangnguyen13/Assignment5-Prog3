using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5_Prog3
{
    public class StockData
    {
        public string Symbol { get; set; }
        public DateTime ReleaseDate { get; set; }
        public double Open { get; set; }
        public double High { get; set; }
        public double Low { get; set; }
        public double Close { get; set; }
        public override string ToString()
        {
            string value = $"{Symbol} {ReleaseDate.ToString()} {Open} {High} {Low} {Close}";
            return value;
        }
    }
}
